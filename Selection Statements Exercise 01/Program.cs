﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Selection_Statements_Exericse_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete all of the TODOs for the Selection Statements below
            /* There will be:
             * if statements,
             * if/else statements,
             * if/else if/else statements,
             * and switch/case statements
            */

            #region IF Statements

            // Use these variables for the IF & IF/ELSE statements
            int if_count = 0;
            int else_if_count = 0;
            int else_count = 0;
            bool var1 = true;
            bool var2 = false;

            Console.WriteLine("IF, IF/ELSE, IF/ELSE IF/ELSE Statements");
            Util.CreateTitleBreak();

            Console.WriteLine("IF Statements");
            Util.CreateSectionBreak();



            // TODO: (True or False) Will this statement be executed? true
            // TODO: What will be printed to the console? if count 1
            // TODO: Check your anwer by printing it to the console
            if (true)
            {
                if_count++;
                Console.WriteLine($"IF statment count: {if_count}");
            }



            // TODO: Call the CreateStatementBreak() function for each selection statement
            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? false
            // TODO: What will be printed to the console? nothing
            // TODO: Check your anwer by printing it to the console
            if (false)
            {
                if_count++;
                Console.WriteLine($"If statement count: {if_count}.");
            }

            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? true  
            // TODO: What will be printed to the console? if count 2
            // TODO: Check your anwer by printing it to the console
            if (var1)
            {
                if_count++;
                Console.WriteLine($"if statement count : {if_count}.");
                
                
            }

            Util.CreateStatementBreak();



            // TODO: (True or False) Will this statement be executed? false
            // TODO: What will be printed to the console? nothing
            // TODO: Check your anwer by printing it to the console
            if (var2)
            {
                if_count++;
                Console.WriteLine($"if statement count : {if_count}.");
            }

            Util.CreateStatementBreak();
        

            #endregion

            #region IF/ELSE Statements

            // TODO: Call the CreateSectionBreak() function for the different selection statement sections
            Console.WriteLine("IF/ELSE Statements");
            Util.CreateSectionBreak();



            // TODO: Which statement gets run? The IF or ELSE statement? if
            // TODO: What will be printed to the console? if count 3
            // TODO: Check your anwer by printing it to the console 
            if (true)
            {
                if_count++;
            }
            else
            {
                else_count++;
            }
            Console.WriteLine($"if statement count : {if_count}.");
         
            Util.CreateStatementBreak();
            


            // TODO: Which statement gets run? The IF or ELSE statement? else
            // TODO: What will be printed to the console? else count 1
            // TODO: Check your anwer by printing it to the console 
            if (var2 == true)
            {
                if_count++;
            }
            else
            {
                else_count++;
            }
            Console.WriteLine($"if statement count : {if_count}.");
            Console.WriteLine($"else statement count : {else_count}.");
            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE statement? else   
            // TODO: What will be printed to the console? else count 2
            // TODO: Check your anwer by printing it to the console
            if (var1 == false)
            {
                if_count++;
            }
            else
            {
                else_count++;
            }
            Console.WriteLine($"if statement count : {if_count}.");
            Console.WriteLine($"else statement count : {else_count}.");
           
            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE statement? if     
            // TODO: What will be printed to the console? if count 4
            // TODO: Check your anwer by printing it to the console
            if (var2 == false)
            {
                if_count++;
            }
            else
            {
                else_count++;
            }
            Console.WriteLine($"if statement count : {if_count}.");
            Console.WriteLine($"else statement count : {else_count}.");
            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE statement? if    
            // TODO: What will be printed to the console?if count 5
            // TODO: Check your anwer by printing the count to the console
            if (var2 != var1)
            {
                if_count++;
            }
            else
            {
                else_count++;
            }
            Console.WriteLine($"if statement count : {if_count}.");
            Console.WriteLine($"else statement count : {else_count}.");

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF or ELSE statement? else
            // TODO: What will be printed to the console? else count 2
            if (if_count == else_count)
            {
                Util.PrintIfCount(if_count, else_count);
            }
            else
            {
                Util.PrintElseCount(else_count, if_count);
            }
        
            Util.CreateStatementBreak();

            #endregion

            #region IF/ELSE IF/ELSE Statements

            Console.WriteLine("IF/ELSE IF/ELSE Statements");
            Util.CreateSectionBreak();


            // Use these variables for the IF / ELSE IF / ELSE statements
            int x = 10;
            double y = -.0221;
            string z = "abc";
            if_count = 0; // resetting the value to 0 (re-initializing the variable to 0)
            else_count = 0; // reset
            else_if_count = 0; // reset



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement? else if
            // TODO: What will be printed to the console? x is greater than 0
            if (x == 0)
            {
                Console.WriteLine($"x equals 0");
            }
            else if (x > 0)
            {
                Console.WriteLine($"x is greater than 0");
            }
            else
            {
                Console.WriteLine($"x is less than 0");
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement? if 
            // TODO: What will be printed to the console? if statement count: 1
            if (y > 0 || z.Contains('c'))
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (x == 10)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }

            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement? else if  
            // TODO: What will be printed to the console? else if statement count 1
            if (!true && !false)
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (!true || !false)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }
           
            Util.CreateStatementBreak();



            // TODO: Which statement gets run? The IF, ELSE IF, or ELSE statement? else
            // TODO: What will be printed to the console? else statement count 1
            if (if_count > else_if_count && if_count > else_count)
            {
                if_count++;
                Console.WriteLine($"if statement count: {if_count}");
            }
            else if (else_if_count > if_count && else_if_count > else_count)
            {
                else_if_count++;
                Console.WriteLine($"else if statement count: {else_if_count}");
            }
            else
            {
                else_count++;
                Console.WriteLine($"else statement count: {else_count}");
            }
            Util.CreateStatementBreak();

            #endregion

            #region SWITCH/CASE Statements

            // Use these variables for the SWITCH/CASE Statements below
            var grades = new char[] { 'A', 'B', 'A', 'B', 'C', 'B', 'B', 'C', 'A', 'D', 'F', 'B' }; // A -> F
            var orders = new int[] { 1, 4, 2, 3, 1, 2, 1, 3, 5, 1, 4, 4, 3 }; // 1 -> 5
            var suits = new string[] { "Clubs", "Diamonds", "clubs", "hearts", "Spades", "diamonds", "Hearts", "spades" }; // clubs -> hearts

            // TODO: You can take in a user's input and replace the method with that instead for extra practice!

            // TODO: Complete the switch/case statement below to print a response to a given grade ( use the grades variable and the ChooseRandomGrade() method)
            // Ex: case 'A':
            //         Console.WriteLine("You got an A!");
            //         break;

            Console.WriteLine("What grade did you get in math?");
            char grade = Convert.ToChar(Console.ReadLine());

            while (grade == grade)
               
            {
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("You got an A?");
                        break;
                    case 'B':
                        Console.WriteLine("You got a B?");
                        break;
                    case 'C':
                        Console.WriteLine("You got a C?");
                        break;
                    case 'D':
                        Console.WriteLine("You got a D?");
                        break;
                    default:
                        Console.WriteLine("Sorry, you did not pass.");
                        break;
                }
                Console.WriteLine("Do you want to run again?");
                string isYes = Convert.ToString(Console.ReadLine());
                isYes = isYes.ToLower();
                var itsYes =  "yes";
                var itsNo = "no";

                if (isYes == itsYes)
                {
                    Console.WriteLine("Well, lets continue.");
                    
                }
                else if (isYes == itsNo)
                {
                    Console.WriteLine("Ok then bye.");
                    break;
                }




            } 





        switch (ChooseRandomOrder(orders))

            {
                case 1:
                    Console.WriteLine("Double double, animal fries, diet coke.");
                    break;
                case 2:
                    Console.WriteLine("Cheeseburger, fries, strawberry shake.");
                    break;
                case 3:
                    Console.WriteLine("Hamburger, salad, coffee.");
                    break;
                case 4:
                    Console.WriteLine("Spaghetti, meatballs, wine.");
                    break;
                case 5:
                    Console.WriteLine("Pizza, calzone, champagne.");
                    break;
                default:
                    Console.WriteLine("Sorry,Not on my menu.");
                    break;
                    Console.ReadLine();
            }
            // TODO: Create a switch/case to take a bunch of orders and print out the order to the console ( use the orders variable and the ChooseRandomOrder() method)
            // TODO: Create a switch/case to Take a collection of suits (regardless of capitalization) and print the suit to the console
            

            switch (ChooseRandomSuit(suits))
            {
                case "clubs":
                    Console.WriteLine("This is the suit of clubs.");
                    break;
                case "diamonds":
                    Console.WriteLine("This is the suit of diamonds.");
                    break;
                case "clovers":
                    Console.WriteLine("This is the suit of clovers");
                    break;
                case "spades":
                    Console.WriteLine("This is the suit of spades");
                    break;
                default:
                    Console.WriteLine("This is not a suit of cards, probably a joker.");
                    break;
            }
            Util.CreateStatementBreak();



            #endregion

        }

        public static char ChooseRandomGrade(char[] grades)
        {
            var rng = new Random();
            return grades[rng.Next(0, grades.Length - 1)];
        }

        public static int ChooseRandomOrder(int[] orders)
        {
            var rng = new Random();
           return orders[rng.Next(0, orders.Length - 1)];
        }

        public static string ChooseRandomSuit(string[] suits)
       {
            var rng = new Random();
           return suits[rng.Next(0, suits.Length - 1)];
        }
    }
}
