using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gif_Maker
{
    public partial class RenameProject : Form
    {
        public string ProjectName { get => textBox1.Text; set => textBox1.Text = value; }

        public RenameProject(string name)
        {
            InitializeComponent();
            ProjectName = name;
            textBox1.Focus();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
