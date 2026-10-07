using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VHOD2
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradingDBDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradingDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.tradingDBDataSet.Orders);

        }

        private void customer_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void customer_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void order_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void order_DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            f7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8();
            f8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
