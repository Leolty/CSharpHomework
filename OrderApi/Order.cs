using System.Collections.Generic;
using System;
using System.Linq;
using Exceptions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Serialization;
namespace OrderApi.Models
{
    public class Order:IComparable
    {
        [Key]
        public int OrderID{get;set;}
        private List<OrderItem> orderitem = new List<OrderItem>();
        public List<OrderItem> orderitems { get => orderitem; set => orderitem = value; }
        public string customerID{get;set;}
    

        public Order()
        {
            OrderID = 0;
            orderitems = new List<OrderItem>();
            customerID = "non-ID";
        }
        public Order(int oid,string cid)
        {
            OrderID = oid;
            customerID = cid;
        }
        public Order(int oid,string cid,List<OrderItem> list)
        {
            OrderID = oid;
            customerID = cid;
            foreach(OrderItem p in list)
                orderitems.Add(p);
        }
        
        public void AddItem(OrderItem temp,int num)
        {
            //OrderItem sth = new OrderItem(id,"sth",num,2);
            temp.num = num;
            if(orderitems.Contains(temp))
                throw new OrderException($"orderItem-{temp} is existed!");
            orderitems.Add(temp);
            Console.WriteLine("在订单"+OrderID+"增加商品"+temp.ItemID+",名称为:"+ temp.itemName+",份数:"+num+",价格:"+2);
        }
     
        public void DelItem(OrderItem sth)
        {
            //OrderItem sth = SearchItemID(itemid);
            if(orderitems.Remove(sth))
                Console.WriteLine("成功删除编号为"+sth.ItemID+"的商品");
            else throw new OrderItemException("编号为"+sth.ItemID+"的商品不存在");
        }
        
        internal void ModifItem(OrderItem p,int modify)
        {
            if(orderitems.Count(t => t.ItemID == p.ItemID) == 0)
                throw new OrderItemException("编号为"+p.ItemID+"的商品"+p.itemName+"不存在");
            p.num = modify;
            Console.WriteLine("修改订单"+OrderID+"中的商品"+p.ItemID+",份数为"+modify);
        }
        
        internal OrderItem SearchItemID(string itemid)
        {
           OrderItem temp =  orderitems.Where(s => s.ItemID == itemid).FirstOrDefault();
           if(temp == null) throw new OrderItemException("编号为"+itemid+"的商品不存在");
           else
           {
               return temp;
           } 
           
        }
        
        internal bool InOrder(string itemid)
        {
            var iter = from n in orderitems where n.ItemID != null select n.ItemID;
            foreach(string temp in iter)
            {
                if(temp.Equals(itemid))
                    return true;
            }
            return false;
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(OrderItem p in orderitems)
            {
                sb.Append(p.ToString());
            }
            string temp = "Order ID: "+OrderID  + Environment.NewLine 
                    +"Customer ID: "+ customerID + Environment.NewLine
                    +"Time: "  + Environment.NewLine
                    +"Item List: " + Environment.NewLine
                        + sb.ToString();
            return temp;
        }
        
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order!= null && OrderID == order.OrderID;
        }

        public int CompareTo(object obj)
        {
            Order p = obj as Order;
            if(p == null)
                throw new System.ArgumentException();
            return this.OrderID.CompareTo(p.OrderID);
        }
    
    }
}