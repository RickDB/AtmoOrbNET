using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using AtmoOrbApp.Properties;

namespace AtmoOrbApp
{
  public partial class Form1 : Form
  {
    private Socket _socket;
    private IPEndPoint _ipClientEndpoint;
    private bool _isConnected;

    private byte _red;
    private byte _green;
    private byte _blue;

    public Form1()
    {
      InitializeComponent();
      Connect();
      LoadSettings();
    }

    public void Connect()
    {
      try
      {
        if (!tbOrbIP.Text.Equals("0.0.0.0"))
        {
          var multiCastIp = IPAddress.Parse(tbOrbIP.Text);
          var port = int.Parse(tbOrbPort.Text);

          _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
          _ipClientEndpoint = new IPEndPoint(multiCastIp, port);
          _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership,
            new MulticastOption(multiCastIp));
          _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
          _socket.Connect(_ipClientEndpoint);

          _isConnected = true;
        }
      }
      catch (Exception e)
      {
        MessageBox.Show($"Error during ORB connection: {e.Message}");
      }
    }

    public void Reconnect()
    {
      if (_socket != null)
      {
        _socket.Close();
        _socket = null;
        _ipClientEndpoint = null;
      }

      _isConnected = false;

      Connect();
    }

    public void ChangeColor(byte red, byte green, byte blue, bool forceLightsOff)
    {
      if (!_isConnected)
      {
        return;
      }

      List<string> listOrbIds = new List<string>();
      listOrbIds.Add(tbOrbID.Text);

      if (tbOrbID.Text.Contains(","))
      {
        listOrbIds.Clear();

        string[] Orbs = tbOrbID.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in Orbs)
        {
          listOrbIds.Add(item);
        }
      }

      try
      {
        foreach (var orbID in listOrbIds)
        {
          byte commandCount = 24;
          byte[] bytes = new byte[3 + commandCount*3];

          // Command identifier: C0FFEE
          bytes[0] = 0xC0;
          bytes[1] = 0xFF;
          bytes[2] = 0xEE;

          // Options parameter: 1 = force off | 2 = validate command by Orb ID
          if (forceLightsOff)
          {
            bytes[3] = 1;
          }
          else
          {
            if (cbOrbSendToAll.Checked)
            {
              // Send to all Orbs
              bytes[3] = 0;
            }
            else
            {
              // Validate by Orb ID
              bytes[3] = 2;
            }
          }

          // Orb ID
          bytes[4] = byte.Parse(orbID);

          // RED / GREEN / BLUE
          bytes[5] = red;
          bytes[6] = green;
          bytes[7] = blue;

          _socket.Send(bytes, bytes.Length, SocketFlags.None);
        }
      }
      catch (Exception e)
      {
        MessageBox.Show("Error during send message.." + e.Message);
      }
    }

    public void SaveSettings()
    {
      Settings.Default.Save();
    }

    public void LoadSettings()
    {
      lblRedValue.Text = Settings.Default.RedValue.ToString();
      lblGreenValue.Text = Settings.Default.GreenValue.ToString();
      lblBlueValue.Text = Settings.Default.BlueValue.ToString();

      _red = byte.Parse(trackbarRed.Value.ToString());
      _green = byte.Parse(trackbarGreen.Value.ToString());
      _blue = byte.Parse(trackbarBlue.Value.ToString());
    }

    private void trackbarRed_Scroll(object sender, EventArgs e)
    {
      lblRedValue.Text = trackbarRed.Value.ToString();
      SaveSettings();
      _red = byte.Parse(trackbarRed.Value.ToString());
      ChangeColor(_red, _green, _blue, false);
    }

    private void trackbarGreen_Scroll(object sender, EventArgs e)
    {
      lblGreenValue.Text = trackbarGreen.Value.ToString();
      SaveSettings();
      _green = byte.Parse(trackbarGreen.Value.ToString());
      ChangeColor(_red, _green, _blue, false);
    }

    private void trackbarBlue_Scroll(object sender, EventArgs e)
    {
      lblBlueValue.Text = trackbarBlue.Value.ToString();
      SaveSettings();
      _blue = byte.Parse(trackbarBlue.Value.ToString());
      ChangeColor(_red, _green, _blue, false);
    }

    private void tbOrbIP_Validating(object sender, CancelEventArgs e)
    {
      Reconnect();
      SaveSettings();
    }

    private void tbOrbPort_Validating(object sender, CancelEventArgs e)
    {
      Reconnect();
      SaveSettings();
    }

    private void tbOrbID_Validating(object sender, CancelEventArgs e)
    {
      Reconnect();
      SaveSettings();
    }

    private void cbOrbSendToAll_CheckedChanged(object sender, EventArgs e)
    {
      tbOrbID.ReadOnly = cbOrbSendToAll.Checked;

      if (tbOrbID.ReadOnly)
      {
        tbOrbID.Text = @"0";
      }
    }

    private void tbOrbID_MouseHover(object sender, EventArgs e)
    {
      tooltip.SetToolTip(tbOrbID, "For multiple IDs at once separate them with a comma");
    }

    private void cbOrbSendToAll_MouseHover(object sender, EventArgs e)
    {
      tooltip.SetToolTip(cbOrbSendToAll, "Will send to all devices currently within selected the Multicast IP");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveSettings();
    }

    private void btnTurnOffOrbs_Click(object sender, EventArgs e)
    {
      ChangeColor(0, 0, 0, true);
    }
  }
}
