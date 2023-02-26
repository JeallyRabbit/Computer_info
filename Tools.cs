using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.VisualBasic;
using System.Management.Automation;
using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;

namespace Computer_Info
{
    internal class Tools
    {
        public static string GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        public static string GetLocalMac_Wlan()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up && n.Name.StartsWith("Wi-Fi"))
                {
                    addr += n.GetPhysicalAddress().ToString();
                    //MessageBox.Show(n.Name);
                    break;
                }
                //MessageBox.Show(n.Name);
            }
            string lan="";
            for(int i=0;i<addr.Length;i++)
            {   
                if(i%2==0 && i>0)
                {
                    lan += ":";
                }
                lan += addr[i];
                
            }
            return lan;
        }

        public static string GetLocalMac_Lan()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up && n.Name.StartsWith("Ethernet"))
                {
                    addr += n.GetPhysicalAddress().ToString();
                    //MessageBox.Show(n.Name);
                    break;
                }
                //MessageBox.Show(n.Name);
            }
            string lan = "";
            for (int i = 0; i < addr.Length; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    lan += ":";
                }
                lan += addr[i];

            }
            return lan;
        }

        public static string GetLocalSN()
        {

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");

            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    if(data.Name.ToString().StartsWith("SerialN"))
                    {
                        searcher.Dispose();
                        return data.Value.ToString();
                    }
                    //MessageBox.Show(data.Name.ToString() +" "+ data.Value.ToString());
                    //MessageBox.Show(data.Value.ToString() +" | "+data.Name.ToString() );
                }
            }
            searcher.Dispose();
            return "1";
        }
        
        public static string ask_Ip()
        {
            return Interaction.InputBox("New IP address:", "Adding IP address", "192.168.");
            //return ip;
        }

        public static string ask_host()
        {
            return Interaction.InputBox("New Hostname:", "Setting Hostname", "");
        }

        public static void set_host(string new_host)
        {
            PowerShell ps=PowerShell.Create();
            string command = "Rename - Computer - NewName " + new_host;
            ps.AddCommand(command);
            //ps.Invoke();
        }
    }
}
