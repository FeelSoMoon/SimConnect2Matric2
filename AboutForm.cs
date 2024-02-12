using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SimConnect2Matric2
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string matric_version = "12-Feb-2024";
            string sc_version = "11.0.62651.3";

            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;

            richTextBox1.AppendText($"This application is provided under GNU General Public License (GPL). If you require support then please pop into the Matric discord and drop me a message.\r\n\r\nSimConnect2Matric Version: {version}\r\nMatric Integration Version: {matric_version}\r\nSimConnect Version: {sc_version}\r\n\r\nAny donations go to purchasing our lead QA some more biscuits.\n\n");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string donate_link = "https://www.paypal.com/donate/?business=PGG4UGGB7V6SL&no_recurring=0&item_name=Donate+so+that+Lando+may+have+all+the+biscuits+his+heart+desires.&currency_code=GBP";
            System.Diagnostics.Process.Start(donate_link);
        }

    }
    public class UnfocusableRichTextBox : RichTextBox
    {
        // Constants for Windows messages
        private const int WM_SETFOCUS = 0x0007;

        protected override void WndProc(ref Message m)
        {
            // Intercept the WM_SETFOCUS message to prevent focus
            if (m.Msg == WM_SETFOCUS)
            {
                return;
            }

            // Call the base class implementation for other messages
            base.WndProc(ref m);
        }
    }
}
