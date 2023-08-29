using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACV3
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        public Form1()

        {
            InitializeComponent();
        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            CPS.Text = $"{siticoneTrackBar1.Value}";
        }

        private int randomisedCPS = 10;
        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            this.LeftClicker.Interval = 1000 / randomisedCPS;
            Process[] processesByName = Process.GetProcessesByName("javaw");
            foreach (Process process in processesByName)
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (CheckBox.Checked)
                    if (GetAsyncKeyState(Keys.LButton) < 0)
                    {
                        SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                        Task.Delay(20).Wait();
                        SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                    }
                }
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            this.randomisedCPS = new Random().Next(this.siticoneTrackBar1.Value - 7, this.siticoneTrackBar1.Value + 5);
        }

        private void CPS_Click(object sender, EventArgs e)
        {

        }

        private void bindbutton_KeyUp(object sender, KeyEventArgs e)
        {
            if (bindbutton.Text == "....")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    bindbutton.Text = "Bind";
                }
                else
                {
                    bindbutton.Text = e.KeyCode.ToString();
                }
            }
        }

        private void bindbutton_Click(object sender, EventArgs e)
        {
            bindbutton.Text = "....";
        }

        public static KeysConverter Key = new KeysConverter();
        private void Bind_Tick(object sender, EventArgs e)
        {
            if (bindbutton.Text != "Bind")
            {
                if (bindbutton.Text != "....")
                {
                    Keys key = (Keys)Key.ConvertFromString(bindbutton.Text);
                    if (GetAsyncKeyState(key) < 0)
                    {
                        CheckBox.Checked = !CheckBox.Checked;
                    }
                }
            }
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCtMDAFl8ji4OZZZIY5_I7Tw");
            System.Diagnostics.Process.Start("https://twitter.com/Zeldrixen");
        }

        bool mousedown;
        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void siticonePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }
}
