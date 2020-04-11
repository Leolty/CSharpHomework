using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class AddItemOrderForm : Form
    {
        public AddItemOrderForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public int index;
        public int quantity = 0;
        public bool iFlag;

        private void button_sure_Click(object sender, EventArgs e)
        {
            iFlag = true;
            index = Item_comboBox.SelectedIndex;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            iFlag = false;
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_num.Text = trackBar1.Value.ToString();
            quantity = trackBar1.Value;
        }
    }
}
