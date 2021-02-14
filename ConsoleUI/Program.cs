using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle

    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {

                Console.WriteLine(product.ProductName);
            }
        }
    }
}
