using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderItem
    {
        public string item_name;
        public double item_price;
        public int item_num;
        public string item_id;

        public OrderItem(string name, double price, int num, string id)
        {
            if (price > 0 && num > 0)
            {
                this.item_name = name;
                this.item_id = id;
                this.item_price = price;
                this.item_num = num;
            }
            else
            {
                throw new InputErrorException(name);
            }
        }

        public override bool Equals(object obj)
        {
            OrderItem orderitem = obj as OrderItem;
            return orderitem != null && orderitem.item_id == item_id && orderitem.item_num == item_num;
        }

        public override int GetHashCode()
        {
            return int.Parse(item_id) + item_num;
        }

        public override string ToString()
        {
            return " "+item_id + "       " + item_name + "       " + item_price + "       " + item_num+"\n";
        }
    }

}
