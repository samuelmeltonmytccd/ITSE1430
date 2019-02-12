using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ----------------------------------------------
// ----------------------------------------------
// ----------------------------------------------
//          HEADER
//
//  COURSE:         ITSE-1430-21722 
//  NAME:           Samuel Melton
//  DATE:           02 - 11 - 2019
// ----------------------------------------------
// ----------------------------------------------
// ----------------------------------------------

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            //main menu - does not give an error if the user selects an unavailable option, but I asked on (2/6/19) and was told that it's fine if it just loops back without an error. 
            Console.WriteLine("Welcome to pizza pizza!");
            string menuSelect = "";
            do
            {
                Console.WriteLine("--------- MAIN MENU ---------");
                Console.WriteLine("Current Price: \t\t\t{0:C}", pizzaPrice);
                Console.WriteLine("1) Create a New Order \n2) Modify Your Order \n3) Display your order \n4) Quit");
                menuSelect = Console.ReadLine();

                if (menuSelect == "1")
                    NewOrder();
                if (menuSelect == "2")
                    ModifyOrder();
                if (menuSelect == "3")
                    DisplayOrder();
                if ((menuSelect != "1") && (menuSelect != "2") && (menuSelect != "3"))
                    Console.WriteLine("Please enter a valid response.");
            } while (menuSelect != "4");
            Environment.Exit(0);
        }

        private static void NewOrder()
        {
            //First we check if an order has already been made here. If it has, we prompt to overwrite and reset variables, if not, we put them back to main menu
            if (isOrder == true)
            {
                string overWriteCheck = "";
                do
                {
                    Console.WriteLine("You already have an order created, if you continue you will overwrite your existing order. Continue? (Y/N)");
                    overWriteCheck = Console.ReadLine();
                    if (overWriteCheck == "N")
                        return;
                    if ((overWriteCheck != "Y") && (overWriteCheck != "N"))
                        Console.WriteLine("Please enter a valid response.");
                } while (overWriteCheck != "Y");

                //If user wants to overwrite order, we need to switch off all bool variables. Otherwise, the new order will carry over the previous selection's variables.
                isBacon = false;
                isHam = false;
                isPepperoni = false;
                isSausage = false;
                isOlives = false;
                isMushrooms = false;
                isOnions = false;
                isPeppers = false;
            }

            SizeSelection();
            MeatSelection();
            VegetableSelection();
            SauceSelection();
            CheeseSelection();
            DeliverySelection();
            DisplayOrder();

            //Here is where we flag that an order has been made. This is what allows us to prompt the user to overwrite next time this function is called.
            isOrder = true;
            return;
        }
        
        private static void ModifyOrder()
        {
            if (isOrder == false)
            {
                Console.WriteLine("There is no order to modify. Returning to the Main Menu");
                return;
            }

            Console.WriteLine("\n\n\n\n\n----------- Pizza size: -----------------\n" + pizzaSize);
            SizeSelection();

            MeatSelection();

            VegetableSelection();

            Console.WriteLine("----------- Pizza sauce: ------------------\n" + pizzaSauce);
            SauceSelection();

            Console.WriteLine("----------- Pizza cheese: -----------------\n" + pizzaCheese);
            CheeseSelection();

            Console.WriteLine("----------- Pizza delivery: ---------------\n" + pizzaDelivery);
            DeliverySelection();

            DisplayOrder();

            isOrder = true;
            return;
        }

        private static void SizeSelection()
        {
            string sizeInput = "";
            do
            {
                Console.WriteLine("What size? (1/2/3) \n1) Small ({0:C}) \n2) Medium ({1:C}) \n3) Large ({2:C})", sizeSmallPrice, sizeMediumPrice, sizeLargePrice);
                sizeInput = Console.ReadLine();

                if (sizeInput == "1")
                    pizzaSize = "Small";
                if (sizeInput == "2")
                    pizzaSize = "Medium";
                if (sizeInput == "3")
                    pizzaSize = "Large";
                if ((sizeInput != "1") && (sizeInput != "2") && (sizeInput != "3"))
                        Console.WriteLine("Please enter a valid response.");
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

                Console.WriteLine("What meats do you want? You can add as many as you want ({0:C} each). If you select the same meat twice, it will remove it. \"C\" to continue. (1/2/3/4/C)\n1) Bacon \n2) Ham \n3) Pepperoni \n4) Sausage ", meatPrice);
                meatInput = Console.ReadLine();

                if (meatInput == "1")
                    isBacon = !isBacon;
                if (meatInput == "2")
                    isHam = !isHam;
                if (meatInput == "3")
                    isPepperoni = !isPepperoni;
                if (meatInput == "4")
                    isSausage = !isSausage;
                if ((meatInput != "1") && (meatInput != "2") && (meatInput != "3") && (meatInput != "4") && (meatInput != "C"))
                    Console.WriteLine("Please enter a valid response.");
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

                Console.WriteLine("What vegetables do you want? You can add as many as you want ({0:C} each). If you select the same topping twice, it will remove it. \"C\" to continue. (1/2/3/4/C)\n1) Black olives \n2) Mushrooms \n3) Onions \n4) Peppers ", vegetablePrice);
                vegetableInput = Console.ReadLine();

                if (vegetableInput == "1")
                    isOlives = !isOlives;
                if (vegetableInput == "2")
                    isMushrooms = !isMushrooms;
                if (vegetableInput == "3")
                    isOnions = !isOnions;
                if (vegetableInput == "4")
                    isPeppers = !isPeppers;
                if ((vegetableInput != "1") && (vegetableInput != "2") && (vegetableInput != "3") && (vegetableInput != "4") && (vegetableInput != "C"))
                    Console.WriteLine("Please enter a valid response.");
            }
        }

        private static void SauceSelection()
        {
            string sauceInput = "";
            do
            {
                Console.WriteLine("What sauce? (1/2/3) \n1) Traditional ({0:C}) \n2) Garlic ({1:C}) \n3) Oregano ({2:C})", sauceTraditionalPrice, sauceGarlicPrice, sauceOreganoPrice);
                sauceInput = Console.ReadLine();

                if (sauceInput == "1")
                    pizzaSauce = "Traditional";
                if (sauceInput == "2")
                    pizzaSauce = "Garlic";
                if (sauceInput == "3")
                    pizzaSauce = "Oregano";
                if ((sauceInput != "1") && (sauceInput != "2") && (sauceInput != "3"))
                    Console.WriteLine("Please enter a valid response.");
            } while ((sauceInput != "1") && (sauceInput != "2") && (sauceInput != "3"));
        }

        private static void CheeseSelection()
        {
            string cheeseInput = "";
            do
            {
                Console.WriteLine("What cheese? (1/2) \n1) Regular ({0:C}) \n2) Extra ({1:C})", cheeseRegularPrice, cheeseExtraPrice);
                cheeseInput = Console.ReadLine();

                if (cheeseInput == "1")
                    pizzaCheese = "Regular";
                if (cheeseInput == "2")
                    pizzaCheese = "Extra";
                if ((cheeseInput != "Y") && (cheeseInput != "N"))
                    Console.WriteLine("Please enter a valid response.");
            } while ((cheeseInput != "1") && (cheeseInput != "2"));
        }

        private static void DeliverySelection()
        {
            string deliveryInput = "";
            do
            {
                Console.WriteLine("Take Out or Delivery? (1/2) \n1) Take Out ({0:C}) \n2) Delivery ({1:C})", deliveryTakeoutPrice, deliveryDeliveryPrice);
                deliveryInput = Console.ReadLine();

                if (deliveryInput == "1")
                    pizzaDelivery = "Take Out";
                if (deliveryInput == "2")
                    pizzaDelivery = "Delivery";
                if ((deliveryInput != "Y") && (deliveryInput != "N"))
                    Console.WriteLine("Please enter a valid response.");
            } while ((deliveryInput != "1") && (deliveryInput != "2"));
        }

        private static void DisplayOrder()
        {
            //resets price to 0 in the event that an order was made and then a new order has overwritten it
            pizzaPrice = 0m;

            //Submenu intro text
            Console.WriteLine("----------------Your Current Selections:----------------\n--------------------------------------------------------\n");

            //Pizza Size readout and price adjustment
            Console.WriteLine("----------- Pizza size: -----------------");
            if (pizzaSize == "Small")
            {
                pizzaPrice += sizeSmallPrice;
                Console.WriteLine(pizzaSize + "\t\t\t\t{0:C}", sizeSmallPrice);
            }
            if (pizzaSize == "Medium")
            {
                pizzaPrice += sizeMediumPrice;
                Console.WriteLine(pizzaSize + "\t\t\t\t{0:C}", sizeMediumPrice);
            }
            if (pizzaSize == "Large")
            {
                pizzaPrice += sizeLargePrice;
                Console.WriteLine(pizzaSize + "\t\t\t\t{0:C}", sizeLargePrice);
            }

            //Pizza Meat selection readout and selection logic, price adjustment
            Console.WriteLine("----------- Pizza meats: ----------------");
            if (isBacon == true)
            {
                Console.WriteLine("Bacon \t\t\t\t{0:C}", meatPrice);
                pizzaPrice += meatPrice;
            }
            if (isHam == true)
            {
                Console.WriteLine("Ham \t\t\t\t{0:C}", meatPrice);
                pizzaPrice += meatPrice;
            }
            if (isPepperoni == true)
            {
                Console.WriteLine("Pepperoni \t\t\t{0:C}", meatPrice);
                pizzaPrice += meatPrice;
            }
            if (isSausage == true)
            {
                Console.WriteLine("Sausage \t\t\t{0:C}", meatPrice);
                pizzaPrice += meatPrice;
            }
            if (isBacon == false && isHam == false && isPepperoni == false && isSausage == false)
                Console.WriteLine("No meats selected");

            //Pizza vegetable selection readout and selection logic, price adjustment
            Console.WriteLine("----------- Pizza vegetables: -----------");
            if (isOlives == true)
            {
                Console.WriteLine("Black olives \t\t\t{0:C}", vegetablePrice);
                pizzaPrice += vegetablePrice;
            }
            if (isMushrooms == true)
            {
                Console.WriteLine("Mushrooms \t\t\t{0:C}", vegetablePrice);
                pizzaPrice += vegetablePrice;
            }
            if (isOnions == true)
            {
                Console.WriteLine("Onions \t\t\t\t{0:C}", vegetablePrice);
                pizzaPrice += vegetablePrice;
            }
            if (isPeppers == true)
            {
                Console.WriteLine("Peppers \t\t\t{0:C}", vegetablePrice);
                pizzaPrice += vegetablePrice;
            }
            if (isOlives == false && isMushrooms == false && isOnions == false && isPeppers == false)
                Console.WriteLine("No vegetables selected");

            //Pizza Sauce readout and price adjustment
            Console.WriteLine("----------- Pizza sauce: ----------------");

            if (pizzaSauce == "Traditional")
            {
                pizzaPrice += sauceTraditionalPrice;
                Console.WriteLine(pizzaSauce + "\t\t\t{0:C}", sauceTraditionalPrice);
            }
            if (pizzaSauce == "Garlic")
            {
                pizzaPrice += sauceGarlicPrice;
                Console.WriteLine(pizzaSauce + "\t\t\t\t{0:C}", sauceGarlicPrice);
            }
            if (pizzaSauce == "Oregano")
            {
                pizzaPrice += sauceOreganoPrice;
                Console.WriteLine(pizzaSauce + "\t\t\t\t{0:C}", sauceOreganoPrice);
            }

            //Pizza Cheese readout and price adjustment
            Console.WriteLine("----------- Pizza cheese: ---------------");
            if (pizzaCheese == "Regular")
            {
                pizzaPrice += cheeseRegularPrice;
                Console.WriteLine(pizzaCheese + "\t\t\t\t{0:C}", cheeseRegularPrice);
            }
            if (pizzaCheese == "Extra")
            {
                pizzaPrice += cheeseExtraPrice;
                Console.WriteLine(pizzaCheese + "\t\t\t\t{0:C}", cheeseExtraPrice);
            }

            //Pizza delivery readout and price adjustment
            Console.WriteLine("----------- Pizza delivery: -------------");
            if (pizzaDelivery == "Take Out")
            {
                pizzaPrice += deliveryTakeoutPrice;
                Console.WriteLine(pizzaDelivery + "\t\t\t{0:C}", deliveryTakeoutPrice);
            }
            if (pizzaDelivery == "Delivery")
            {
                pizzaPrice += deliveryDeliveryPrice;
                Console.WriteLine(pizzaDelivery + "\t\t\t{0:C}", deliveryDeliveryPrice);
            }
            //Print price
            Console.WriteLine("----------- Price: ----------------------\n {0:C}\n\n\n", pizzaPrice);
        }

        //PRICE VARIABLES
        //Used to change the price of menu items quickly. Will correctly update all strings and price logic.
        private static decimal pizzaPrice = 0m;
        private static decimal meatPrice = .75m;
        private static decimal vegetablePrice = .50m;

        private static decimal sizeSmallPrice = 5m;
        private static decimal sizeMediumPrice = 6.25m;
        private static decimal sizeLargePrice = 8.75m;

        private static decimal sauceTraditionalPrice = 0m;
        private static decimal sauceGarlicPrice = 1m;
        private static decimal sauceOreganoPrice = 1m;

        private static decimal cheeseRegularPrice = 0m;
        private static decimal cheeseExtraPrice = 1.25m;

        private static decimal deliveryTakeoutPrice = 0m;
        private static decimal deliveryDeliveryPrice = 2.50m;

        //OTHER VARIABLES

        //size variables 
        private static string pizzaSize = "None selected";
        //sauce variable
        private static string pizzaSauce = "None selected";
        //cheese variable
        private static string pizzaCheese = "Not selected";
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

        //order already created flag
        private static bool isOrder = false;
    }
}
