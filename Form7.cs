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
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void order_ItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_ItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradingDBDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradingDBDataSet.Order_Items' table. You can move, or remove it, as needed.
            this.order_ItemsTableAdapter.Fill(this.tradingDBDataSet.Order_Items);

        }
    }
}
