using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            child.MdiParent = Form2.ActiveForm;
            child.Show();
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.MdiParent = Form2.ActiveForm;
            child.Show();


            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
