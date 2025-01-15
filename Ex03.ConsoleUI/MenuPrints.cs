using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;
namespace Ex03.ConsoleUI
{
    /// <summary>
    /// this class is responsable for all the menues prints
    /// </summary>
    static class MenuPrints
    {

        internal static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("***********GARAGE MENU***************\n");
            Console.WriteLine("1.Insert new vhicle");
            Console.WriteLine("2.Show Number Liecence");
            Console.WriteLine("3.Change Status Vichle");
            Console.WriteLine("4.Inflate Tier");
            Console.WriteLine("5.Add Fuel To Viechle");
            Console.WriteLine("6.Charge an Electric Vichle");
            Console.WriteLine("7.Show Vivhle details ");
            Console.WriteLine("8.Exit");

        }
        internal static void PrintInsertNewVhicleMenu()
        {
            Console.Clear();
            Console.WriteLine("****************Insert New Vhicle Menu***************\n");
            Console.WriteLine("1.Motorcycle");
            Console.WriteLine("2.Electrical Motorcycle");
            Console.WriteLine("3.Private Car");
            Console.WriteLine("4.Electrical Private Car");
            Console.WriteLine("5.Truck");
            Console.WriteLine("6.Back to main menu");
        }       
       
    }
}
