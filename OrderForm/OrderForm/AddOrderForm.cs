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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string customerName = "";
        public bool flag;
        
        public void button_sure_Click(object sender, EventArgs e)
        {
            customerName = textBox_name.Text;
            flag = true;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}
