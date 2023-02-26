namespace Computer_Info
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ip = new System.Windows.Forms.Button();
            this.btn_sn = new System.Windows.Forms.Button();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_lan = new System.Windows.Forms.Label();
            this.lbl_wlan = new System.Windows.Forms.Label();
            this.lbl_sn = new System.Windows.Forms.Label();
            this.btndhcp = new System.Windows.Forms.Button();
            this.lbl_dhcp_lan = new System.Windows.Forms.Label();
            this.lbl_dhcp_wlan = new System.Windows.Forms.Label();
            this.btn_get_host = new System.Windows.Forms.Button();
            this.lbl_host = new System.Windows.Forms.Label();
            this.btn_set_host = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ip
            // 
            this.btn_ip.Location = new System.Drawing.Point(12, 12);
            this.btn_ip.Name = "btn_ip";
            this.btn_ip.Size = new System.Drawing.Size(144, 83);
            this.btn_ip.TabIndex = 0;
            this.btn_ip.Text = "Show IP and MAC";
            this.btn_ip.UseVisualStyleBackColor = true;
            this.btn_ip.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btn_sn
            // 
            this.btn_sn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sn.Location = new System.Drawing.Point(341, 12);
            this.btn_sn.Name = "btn_sn";
            this.btn_sn.Size = new System.Drawing.Size(144, 83);
            this.btn_sn.TabIndex = 1;
            this.btn_sn.Text = "Show SN";
            this.btn_sn.UseVisualStyleBackColor = true;
            this.btn_sn.Click += new System.EventHandler(this.btnsn_Click);
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(12, 113);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(31, 25);
            this.lbl_ip.TabIndex = 2;
            this.lbl_ip.Text = "IP:";
            this.lbl_ip.Click += new System.EventHandler(this.lblip_Click);
            // 
            // lbl_lan
            // 
            this.lbl_lan.AutoSize = true;
            this.lbl_lan.Location = new System.Drawing.Point(12, 138);
            this.lbl_lan.Name = "lbl_lan";
            this.lbl_lan.Size = new System.Drawing.Size(96, 25);
            this.lbl_lan.TabIndex = 3;
            this.lbl_lan.Text = "MAC_LAN:";
            this.lbl_lan.Click += new System.EventHandler(this.lbllan_Click);
            // 
            // lbl_wlan
            // 
            this.lbl_wlan.AutoSize = true;
            this.lbl_wlan.Location = new System.Drawing.Point(12, 163);
            this.lbl_wlan.Name = "lbl_wlan";
            this.lbl_wlan.Size = new System.Drawing.Size(113, 25);
            this.lbl_wlan.TabIndex = 4;
            this.lbl_wlan.Text = "MAC_WLAN:";
            this.lbl_wlan.Click += new System.EventHandler(this.lblwlan_Click);
            // 
            // lbl_sn
            // 
            this.lbl_sn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sn.AutoSize = true;
            this.lbl_sn.Location = new System.Drawing.Point(341, 113);
            this.lbl_sn.Name = "lbl_sn";
            this.lbl_sn.Size = new System.Drawing.Size(39, 25);
            this.lbl_sn.TabIndex = 5;
            this.lbl_sn.Text = "SN:";
            this.lbl_sn.Click += new System.EventHandler(this.lblsn_Click);
            // 
            // btndhcp
            // 
            this.btndhcp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btndhcp.Location = new System.Drawing.Point(12, 255);
            this.btndhcp.Name = "btndhcp";
            this.btndhcp.Size = new System.Drawing.Size(144, 96);
            this.btndhcp.TabIndex = 7;
            this.btndhcp.Text = "Make DHCP record";
            this.btndhcp.UseVisualStyleBackColor = true;
            this.btndhcp.Click += new System.EventHandler(this.btndhcp_Click);
            // 
            // lbl_dhcp_lan
            // 
            this.lbl_dhcp_lan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dhcp_lan.AutoSize = true;
            this.lbl_dhcp_lan.Location = new System.Drawing.Point(12, 354);
            this.lbl_dhcp_lan.Name = "lbl_dhcp_lan";
            this.lbl_dhcp_lan.Size = new System.Drawing.Size(100, 25);
            this.lbl_dhcp_lan.TabIndex = 8;
            this.lbl_dhcp_lan.Text = "DHCP_LAN";
            this.lbl_dhcp_lan.Visible = false;
            this.lbl_dhcp_lan.Click += new System.EventHandler(this.lbl_dhcp_lan_Click);
            // 
            // lbl_dhcp_wlan
            // 
            this.lbl_dhcp_wlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dhcp_wlan.AutoSize = true;
            this.lbl_dhcp_wlan.Location = new System.Drawing.Point(12, 379);
            this.lbl_dhcp_wlan.Name = "lbl_dhcp_wlan";
            this.lbl_dhcp_wlan.Size = new System.Drawing.Size(117, 25);
            this.lbl_dhcp_wlan.TabIndex = 9;
            this.lbl_dhcp_wlan.Text = "DHCP_WLAN";
            this.lbl_dhcp_wlan.Visible = false;
            this.lbl_dhcp_wlan.Click += new System.EventHandler(this.lbl_dhcp_wlan_Click);
            // 
            // btn_get_host
            // 
            this.btn_get_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get_host.Location = new System.Drawing.Point(669, 12);
            this.btn_get_host.Name = "btn_get_host";
            this.btn_get_host.Size = new System.Drawing.Size(144, 83);
            this.btn_get_host.TabIndex = 10;
            this.btn_get_host.Text = "Show host name";
            this.btn_get_host.UseVisualStyleBackColor = true;
            this.btn_get_host.Click += new System.EventHandler(this.btn_host_Click);
            // 
            // lbl_host
            // 
            this.lbl_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(669, 113);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(132, 25);
            this.lbl_host.TabIndex = 11;
            this.lbl_host.Text = "HOST:              ";
            this.lbl_host.Click += new System.EventHandler(this.lbl_host_Click);
            // 
            // btn_set_host
            // 
            this.btn_set_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set_host.Location = new System.Drawing.Point(669, 262);
            this.btn_set_host.Name = "btn_set_host";
            this.btn_set_host.Size = new System.Drawing.Size(144, 83);
            this.btn_set_host.TabIndex = 12;
            this.btn_set_host.Text = "Set Host";
            this.btn_set_host.UseVisualStyleBackColor = true;
            this.btn_set_host.Click += new System.EventHandler(this.btn_set_host_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 463);
            this.Controls.Add(this.btn_set_host);
            this.Controls.Add(this.lbl_host);
            this.Controls.Add(this.btn_get_host);
            this.Controls.Add(this.lbl_dhcp_wlan);
            this.Controls.Add(this.lbl_dhcp_lan);
            this.Controls.Add(this.btndhcp);
            this.Controls.Add(this.lbl_sn);
            this.Controls.Add(this.lbl_wlan);
            this.Controls.Add(this.lbl_lan);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.btn_sn);
            this.Controls.Add(this.btn_ip);
            this.Name = "Form1";
            this.Text = "Computer Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ip;
        private Button btn_sn;
        private Label lbl_ip;
        private Label lbl_lan;
        private Label lbl_wlan;
        private Label lbl_sn;
        private Button btndhcp;
        private Label lbl_dhcp_lan;
        private Label lbl_dhcp_wlan;
        private Button btn_get_host;
        private Label lbl_host;
        private Button btn_set_host;
    }
}