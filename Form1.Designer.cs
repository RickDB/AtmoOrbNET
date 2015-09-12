namespace AtmoOrbApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lblRed = new System.Windows.Forms.Label();
      this.lblBlue = new System.Windows.Forms.Label();
      this.lblGreen = new System.Windows.Forms.Label();
      this.lblOrbMulticastIP = new System.Windows.Forms.Label();
      this.lblOrbPort = new System.Windows.Forms.Label();
      this.lblRedValue = new System.Windows.Forms.Label();
      this.lblGreenValue = new System.Windows.Forms.Label();
      this.lblBlueValue = new System.Windows.Forms.Label();
      this.tbOrbPort = new System.Windows.Forms.TextBox();
      this.tbOrbIP = new System.Windows.Forms.TextBox();
      this.trackbarGreen = new System.Windows.Forms.TrackBar();
      this.trackbarBlue = new System.Windows.Forms.TrackBar();
      this.trackbarRed = new System.Windows.Forms.TrackBar();
      this.btnTurnOffOrbs = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackbarGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackbarBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackbarRed)).BeginInit();
      this.SuspendLayout();
      // 
      // lblRed
      // 
      this.lblRed.AutoSize = true;
      this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRed.ForeColor = System.Drawing.Color.Red;
      this.lblRed.Location = new System.Drawing.Point(38, 124);
      this.lblRed.Name = "lblRed";
      this.lblRed.Size = new System.Drawing.Size(40, 17);
      this.lblRed.TabIndex = 3;
      this.lblRed.Text = "RED";
      // 
      // lblBlue
      // 
      this.lblBlue.AutoSize = true;
      this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBlue.ForeColor = System.Drawing.Color.Blue;
      this.lblBlue.Location = new System.Drawing.Point(38, 258);
      this.lblBlue.Name = "lblBlue";
      this.lblBlue.Size = new System.Drawing.Size(48, 17);
      this.lblBlue.TabIndex = 4;
      this.lblBlue.Text = "BLUE";
      // 
      // lblGreen
      // 
      this.lblGreen.AutoSize = true;
      this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.lblGreen.Location = new System.Drawing.Point(38, 195);
      this.lblGreen.Name = "lblGreen";
      this.lblGreen.Size = new System.Drawing.Size(62, 17);
      this.lblGreen.TabIndex = 5;
      this.lblGreen.Text = "GREEN";
      // 
      // lblOrbMulticastIP
      // 
      this.lblOrbMulticastIP.AutoSize = true;
      this.lblOrbMulticastIP.Location = new System.Drawing.Point(38, 32);
      this.lblOrbMulticastIP.Name = "lblOrbMulticastIP";
      this.lblOrbMulticastIP.Size = new System.Drawing.Size(85, 13);
      this.lblOrbMulticastIP.TabIndex = 8;
      this.lblOrbMulticastIP.Text = "Orb Multicast IP:";
      // 
      // lblOrbPort
      // 
      this.lblOrbPort.AutoSize = true;
      this.lblOrbPort.Location = new System.Drawing.Point(38, 70);
      this.lblOrbPort.Name = "lblOrbPort";
      this.lblOrbPort.Size = new System.Drawing.Size(46, 13);
      this.lblOrbPort.TabIndex = 9;
      this.lblOrbPort.Text = "Orb Port";
      // 
      // lblRedValue
      // 
      this.lblRedValue.AutoSize = true;
      this.lblRedValue.Location = new System.Drawing.Point(41, 141);
      this.lblRedValue.Name = "lblRedValue";
      this.lblRedValue.Size = new System.Drawing.Size(13, 13);
      this.lblRedValue.TabIndex = 10;
      this.lblRedValue.Text = "0";
      // 
      // lblGreenValue
      // 
      this.lblGreenValue.AutoSize = true;
      this.lblGreenValue.Location = new System.Drawing.Point(41, 212);
      this.lblGreenValue.Name = "lblGreenValue";
      this.lblGreenValue.Size = new System.Drawing.Size(13, 13);
      this.lblGreenValue.TabIndex = 11;
      this.lblGreenValue.Text = "0";
      // 
      // lblBlueValue
      // 
      this.lblBlueValue.AutoSize = true;
      this.lblBlueValue.Location = new System.Drawing.Point(41, 275);
      this.lblBlueValue.Name = "lblBlueValue";
      this.lblBlueValue.Size = new System.Drawing.Size(13, 13);
      this.lblBlueValue.TabIndex = 12;
      this.lblBlueValue.Text = "0";
      // 
      // tbOrbPort
      // 
      this.tbOrbPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoOrbApp.Properties.Settings.Default, "OrbPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbOrbPort.Location = new System.Drawing.Point(143, 67);
      this.tbOrbPort.Name = "tbOrbPort";
      this.tbOrbPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.tbOrbPort.Size = new System.Drawing.Size(77, 20);
      this.tbOrbPort.TabIndex = 7;
      this.tbOrbPort.Text = global::AtmoOrbApp.Properties.Settings.Default.OrbPort;
      this.tbOrbPort.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrbPort_Validating);
      // 
      // tbOrbIP
      // 
      this.tbOrbIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtmoOrbApp.Properties.Settings.Default, "OrbIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbOrbIP.Location = new System.Drawing.Point(143, 29);
      this.tbOrbIP.Name = "tbOrbIP";
      this.tbOrbIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.tbOrbIP.Size = new System.Drawing.Size(77, 20);
      this.tbOrbIP.TabIndex = 6;
      this.tbOrbIP.Text = global::AtmoOrbApp.Properties.Settings.Default.OrbIP;
      this.tbOrbIP.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrbIP_Validating);
      // 
      // trackbarGreen
      // 
      this.trackbarGreen.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AtmoOrbApp.Properties.Settings.Default, "GreenValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.trackbarGreen.Location = new System.Drawing.Point(120, 195);
      this.trackbarGreen.Maximum = 255;
      this.trackbarGreen.Name = "trackbarGreen";
      this.trackbarGreen.Size = new System.Drawing.Size(477, 45);
      this.trackbarGreen.TabIndex = 2;
      this.trackbarGreen.TickFrequency = 5;
      this.trackbarGreen.Value = global::AtmoOrbApp.Properties.Settings.Default.GreenValue;
      this.trackbarGreen.Scroll += new System.EventHandler(this.trackbarGreen_Scroll);
      // 
      // trackbarBlue
      // 
      this.trackbarBlue.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AtmoOrbApp.Properties.Settings.Default, "BlueValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.trackbarBlue.Location = new System.Drawing.Point(120, 258);
      this.trackbarBlue.Maximum = 255;
      this.trackbarBlue.Name = "trackbarBlue";
      this.trackbarBlue.Size = new System.Drawing.Size(477, 45);
      this.trackbarBlue.TabIndex = 1;
      this.trackbarBlue.TickFrequency = 5;
      this.trackbarBlue.Value = global::AtmoOrbApp.Properties.Settings.Default.BlueValue;
      this.trackbarBlue.Scroll += new System.EventHandler(this.trackbarBlue_Scroll);
      // 
      // trackbarRed
      // 
      this.trackbarRed.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AtmoOrbApp.Properties.Settings.Default, "RedValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.trackbarRed.Location = new System.Drawing.Point(120, 124);
      this.trackbarRed.Maximum = 255;
      this.trackbarRed.Name = "trackbarRed";
      this.trackbarRed.Size = new System.Drawing.Size(477, 45);
      this.trackbarRed.TabIndex = 0;
      this.trackbarRed.TickFrequency = 5;
      this.trackbarRed.Value = global::AtmoOrbApp.Properties.Settings.Default.RedValue;
      this.trackbarRed.Scroll += new System.EventHandler(this.trackbarRed_Scroll);
      // 
      // btnTurnOffOrbs
      // 
      this.btnTurnOffOrbs.Location = new System.Drawing.Point(480, 29);
      this.btnTurnOffOrbs.Name = "btnTurnOffOrbs";
      this.btnTurnOffOrbs.Size = new System.Drawing.Size(107, 68);
      this.btnTurnOffOrbs.TabIndex = 13;
      this.btnTurnOffOrbs.Text = "Turn off all Orbs";
      this.btnTurnOffOrbs.UseVisualStyleBackColor = true;
      this.btnTurnOffOrbs.Click += new System.EventHandler(this.btnTurnOffOrbs_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(609, 330);
      this.Controls.Add(this.btnTurnOffOrbs);
      this.Controls.Add(this.lblBlueValue);
      this.Controls.Add(this.lblGreenValue);
      this.Controls.Add(this.lblRedValue);
      this.Controls.Add(this.lblOrbPort);
      this.Controls.Add(this.lblOrbMulticastIP);
      this.Controls.Add(this.tbOrbPort);
      this.Controls.Add(this.tbOrbIP);
      this.Controls.Add(this.lblGreen);
      this.Controls.Add(this.lblBlue);
      this.Controls.Add(this.lblRed);
      this.Controls.Add(this.trackbarGreen);
      this.Controls.Add(this.trackbarBlue);
      this.Controls.Add(this.trackbarRed);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "AtmoOrb - Color control";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.trackbarGreen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackbarBlue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackbarRed)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackbarRed;
    private System.Windows.Forms.TrackBar trackbarBlue;
    private System.Windows.Forms.TrackBar trackbarGreen;
    private System.Windows.Forms.Label lblRed;
    private System.Windows.Forms.Label lblBlue;
    private System.Windows.Forms.Label lblGreen;
    private System.Windows.Forms.TextBox tbOrbIP;
    private System.Windows.Forms.TextBox tbOrbPort;
    private System.Windows.Forms.Label lblOrbMulticastIP;
    private System.Windows.Forms.Label lblOrbPort;
    private System.Windows.Forms.Label lblRedValue;
    private System.Windows.Forms.Label lblGreenValue;
    private System.Windows.Forms.Label lblBlueValue;
    private System.Windows.Forms.Button btnTurnOffOrbs;
  }
}

