using System;
using dotnet_POO.src.Entities;

namespace dotnet_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.Write(arus.Attack());
             Console.Write(wizard.Attack());
           
        }
    }
}
