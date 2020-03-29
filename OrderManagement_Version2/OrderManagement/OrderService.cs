using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrderManagement
{
    //Include all the functions of the order
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();
        public int orderAmount = 0;

        //Add order
        public bool AddOrder(string name, string id)
        {
            Order order = new Order(name, id);
            bool isRepeat = false;
            foreach(Order sth in orderList)
            {
                if (sth.Equals(order))
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
                orderList.Add(order);
                orderAmount++;
                return true;
            }
            else
            {
                throw new OrderRepeatException(id);
            }

        }

        //Index by ID, this function is used in DeleteOrder()
        public int FindIndexById(string id)
        {
            int i = 0;
            foreach (Order sth in orderList)
            {
                if (sth.order_id == id)
                    return i;
                i++;
            }
            throw new OrderNotExistException(id);
        }

        //Delet order
        public bool DeleteOrder(string id)
        {
            int index = FindIndexById(id);
            orderList.RemoveAt(index);
            orderAmount--;
            return true;
        }

        //Alter order
        public void ChangeOrder(string id, string after_name, string after_id)
        {
            int index = FindIndexById(id);
            orderList[index].order_name = after_name;
            orderList[index].order_id = after_id;

        }

        //Query's methods
        enum IndexMethod
        {
            IndexByOrderName = 0,
            IndexByOrderId = 1
        }

        //Find order
        public IEnumerable<Order> FindOrder(string inputString, int flag)
        {
            switch ((IndexMethod)flag)
            {
                case IndexMethod.IndexByOrderName:
                    {
                        var query = from order in orderList
                                    where order.order_name == inputString
                                    orderby order.sumPrice
                                    select order;
                        if (query.Count()>0)
                        {
                            return query;
                        }
                        else
                        {
                            throw new OrderNotExistException(inputString);
                        }
                    }
                case IndexMethod.IndexByOrderId:
                    {
                        var query = from order in orderList
                                    where order.order_id == inputString
                                    orderby order.sumPrice
                                    select order;
                        if (query.Count()>0)
                        {
                            return query;
                        }
                        else
                        {
                            throw new OrderNotExistException(inputString);
                        }
                    }
                default:
                    return null;
            }
        }

        //Sort orders
        public void SortOrder()
        {
            orderList.Sort((order1, order2) => int.Parse(order1.order_id).CompareTo(int.Parse(order2.order_id)));
        }
            

        //Print orders
        public void PrintOrders()
        {
            Console.WriteLine("Your order:");
            for (int i = 0; i < orderAmount; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Order" + (i + 1) + ":");
                Console.Write(orderList[i]);
                Console.WriteLine(" ");
            }
        }

        //Serialize orders
        public void Export(List<Order> orders)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }

            Console.WriteLine("\nSerialized as XML");
            Console.WriteLine(File.ReadAllText("order.xml"));

        }

        //Deserialize orders
        public List<Order> Import(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orders = new List<Order>();
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }

            Console.WriteLine("\nDeserialized from XML");
            foreach(var order in orders)
            {
                Console.WriteLine(order);
            }
            return orders;
        }
    }
}
