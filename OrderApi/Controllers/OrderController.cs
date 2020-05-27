using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderApi.Models;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDB;
        public OrderController(OrderContext context)
        {
            this.orderDB = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var Order = orderDB.Orders.Include(t => t.orderitems).FirstOrDefault(t => t.OrderID == id);
            if(Order == null)
            {
                return NotFound();
            }
            return Order;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string customerID,string itemid)
        {
            var query = buildQuery(customerID,itemid);
            if(query == null)
                return NotFound();
            return query.ToList();
        }

        [HttpGet("PageQuery")]
        public ActionResult<List<Order>> QueryOrders(string customerID,string itemid,int skip = 0,int take = 1)
        {
            var query = buildQuery(customerID,itemid).Skip(skip).Take(take);
            if(query == null)
                return NotFound();
            return query.ToList();
        }

        private IQueryable<Order> buildQuery(string customerID,string itemid)
        {
            IQueryable<Order> query = orderDB.Orders.Include(t => t.orderitems);
            if(customerID != null)
            {
                query = query.Where(t => t.customerID == customerID);
            }
            if(itemid != null)
            {
                query = query.Where(t => t.orderitems.Count(a => a.ItemID == itemid) > 0);
            }
            return query;
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try{
                orderDB.Orders.Add(order);
                orderDB.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpPost("{id}")]
        public ActionResult<OrderItem> PostOrderItem(int id,OrderItem orderitem)
        {
            try{
                var order = orderDB.Orders.Include(t => t.orderitems).FirstOrDefault(t => t.OrderID == id);
                order.AddItem(orderitem,orderitem.num);
                orderDB.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return orderitem;
        }


        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(long id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpPut("{id}/Modify")]
        public ActionResult<Order> PutOrderItem(long id, OrderItem orderitem)
        {
            var Orderitem = orderDB.OrderItems.FirstOrDefault(t => t.OrderID == id && t.ItemID == orderitem.ItemID);
            if(Orderitem == null)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                Orderitem.num = orderitem.num;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = orderDB.Orders.FirstOrDefault(t => t.OrderID == id);
                if (order != null)
                {
                    orderDB.Remove(order);
                    orderDB.SaveChanges();
                }
                else{
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}/{itemid}")]
        public ActionResult DeleteOrderItem(int id,string itemid)
        {
            try
            {
                var orderitem = orderDB.OrderItems.FirstOrDefault(t => t.OrderID == id && t.ItemID == itemid);
                
                if (orderitem != null)
                {
                    orderDB.Remove(orderitem);
                    orderDB.SaveChanges();
                }
                else{
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }




    }
}