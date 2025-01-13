using System;
using System.Collections.Generic;
using System.Text;
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
        internal static void PrintPrintVhicleMenu()
        {
            Console.Clear();
            Console.WriteLine("*********Show Number Liecence Menu*************\n");
            Console.WriteLine("1.Print vhicle by license num");
            Console.WriteLine("2.Print all in fixing");
            Console.WriteLine("3.Print all that fixed");
            Console.WriteLine("4.Print all vhicles");
            Console.WriteLine("5.Back To Main Menu");

        }
        internal static void ChangeStatusByLicense()
        {
            Console.Clear();
            Console.WriteLine("*************Change Status Vichle Menu***************\n");
            Console.WriteLine("1.Pick vhicle by license number");
            Console.WriteLine("2.Back to main menu");
        }

        internal static void PrintChangeStatusMenu()
        {
            Console.WriteLine("Pick for what status do you want to change\n");
            Console.WriteLine("1.In fixing");
            Console.WriteLine("2.Fixed");
            Console.WriteLine("3.Payed");
            Console.WriteLine("4.Back to previous menu");
        }


        internal static void PrintManageVhiclesMenu()
        {
            Console.WriteLine("Pick what you want to do with the car\n");
            Console.WriteLine("1.Enter Licence Number");
          /*  Console.WriteLine("2.Put air pressure");
            Console.WriteLine("3.Put Fuel / charge battery");
            Console.WriteLine("4.Back to previous menu");
        */}
  
        internal static void PrintMenuOfFuel()
        {
            Console.WriteLine("Please pick fuel kind");
            Console.WriteLine("1.Octan 95");
            Console.WriteLine("2.Octan 96");
            Console.WriteLine("3.Octan 98");
            Console.WriteLine("4. Soler");
            

        }
       
    }
}
