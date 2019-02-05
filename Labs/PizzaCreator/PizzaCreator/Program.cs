using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Welcome to pizza pizza!");
            Console.WriteLine("--------- MENU ---------");
            Console.WriteLine("1) Create a New Order \n2) Modify Your Order \n3) Display your order \n4) Quit");
            string menuSelect = Console.ReadLine();

            if (menuSelect == "1")
                NewOrder();
            //if (menuSelect == "2")
            //    ModifyOrder();
            if (menuSelect == "3")
                DisplayOrder();
                MainMenu();
            if (menuSelect == "4")
                return;
        }

        private static void NewOrder()
        {
            //TODO: Need to finish the rest of the pizza creation process. size, meats, vegetables, sauce, cheese, delivery. 

            SizeSelection();
            MeatSelection();
            return;
           
        }

        private static void SizeSelection()
        {
            //display order and choose size
            DisplayOrder();

            Console.WriteLine("What size? (1/2/3) \n1) Small ($5) \n2) Medium ($6.25) \n3) Large ($8.75)");
            string sizeInput = Console.ReadLine();
            if (sizeInput == "1")
                pizzaSize = "Small";
            if (sizeInput == "2")
                pizzaSize = "Medium";
            if (sizeInput == "3")
                pizzaSize = "Large";
        }

        private static void MeatSelection()
        {
            //choose meat
            //We create a bool value for each options(see bottom of "program"). When the user selects an option as displayed, we test that string to see which option they want. Then toggle the corresponding bool.
            //If the user inputs "C", break our while loop and move on. We also display the current order after every user input - so they know their current selection. 
            string meatInput = "";
            while (meatInput != "C")
            {
                DisplayOrder();

                Console.WriteLine("What meats do you want? You can add as many as you want ($0.75 each). If you select the same meat twice, it will remove it. \"C\" to exit. (1/2/3/4/C)\n1) Bacon \n2) Ham \n3) Pepperoni \n4) Sausage ");
                meatInput = Console.ReadLine();

                if (meatInput == "1")
                    isBacon = !isBacon;
                if (meatInput == "2")
                    isHam = !isHam;
                if (meatInput == "3")
                    isPepperoni = !isPepperoni;
                if (meatInput == "4")
                    isSausage = !isSausage;
            }

        }

        private static void DisplayOrder()
        {
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("----------- Pizza size: -----------\n" + pizzaSize);

            //TODO Need logic to figure out what meat was selected
            Console.WriteLine("----------- Pizza meats: -----------");
            if (isBacon == true)
                Console.WriteLine("Bacon ");
            if (isHam == true)
                Console.WriteLine("Ham ");
            if (isPepperoni == true)
                Console.WriteLine("Pepperoni ");
            if (isSausage == true)
                Console.WriteLine("Sausage");
            if (isBacon == false && isHam == false && isPepperoni == false && isSausage == false)
                Console.WriteLine("No meats selected");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");

            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n");
        }

        //variables 
        private static string pizzaSize = "None selected";
        private static bool isBacon = false;
        private static bool isHam = false;
        private static bool isPepperoni = false;
        private static bool isSausage = false;
    }
}
