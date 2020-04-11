using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        private OrderApp.OrderService os = new OrderApp.OrderService();
        private OrderApp.Order CurrentOrder = null;

        private OrderApp.Order order1 = new OrderApp.Order(1, "Leo", new List<OrderApp.OrderItem> { });
        private OrderApp.Order order2 = new OrderApp.Order(2, "Laurance", new List<OrderApp.OrderItem> { });

        private OrderApp.OrderItem orderitem1 = new OrderApp.OrderItem(1, "Apple", 1.5, 4);
        private OrderApp.OrderItem orderitem2 = new OrderApp.OrderItem(2, "Banana", 2, 2);
        private OrderApp.OrderItem orderitem3 = new OrderApp.OrderItem(3, "Mask", 0.5, 100);
        private OrderApp.OrderItem orderitem4 = new OrderApp.OrderItem(4, "Pencil", 3, 5);

        private OrderApp.OrderItem CurrentOrderItem = null;


        public string keys;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            order1.CreateTime = DateTime.Now;
            order2.CreateTime = DateTime.Now;

            order1.AddItem(orderitem1);
            order1.AddItem(orderitem2);
            order1.AddItem(orderitem4);
            CurrentOrder = order1;

            order2.AddItem(orderitem4);
            order2.AddItem(orderitem3);

            os.AddOrder(order1);
            os.AddOrder(order2);

            orderBindingSource.DataSource = os.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private int SelectedOrder = 0;
        private void orderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectedOrder = orderDataGridView.CurrentCellAddress.Y;
            if (SelectedOrder != -1)
            {
                orderItemBindingSource.DataSource = os.Orders[SelectedOrder].Items;
                orderItemBindingSource.ResetBindings(false);
                CurrentOrder = os.Orders[SelectedOrder];
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddOrderForm adf = new AddOrderForm();
            adf.ShowDialog();
            if (adf.flag == true)
            {
                try
                {
                    uint id = 0;
                    for (int i = 0; i < os.Orders.Count; i++)
                    {
                        if (os.Orders[i].OrderId > id)
                        {
                            id = os.Orders[i].OrderId;
                        }
                    }
                    var o = new OrderApp.Order(id + 1, adf.customerName, new List<OrderApp.OrderItem> { });
                    o.CreateTime = DateTime.Now;
                    os.AddOrder(o);
                    orderBindingSource.ResetBindings(false);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            AddOrderForm adf = new AddOrderForm();
            adf.Text = "修改订单";
            adf.ShowDialog();
            if (adf.flag == true)
            {
                try
                {
                    var o = new OrderApp.Order(CurrentOrder.OrderId, adf.customerName, CurrentOrder.Items);
                    os.UpdateOrder(o);
                    orderBindingSource.ResetBindings(false);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (CurrentOrder != null)
            {
                try
                {
                    os.RemoveOrder(CurrentOrder.OrderId);
                    orderBindingSource.ResetBindings(false);
                    dr = MessageBox.Show("删除成功！", "结果", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            AddItemOrderForm aiof = new AddItemOrderForm();
            aiof.ShowDialog();

            if (aiof.iFlag)
            {
                if (CurrentOrder != null)
                {
                    try
                    {
                        switch (aiof.index)
                        {
                            case 0:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(1, "Apple", 1.5, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                return;
                            case 1:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(2, "Banana", 2, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            case 2:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(3, "Mask", 0.5, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            case 3:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(4, "Pencil", 3, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            case 4:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(5, "Cup", 88, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            case 5:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(6, "Candy", 1, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            case 6:
                                CurrentOrder.AddItem(new OrderApp.OrderItem(7, "IPhone 11", 10899, (uint)aiof.quantity));
                                orderBindingSource.ResetBindings(false);
                                orderItemBindingSource.ResetBindings(false);
                                dr = MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            default:
                                dr = MessageBox.Show("请选择商品！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        Console.WriteLine(exception.StackTrace);
                    }
                }
            }
        }

        private int SelectedOrderItem = 0;
        private void orderItemDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectedOrderItem = orderItemDataGridView.CurrentCellAddress.Y;
            if (SelectedOrder != -1&&SelectedOrderItem!=-1)
            {
                CurrentOrderItem = CurrentOrder.Items[SelectedOrderItem];
            }
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            if (CurrentOrderItem != null)
            {
                try
                {
                    CurrentOrder.RemoveItem(CurrentOrderItem);
                    orderItemBindingSource.ResetBindings(false);
                    orderBindingSource.ResetBindings(false);
                    dr = MessageBox.Show("删除成功！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            keys = queryTextBox.Text;
            DialogResult dr;

            try
            {
                switch (queryCategoryBox.SelectedIndex)
                {
                    case 0:
                        orderBindingSource.DataSource = os.QueryOrdersByCustomerName(keys);
                        orderBindingSource.ResetBindings(false);
                        orderItemBindingSource.ResetBindings(false);
                        if (os.QueryOrdersByCustomerName(keys).Count !=0)
                        {
                            dr = MessageBox.Show("查询成功！", "查询结果", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr = MessageBox.Show("未查询到客户姓名为"+keys+"的客户！", "查询结果", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        return;
                    case 1:
                        orderBindingSource.DataSource = os.QueryOrdersByGoodsName(keys);
                        orderBindingSource.ResetBindings(false);
                        orderItemBindingSource.ResetBindings(false);
                        if (os.QueryOrdersByCustomerName(keys).Count != 0)
                        {
                            dr = MessageBox.Show("查询成功！", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dr = MessageBox.Show("查询失败！", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    default:
                        orderBindingSource.DataSource = os.Orders;
                        orderBindingSource.ResetBindings(false);
                        orderItemBindingSource.ResetBindings(false);
                        dr = MessageBox.Show("请选择查询方式！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

    }
}
