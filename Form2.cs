using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace CodyHelper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            Process off = new System.Diagnostics.Process();

            off.StartInfo.FileName = "cmd.exe";
            off.StartInfo.Arguments = "/c shutdown /s /t 0";
            off.Start();
        }

        private void btn_Direct_Click(object sender, EventArgs e)
        {
            Process dir = new System.Diagnostics.Process();

            dir.StartInfo.FileName = "cmd.exe";
            dir.StartInfo.Arguments = "/c dxdiag";
            dir.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process clean = new System.Diagnostics.Process();

            clean.StartInfo.FileName = "cmd.exe";
            clean.StartInfo.Arguments = "/c cleanmgr";
            clean.Start();
        }

        private void button_Man_Click(object sender, EventArgs e)
        {
            Process clean = new System.Diagnostics.Process();

            clean.StartInfo.FileName = "cmd.exe";
            clean.StartInfo.Arguments = "/c explorer";
            clean.Start();
        }

        private void btn_Ref_Click(object sender, EventArgs e)
        {
            Process _ref = new System.Diagnostics.Process();

            _ref.StartInfo.FileName = "cmd.exe";
            _ref.StartInfo.Arguments = "/c shutdown -r -t 0";
            _ref.Start();
        }

        private void btn_Reestr_Click(object sender, EventArgs e)
        {
            Process reest = new System.Diagnostics.Process();

            reest.StartInfo.FileName = "cmd.exe";
            reest.StartInfo.Arguments = "/c regedit";
            reest.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process speed = new System.Diagnostics.Process();

            speed.StartInfo.FileName = "cmd.exe";
            speed.StartInfo.Arguments = "/c perfmon";
            speed.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process symbol = new System.Diagnostics.Process();

            symbol.StartInfo.FileName = "cmd.exe";
            symbol.StartInfo.Arguments = "/c charmap";
            symbol.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process symbol = new System.Diagnostics.Process();

            symbol.StartInfo.FileName = "cmd.exe";
            symbol.StartInfo.Arguments = "/c dxdiag";
            symbol.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Hide();

            Form1 form1 = new Form1();

            form1.Show();
        }

        private void btn_codyVoice_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }
    }
}