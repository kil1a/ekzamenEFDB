// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");
using (var dbManagers = new DBManager())
{
    dbManagers.DelOrder();
}