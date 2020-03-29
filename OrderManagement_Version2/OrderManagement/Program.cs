using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。*/

/*1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
2、对订单程序中OrderService的各个Public方法添加测试用例。*/
namespace OrderManagement
{
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("My Store:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Commodity      Item Code       Price");
        Console.WriteLine(" APPLE            1001          7.2 ");
        Console.WriteLine(" BANANA           1002          10 ");
        Console.WriteLine(" GRAPE            1003          8.7 ");
        Console.WriteLine(" CHIP             1004          6.3");
        Console.WriteLine(" TEA              2001          3.5");
        Console.WriteLine(" COFFEE           2002          26");
        Console.WriteLine(" IPHONE           3001          12699 ");
        Console.WriteLine(" IPAD             3002          10299");
        Console.WriteLine(" PERFUME          4001          1099");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("How many orders do you want to make?");
        int orderNum = int.Parse(Console.ReadLine());

        OrderService OrderService = new OrderService();

        try
        {
            //Print order
            for (int i = 0; i < orderNum; i++)
            {
                Console.WriteLine("Please enter the number " + (i + 1) + " customer's name.");
                string name = Console.ReadLine();
                Order Order = new Order(name, "000" + (i + 1).ToString());
                OrderService.AddOrder(name, "000" + (i + 1).ToString());


                Console.WriteLine("Hi!" + Order.order_name + " :)");
                Console.WriteLine("How many kinds of commodities do you want to purchase?");
                int kindNum = int.Parse(Console.ReadLine());
                for (int j = 0; j < kindNum; j++)
                {
                    Console.WriteLine("Please enter the number " + (j + 1) + " commodity's name.");
                    string itemName = Console.ReadLine();
                    Console.WriteLine("Please enetr the number " + (j + 1) + " commodity's amount.");
                    int itemAmount = int.Parse(Console.ReadLine());
                    switch (itemName)
                    {
                        case "APPLE":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 7.2, itemAmount, "1001");
                            }
                            break;
                        case "BANANA":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 10, itemAmount, "1002");
                            }
                            break;
                        case "GRAPE":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 8.7, itemAmount, "1003");
                            }
                            break;
                        case "CHIP":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 6.3, itemAmount, "1004");
                            }
                            break;
                        case "TEA":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 3.5, itemAmount, "2001");
                            }
                            break;
                        case "COFFEE":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 26, itemAmount, "2002");
                            }
                            break;
                        case "IPHONE":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 12699, itemAmount, "3001");
                            }
                            break;
                        case "IPAD":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 10299, itemAmount, "3002");
                            }
                            break;
                        case "PERFUME":
                            {
                                OrderService.orderList[i].AddOrderItem(itemName, 1099, itemAmount, "4001");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("We do not provide this commodity!");
                                return;
                            }

                    }

                }
            }
            Console.WriteLine("----------------------------------------");
            OrderService.PrintOrders();

             //export and import text
            OrderService.Export(OrderService.orderList);
            OrderService.Import("order.xml");

            //Index
            Console.WriteLine("Please enter the method number that you want to query.");
            Console.WriteLine("Enter '0': Choose to index by order name.");
            Console.WriteLine("Enter '1': Choose to index by order ID.");
            int indexMethod = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the key word.");
            string keyword = Console.ReadLine();
            var queryResults = OrderService.FindOrder(keyword, indexMethod);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Here are the index results:");
            foreach (var queryResult in queryResults)
            {
                Console.WriteLine(queryResult);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            //Sort
            Console.WriteLine("Do you want to sort orders by order ID?");
            Console.WriteLine("If you want, please enter '1'.");
            if(Console.ReadLine()=="1")
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Here are the sorted orders:");
                OrderService.SortOrder();
                OrderService.PrintOrders();
            }


            //Delete
            Console.WriteLine("Delet orders.");
            Console.WriteLine("You can delet the order through entering order ID, please eneter the order ID");
            string IdForDelete = Console.ReadLine();
            OrderService.DeleteOrder(IdForDelete);
            OrderService.PrintOrders();

            //Alter
            Console.WriteLine("Change orders' information.");
            Console.WriteLine("You can change the order's information through entering order ID, please eneter the order ID");
            string IdForAlter = Console.ReadLine();
            Console.WriteLine("Please enter the name you want to change to:");
            string Alter_name = Console.ReadLine();
            Console.WriteLine("Please enter the order ID you want to change to:");
            string Alter_Id = Console.ReadLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Here are the altered orders:");
            OrderService.ChangeOrder(IdForAlter, Alter_name, Alter_Id);
            OrderService.PrintOrders();

        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is wrong");
        }
        catch(InputErrorException e)
        {
            Console.WriteLine("The " + e.Description + "'s price or quantity can be a non positive number.");
        }
        catch(OrderItemRepeatException e)
        {
            Console.WriteLine("The " + e.Description + " has already existed in your order.");
        }
        catch(OrderRepeatException e)
        {
            Console.WriteLine("The order which id is " + e.Description + " has already existed.");
        }
        catch(OrderNotExistException e)
        {
            Console.WriteLine("Can't find the order that its information includes " + e.Description);
        }

    }
}
}
