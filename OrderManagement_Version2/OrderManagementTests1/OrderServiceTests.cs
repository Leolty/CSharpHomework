using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        
        [TestMethod()]
        public void AddOrderTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");
            List<Order> orderlisttest = new List<Order> { new Order("Food", "01") };

            CollectionAssert.AreEqual(OrderServiceTest.orderList, orderlisttest);
            Assert.IsNotNull(OrderServiceTest.orderList);
            Assert.AreEqual(OrderServiceTest.orderAmount, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderRepeatException))]
        public void AddOrderTest2()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.orderList = new List<Order> { new Order("Food", "01") };
            OrderServiceTest.AddOrder("Food", "01");

            Assert.AreEqual(OrderServiceTest.orderAmount, 0);
        }

        [TestMethod()]
        public void FindIndexByIdTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");
            OrderServiceTest.AddOrder("Drink", "02");

            Assert.AreEqual(OrderServiceTest.FindIndexById("02"), 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderNotExistException))]
        public void FindIndexByIdTest2()
        {
            var OrderServiceTest = new OrderService();
            List<Order> orderlisttest = new List<Order> { new Order("Food", "01"), new Order("Drink", "02") };

            OrderServiceTest.FindIndexById("Suicide");
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");
            OrderServiceTest.DeleteOrder("01");
            List<Order> orderlisttest = new List<Order>();

            CollectionAssert.AreEqual(orderlisttest, OrderServiceTest.orderList);
            Assert.AreEqual(OrderServiceTest.orderAmount, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderNotExistException))]
        public void DeleteOrderTest2()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.DeleteOrder("01");
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");
            OrderServiceTest.ChangeOrder("01", "Drink", "02");
            List<Order> orderlisttest = new List<Order> { new Order("Drink", "02") };

            CollectionAssert.AreEqual(orderlisttest, OrderServiceTest.orderList);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderNotExistException))]
        public void ChangeOrderTest2()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.ChangeOrder("01", "Drink", "02");
        }

        [TestMethod()]
        public void FindOrderTest()
        {
            var OrderServiceTest = new OrderService();

            OrderServiceTest.AddOrder("Food", "01");
            OrderServiceTest.AddOrder("Drink", "02");

            var queryResultsByName = OrderServiceTest.FindOrder("Food", 0);
            var queryResultsByID = OrderServiceTest.FindOrder("02", 1);

            List<Order> first = new List<Order>() { new Order("Food", "01") };
            List<Order> orderlisttest1 = new List<Order>();
            foreach (var queryResult in queryResultsByName)
            {
                orderlisttest1.Add(queryResult);
            }

            CollectionAssert.AreEqual(orderlisttest1, first);

            List<Order> second = new List<Order>() { new Order("Drink", "02") };
            List<Order> orderlisttest2 = new List<Order>();
            foreach (var queryResult in queryResultsByID)
            {
                orderlisttest2.Add(queryResult);
            }

            CollectionAssert.AreEqual(orderlisttest2, second);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderNotExistException))]
        public void FindOrderTest2()
        {
            var OrderServiceTest = new OrderService();
            var queryResultsByName = OrderServiceTest.FindOrder("AABBCC", 0);

        }

        [TestMethod()]
        [ExpectedException(typeof(OrderNotExistException))]
        public void FindOrderTest3()
        {
            var OrderServiceTest = new OrderService();
            var queryResultsByName = OrderServiceTest.FindOrder("PPAP", 1);
        }

        [TestMethod()]
        public void SortOrderTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Drink", "02");
            OrderServiceTest.AddOrder("Ipad", "03");
            OrderServiceTest.AddOrder("Food", "01");

            OrderServiceTest.SortOrder();
            List<Order> orderlisttest = new List<Order> { new Order("Food", "01"), new Order("Drink", "02"),
                new Order("Ipad", "03") };

            CollectionAssert.AreEqual(orderlisttest,OrderServiceTest.orderList);
        }

        /*[TestMethod()]
        public void PrintOrdersTest()
        {
            
        }*/

        [TestMethod()]
        public void ExportTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");
            OrderServiceTest.Export(OrderServiceTest.orderList);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orderlisttest = new List<Order>();
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                orderlisttest = (List<Order>)xmlSerializer.Deserialize(fs);
            }

            CollectionAssert.AreEqual(orderlisttest, OrderServiceTest.orderList);

        }

        [TestMethod()]
        public void ImportTest()
        {
            var OrderServiceTest = new OrderService();
            OrderServiceTest.AddOrder("Food", "01");

            List<Order> orderlisttest = new List<Order>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderlisttest);
            }

            CollectionAssert.AreEqual(orderlisttest, OrderServiceTest.Import("order.xml"));
        }
    }
}