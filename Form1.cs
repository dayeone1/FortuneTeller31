using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 상담내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = new FormHistory();
            form.Show();
        }

        private void 포춘텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormAbout();
            form.ShowDialog();
        }
    }
}
