﻿while (true)
{
    try
    {
        Console.Write("Good Morning! Press any key to Continue: ");
        Console.ReadLine();
        Console.Write("Please Enter your First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please Enter your Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Please Enter your Middle Initial: ");
        char middleInitial = Convert.ToChar(Console.ReadLine());
        Console.Write("Please Enter your Age: ");
        int myAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you like pizza(Y/N)? ");
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            while (true)
            {

                try
                {
                    Console.Write("You may continue! ");
                    Console.ReadLine();
                    Console.Write("How many pizzas could you eat? ");
                    double pizzaAnswer = Convert.ToDouble(Console.ReadLine());
                    if (pizzaAnswer >= 3)
                    {
                        Console.Write("Nicccceeeeee, That is a lot of pizza!!! ");
                        Console.WriteLine();
                        Console.Write("What is the most you would spend on a Pizza? ");
                        decimal money = Convert.ToDecimal(Console.ReadLine());
                        Console.Write($"So let me get this straight.\nYour name is {firstName} {middleInitial} {lastName} \nYou are {myAge} years old \nYou really like pizza, so much so that you could eat {pizzaAnswer} pizzas \nThe most you would spend on one is ${money} dollars. \nIs this correct(Y/N)? ");
                        string lastAnswer = Console.ReadLine().ToUpper();
                        if (lastAnswer == "Y")
                        {
                            Console.Write("Wow, Now I know a lot about you!!!\nThank you for your time (^_^)");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.Write("Sorry you have to start over... :(");
                            Console.ReadLine();
                            break;
                        }

                    }
                    else
                    {
                        Console.Write("You can do better than that!!!");
                        Console.ReadLine();
                    }

                }
                catch (Exception e)
                {
                    Console.Write("Please Enter a Number and try again! ");
                    Console.ReadLine();
                }
            }
        }
        else
        {
     
            Console.Write("YOU DONT LIKE PIZZA?!?!?");
            Console.WriteLine(); 
            Console.Write("Are you sure(Y/N)? ");
            string newAnswer = Console.ReadLine().ToUpper();

            if (newAnswer == "Y")
            {
                Console.Write("Wow, I dont know what to say... Goodbye! ");
                Console.ReadLine();
                break;
            }
            else
            {
                Console.Write("I still don't know if I can trust you... Goodbye! ");
                Console.ReadLine();
                break;
            }
        }
    }

    catch(Exception e)
    {
        Console.Write($"There was a problem: {e.Message} Please try again.");
        Console.ReadLine();
    }

}