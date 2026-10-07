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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void deliveriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradingDBDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradingDBDataSet.Deliveries' table. You can move, or remove it, as needed.
            this.deliveriesTableAdapter.Fill(this.tradingDBDataSet.Deliveries);

        }
    }
}
