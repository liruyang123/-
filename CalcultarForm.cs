﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class CalcultarForm : Form
    {
        private string _data;

        public CalcultarForm(string data)
        {
            _data = data;
            InitializeComponent();
        }

        private void CalcultarForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = _data;
        }
    }
}