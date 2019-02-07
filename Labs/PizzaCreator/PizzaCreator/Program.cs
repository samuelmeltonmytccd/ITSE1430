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
            Console.WriteLine("Welcome to pizza pizza!");
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("--------- MAIN MENU ---------");
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
            //bool isOrder;
            //if (isOrder == true)
            //    Console.WriteLine("You already have an order created, if you continue you will overwrite your existing order. Continue? (Y/N)");


            SizeSelection();
            MeatSelection();
            VegetableSelection();
            SauceSelection();
            CheeseSelection();
            DeliverySelection();
            DisplayOrder();
            MainMenu();
            //isOrder = true;
        }

        private static void SizeSelection()
        {
            string sizeInput = "";
            do
            {
                Console.WriteLine("What size? (1/2/3) \n1) Small ($5) \n2) Medium ($6.25) \n3) Large ($8.75)");
                sizeInput = Console.ReadLine();

                if (sizeInput == "1")
                    pizzaSize = "Small";
                if (sizeInput == "2")
                    pizzaSize = "Medium";
                if (sizeInput == "3")
                    pizzaSize = "Large";
            } while ((sizeInput != "1") && (sizeInput != "2") && (sizeInput != "3"));
        }

        private static void MeatSelection()
        {
            //choose meat
            //We create a bool value for each options(see bottom of "program"). When the user selects an option as displayed, we test that string to see which option they want. Then toggle the corresponding bool.
            //If the user inputs "C", break our while loop and move on. We also display the current order after every user input - so they know their current selection. 
            string meatInput = "";
            while (meatInput != "C")
            {
                Console.WriteLine("-----------------Current Meat Selection-----------------");
                if (isBacon == true)
                    Console.WriteLine("Bacon");
                if (isHam == true)
                    Console.WriteLine("Ham");
                if (isPepperoni == true)
                    Console.WriteLine("Pepperoni");
                if (isSausage == true)
                    Console.WriteLine("Sausage");
                if (isBacon == false && isHam == false && isPepperoni == false && isSausage == false)
                    Console.WriteLine("No meats selected\n\n");

                Console.WriteLine("What meats do you want? You can add as many as you want ($0.75 each). If you select the same meat twice, it will remove it. \"C\" to continue. (1/2/3/4/C)\n1) Bacon \n2) Ham \n3) Pepperoni \n4) Sausage ");
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

        private static void VegetableSelection()
        {

            string vegetableInput = "";
            while (vegetableInput != "C")
            {
                Console.WriteLine("-----------------Current Vegetable Selection-----------------");
                if (isOlives == true)
                    Console.WriteLine("Black olives ");
                if (isMushrooms == true)
                    Console.WriteLine("Mushrooms ");
                if (isOnions == true)
                    Console.WriteLine("Onions ");
                if (isPeppers == true)
                    Console.WriteLine("Peppers");
                if (isOlives == false && isMushrooms == false && isOnions == false && isPeppers == false)
                    Console.WriteLine("No vegetables selected\n\n");

                Console.WriteLine("What vegetables do you want? You can add as many as you want ($0.50 each). If you select the same topping twice, it will remove it. \"C\" to continue. (1/2/3/4/C)\n1) Black olives \n2) Mushrooms \n3) Onions \n4) Peppers ");
                vegetableInput = Console.ReadLine();

                if (vegetableInput == "1")
                    isOlives = !isOlives;
                if (vegetableInput == "2")
                    isMushrooms = !isMushrooms;
                if (vegetableInput == "3")
                    isOnions = !isOnions;
                if (vegetableInput == "4")
                    isPeppers = !isPeppers;
            }

        }

        private static void SauceSelection()
        {
            string sauceInput = "";
            do
            {
                Console.WriteLine("What sauce? (1/2/3) \n1) Traditional ($0) \n2) Garlic ($1) \n3) Oregano ($1)");
                sauceInput = Console.ReadLine();

                if (sauceInput == "1")
                    pizzaSauce = "Traditional";
                if (sauceInput == "2")
                    pizzaSauce = "Garlic";
                if (sauceInput == "3")
                    pizzaSauce = "Oregano";
            } while ((sauceInput != "1") && (sauceInput != "2") && (sauceInput != "3"));
        }

        private static void CheeseSelection()
        {
            string cheeseInput = "";
            do
            {
                Console.WriteLine("What cheese? (1/2) \n1) Regular ($0) \n2) Extra ($1.25)");
                cheeseInput = Console.ReadLine();

                if (cheeseInput == "1")
                    pizzaCheese = "Regular";
                if (cheeseInput == "2")
                    pizzaCheese = "Extra";
            } while ((cheeseInput != "1") && (cheeseInput != "2"));

        }

        private static void DeliverySelection()
        {
            string deliveryInput = "";
            do
            {
                Console.WriteLine("Take Out or Delivery? (1/2) \n1) Take Out ($0) \n2) Delivery ($2.50)");
                deliveryInput = Console.ReadLine();

                if (deliveryInput == "1")
                    pizzaDelivery = "Take Out";
                if (deliveryInput == "2")
                    pizzaDelivery = "Delivery";
            } while ((deliveryInput != "1") && (deliveryInput != "2"));
        }

        private static void DisplayOrder()
        {
            //Submenu intro text
            Console.WriteLine("----------------Your Current Selections:----------------");

            //Pizza Size readout
            Console.WriteLine("\n\n\n\n\n----------- Pizza size: -----------------\n" + pizzaSize);

            //Pizza Meat selection readout and selection logic
            Console.WriteLine("----------- Pizza meats: ----------------");
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

            //Pizza vegetable selection readout and selection logic
            Console.WriteLine("----------- Pizza vegetables: -----------");
            if (isOlives == true)
                Console.WriteLine("Black olives ");
            if (isMushrooms == true)
                Console.WriteLine("Mushrooms ");
            if (isOnions == true)
                Console.WriteLine("Onions ");
            if (isPeppers == true)
                Console.WriteLine("Peppers");
            if (isOlives == false && isMushrooms == false && isOnions == false && isPeppers == false)
                Console.WriteLine("No vegetables selected");

            //Pizza Sauce readout
            Console.WriteLine("----------- Pizza sauce: ------------------\n" + pizzaSauce);

            //Pizza Cheese readout
            Console.WriteLine("----------- Pizza cheese: -----------------\n" + pizzaCheese);

            //Pizza delivery readout
            Console.WriteLine("----------- Pizza delivery: ---------------\n" + pizzaDelivery + "\n\n\n");
        }

        //size variables 
        private static string pizzaSize = "None selected";

        //sauce variable
        private static string pizzaSauce = "None selected";

        //cheese variable
        private static string pizzaCheese = "None selected";

        //Delivery variable
        private static string pizzaDelivery = "Not selected";

        //meat variables
        private static bool isBacon = false;
        private static bool isHam = false;
        private static bool isPepperoni = false;
        private static bool isSausage = false;

        //veggie variables
        private static bool isOlives = false;
        private static bool isMushrooms = false;
        private static bool isOnions = false;
        private static bool isPeppers = false;
    }
}
