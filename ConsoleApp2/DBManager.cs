using ConsoleApp2.DataBase;
using ConsoleApp2.DataBaseSTO.TablesBd;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DBManager:IDisposable
    {
        private const string HorizontalLine = "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
        private STODataBase _database = new STODataBase();

        public void DelOrder()
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Удаление заказа, введите id:");
            Orderss();
            Console.WriteLine("Заказ успешно удален!");
            Console.WriteLine(HorizontalLine);

        }



        public void Orderss()
        {
            Console.WriteLine("Какой заказ нужно удалить:");
            var DelOrder = new OrdersSTO();
            var id = Convert.ToInt32(Console.ReadLine());

            using (STODataBase db = new STODataBase())
            {

                db.OrdersTable.Remove(db.OrdersTable.First(o => o.ID == id));
                    db.SaveChanges();
                
            }

        }

        public void Dispose()
        {
        }
    }
}
