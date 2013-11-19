using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        int i4;
        public Form2(string p1, string p2, string p3, string p4)
        {
            InitializeComponent();
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            label1.Text = p1;
            label4.Text = p2;
            label6.Text = p3;
            label7.Text = p4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            i4 = 1;
            Form1 frm1 = new Form1(this.i4);
           frm1.ShowDialog();
           Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
