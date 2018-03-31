using MadWizard.WinUSBNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUsbNetExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadUsbBtn_Click(object sender, EventArgs e)
        {
            USBDeviceInfo[] devices = USBDevice.GetDevices("a5dcbf10-6530-11d2-901f-00c04fb951ed");
            
            deviceCountLbl.Text = devices.Count().ToString();
            usbDeviceListGridView.DataSource = devices;
        }
    }
}
