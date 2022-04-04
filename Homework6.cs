/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab6
 * 	Project name: Homework6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Jasmine Reisler				
 *          Course-Section: CSCI 1250 - 940
 *           Creation Date:	 3/22/2022		
 * -------------------------------------------------------------------
 */

 class Homework6
 {
     static void Main(String[] args)
     {
        //Show character from string 
        System.Console.WriteLine("Please enter a string: ");
        string someString = Console.ReadLine();

        System.Console.WriteLine($"Please enter the numerical position of the letter you want to display. \nThis number must be a whole number less than or equal to {someString.Length}: ");
        double position = Convert.ToDouble(Console.ReadLine());

        ShowCharacter(someString, position);


        //Calculate retail price 
        System.Console.WriteLine("Please enter the wholesale cost: ");
        double cost = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Please enter the markup percentage (whole number): ");
        double markUp = ((Convert.ToDouble(Console.ReadLine())) / 100);

        System.Console.WriteLine($"The item's retail price is {CalculateRetail(cost, markUp)}");

        //Retreiving the F degrees temp
        System.Console.WriteLine("Please enter a temperature measured in fahrenheit: ");
        double fahTemp = Convert.ToDouble(Console.ReadLine());

        //For loop for Fah table 
        for (int i = 0; i <= 20; i ++)
        {
            System.Console.WriteLine($"The temperature {fahTemp + i} degrees Fahrenheit is {Math.Round(Celsius(fahTemp + i), 2)} degrees celsius.");
        }

        //Prime numbers
        char redo = 'Y';
        while (redo == 'Y')
        {
            System.Console.WriteLine("Please enter a number to be tested for primality: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((IsPrime(num)))
            {
                System.Console.WriteLine($"True; the number {num} is prime.");
            }
            else
            {
                System.Console.WriteLine($"False, the number {num} is not prime.");
            }

            System.Console.WriteLine("Do you want to repeat the program? Enter Y or N");
            redo = char.Parse(Console.ReadLine().ToUpper());
        
            while (redo != 'Y' && redo!= 'N')
            {
                System.Console.WriteLine("You did not enter a valid input. Please enter Y or N: ");
                redo = char.Parse(Console.ReadLine());
            } 

            if(redo == 'N')
            {        
                System.Console.WriteLine($"You entered {redo}. The program will now terminate.");
            }
            else 
            {
                System.Console.WriteLine($"You entered {redo}. The program will repeat.");
            }
        }
     }


    // Show Character Method 
    static void ShowCharacter(string word, double pos)
    {
        Console.WriteLine($"The character at position {pos} in the word {word} is {(word[(Convert.ToInt32(pos)-1)])}");
    }

    //Retail Price Method 
    static double CalculateRetail(double wholeCost, double percentage)
    {
        double retaillPrice = wholeCost + (wholeCost * percentage);
        return retaillPrice; 
    }

    //Temperature Table Method 
    static double Celsius(double fah)
    {
        double celsius = (5.0/9.0)*(fah - 32.0);
        return celsius; 
    }

    //Prime Numbers Method 
    static bool IsPrime(int userNum)
    {
        int primeCounter = 0;
        bool prime = false;
        for(int i=1; i <= userNum; i++)
        {
            if(userNum % i == 0)
            { 
                primeCounter++;
            }
        }
        if (primeCounter == 2)
        {
            prime = true; 
        }
        
        return prime; 
    } 
 }
/* Prime number method sources:
https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not

I could not figure out how to validate position input for method 1 in time */


