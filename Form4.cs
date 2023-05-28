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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst3DataSet.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.groupWst3DataSet.Customer1);
            // TODO: This line of code loads data into the 'groupWst3DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst3DataSet.Customer);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerTableAdapter.FillByCustomerFirstName(groupWst3DataSet.Customer, textBox1.Text);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customer1TableAdapter.FillByCustId(groupWst3DataSet.Customer1, (int)dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer1TableAdapter.UpdateAddress(textBox2.Text, (int)dataGridView2.CurrentRow.Cells[0].Value, (int)dataGridView2.CurrentRow.Cells[0].Value);
            MessageBox.Show("Address successfully updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer1TableAdapter.UpdateContactNumber(textBox3.Text, (int)dataGridView2.CurrentRow.Cells[0].Value, (int)dataGridView2.CurrentRow.Cells[0].Value);
            MessageBox.Show("Contact Number successfully updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer1TableAdapter.UpdateEmail(textBox4.Text, (int)dataGridView2.CurrentRow.Cells[0].Value, (int)dataGridView2.CurrentRow.Cells[0].Value);
            MessageBox.Show("Email Address successfully updated");
        }
    }
}
