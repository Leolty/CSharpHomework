using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        public string order_name;
        public string order_id;
        public DateTime order_time;
        public double sumPrice
        {
            get
            {
                double sumPrice = 0;
                foreach (OrderItem item in orderItemList)
                {
                    sumPrice += item.item_num * item.item_price;
                }

                return sumPrice;
            }
        }

        public Order(string name, string id)
        {
            this.order_name = name;
            this.order_id = id;
            this.order_time = DateTime.Now;
        }
        public List<OrderItem> orderItemList = new List<OrderItem>();

        public bool AddOrderItem(string name, double price, int num, string id)
        {
            OrderItem orderitem = new OrderItem(name, price, num, id);
            bool isRepeat = false;
            foreach (OrderItem sth in orderItemList)
            {
                if (orderitem.Equals(sth))
                {
                    isRepeat = true;
                }
                else
                {
                    isRepeat = false;
                }
            }
            if (!isRepeat)
            {
                orderItemList.Add(orderitem);
                return true;
            }
            else
            {
                throw new OrderItemRepeatException(name);
            }
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.order_id == order_id;
        }

        public override int GetHashCode()
        {
            return int.Parse(order_id);
        }

        public override string ToString()
        {
            string result = "";
            result += "-----------------------------\n";
            result += "Order Number: " + order_id + "\n";
            result += "Customer: " + order_name + "\n";
            result += "-----------------------------\n";
            result += "Item ID    Item Name   Price    Quantity\n";
            foreach (OrderItem orderItem in orderItemList)
            {
                result += orderItem;
            }
            result += "-----------------------------\n";
            result += "Total Price: " + this.sumPrice + "\n";
            result += "-----------------------------\n";

            return result;
        }

    }
}
