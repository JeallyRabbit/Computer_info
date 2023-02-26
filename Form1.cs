namespace Computer_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            //string a= Tools.GetLocalIPAddress();
            lbl_ip.Text = "IP: "+ Tools.GetLocalIPAddress();
            lbl_wlan.Text = "MAC_WLAN: " + Tools.GetLocalMac_Wlan();
            lbl_lan.Text = "MAC_LAN: " + Tools.GetLocalMac_Lan();
        }

        private void btnsn_Click(object sender, EventArgs e)
        {
            lbl_sn.Text="SN: " + Tools.GetLocalSN();
        }

        private void lblip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Tools.GetLocalIPAddress());
            //MessageBox.Show(Tools.GetLocalIPAddress());
        }

        private void lbllan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Tools.GetLocalMac_Lan());
            //MessageBox.Show(Tools.GetLocalMac_Lan());
        }

        private void lblwlan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Tools.GetLocalMac_Wlan());
        }

        private void lblsn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Tools.GetLocalSN());
        }

        private void btn_host_Click(object sender, EventArgs e)
        {
            lbl_host.Text= "Host: "+System.Net.Dns.GetHostName();
        }
        private void lbl_host_Click(object sender, EventArgs e)
        {
             Clipboard.SetText(System.Net.Dns.GetHostName());
        }

        private void btndhcp_Click(object sender, EventArgs e)
        {
            string lan = Tools.GetLocalMac_Lan();
            string wlan = Tools.GetLocalMac_Wlan();
            string ip=Tools.ask_Ip();
            lbl_dhcp_lan.Text= "host " + System.Net.Dns.GetHostName()+"_LAN { hardware ethernet " + lan + "; fixed-address " + ip + ";}";
            lbl_dhcp_wlan.Text = "host " + System.Net.Dns.GetHostName() + "_WLAN { hardware ethernet " + wlan + "; fixed-address " + ip + ";}";
            lbl_dhcp_lan.Visible = true;
            lbl_dhcp_wlan.Visible = true;

        }

        private void lbl_dhcp_lan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_dhcp_lan.Text);
        }

        private void lbl_dhcp_wlan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_dhcp_wlan.Text);
        }

        private void btn_set_host_Click(object sender, EventArgs e)
        {
            //string hostname = Tools.ask_host();
            Tools.set_host(Tools.ask_host());
        }
    }
}