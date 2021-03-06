﻿using System;
using System.Diagnostics;
using System.Windows.Forms;


/*******************************************************************/

/* File Name: Form2.cs                                             */

/* Date: 01-05-2018                                                */

/* Developer: ArtemGord1728                                        */

/* Copyright © 2018 ArtemGord1728. All rights reserved             */

/* Description: Main program functionality                         */

/*******************************************************************/


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
            Process off = new Process();

            off.StartInfo.FileName = "cmd.exe";
            off.StartInfo.Arguments = "/c shutdown /s /t 0";
            off.Start();
        }

        private void btn_Direct_Click(object sender, EventArgs e)
        {
            Process dir = new Process();

            dir.StartInfo.FileName = "cmd.exe";
            dir.StartInfo.Arguments = "/c dxdiag";
            dir.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process clean = new Process();

            clean.StartInfo.FileName = "cmd.exe";
            clean.StartInfo.Arguments = "/c cleanmgr";
            clean.Start();
        }

        private void button_Man_Click(object sender, EventArgs e)
        {
            Process clean = new Process();

            clean.StartInfo.FileName = "cmd.exe";
            clean.StartInfo.Arguments = "/c explorer";
            clean.Start();
        }

        private void btn_Ref_Click(object sender, EventArgs e)
        {
            Process _ref = new Process();

            _ref.StartInfo.FileName = "cmd.exe";
            _ref.StartInfo.Arguments = "/c shutdown -r -t 0";
            _ref.Start();
        }

        private void btn_Reestr_Click(object sender, EventArgs e)
        {
            Process reest = new Process();

            reest.StartInfo.FileName = "cmd.exe";
            reest.StartInfo.Arguments = "/c regedit";
            reest.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process speed = new Process();

            speed.StartInfo.FileName = "cmd.exe";
            speed.StartInfo.Arguments = "/c perfmon";
            speed.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process symbol = new Process();

            symbol.StartInfo.FileName = "cmd.exe";
            symbol.StartInfo.Arguments = "/c charmap";
            symbol.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process symbol = new Process();

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