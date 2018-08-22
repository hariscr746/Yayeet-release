using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Yayeet_succes
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLuaCScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendCommand(string script);


        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            LaunchExploit();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SendCommand(bunifuMaterialTextbox1.Text);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Process.Start("Commands.txt");
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = true; 
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = true; 
        }

        private void materialRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
