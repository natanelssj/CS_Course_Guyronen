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
            Console.WriteLine("2.Manage vhicles");
            Console.WriteLine("3.Print vhicles");
            Console.WriteLine("4.Exit");
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
            Console.WriteLine("*********Print Vhicle Menu*************\n");
            Console.WriteLine("1.Print vhicle by license num");
            Console.WriteLine("2.Print all in fixing");
            Console.WriteLine("3.Print all that fixed");
            Console.WriteLine("4.Print all vhicles");
            Console.WriteLine("5.Print all vhicles basic data");
            Console.WriteLine("6.Back To Main Menu");

        }

        internal static void PrintVhiclesMenuBasic()
        {
            Console.Clear();
            Console.WriteLine("*************Manage Vhicles Menu***************\n");
            Console.WriteLine("1.See vhicles data and pick vhicle by license number");
            Console.WriteLine("2.Pick vhicle by license number");
            Console.WriteLine("3.Back to main menu");

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
            Console.WriteLine("1.Change Status");
            Console.WriteLine("2.Put air pressure");
            Console.WriteLine("3.Put Fuel / charge battery");
            Console.WriteLine("4.Back to previous menu");
        }



        
        internal static void PrintMenuOfFuel()
        {
            Console.WriteLine("Please pick fuel kind");
            Console.WriteLine("1.Octan 95");
            Console.WriteLine("2.Octan 96");
            Console.WriteLine("3.Octan 98");
            Console.WriteLine("4. Soler");
            

        }
        /*
        internal static void PrintColorsMenu()
        {
            Console.WriteLine("Please pick a color of the car");
            Console.WriteLine("1.{0}", Color.White);
            Console.WriteLine("2.{0}", Color.Black);
            Console.WriteLine("3.{0}", Color.Blue);
            Console.WriteLine("4.{0}", Color.Green);
            Console.WriteLine("5.{0}", Color.Yellow);
            Console.WriteLine("6.{0}", Color.Red);
            Console.WriteLine("7.Other ");
        }*/
        
    }
}
