

using System;
/**       
*--------------------------------------------------------------------
* 	   File name: Homework 6
* 	Project name: Homework 6
*--------------------------------------------------------------------
* Author’s name and email:	Gracie Martin, marting3@etsu.edu		
*          Course-Section: CSCI 1250-001
*           Creation Date:	 10/3/2022
* -------------------------------------------------------------------
*/

public class Program
{
    public static void Main(string[] args)
    {
        ShowCharacter("New York", 2);
        Console.WriteLine(CalculateRetail());
         for (int i = 80; i <= 100; i++)
         {
            Console.WriteLine(Celsius(i));
         }
        Console.WriteLine(IsPrime(529));
    }
    static void ShowCharacter(string str, int num)
    {
        Console.WriteLine(str[num - 1]);
    }

    static double CalculateRetail()
    {
        Console.Write("\nEnter the item's wholesale cost: $ ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter its markup percentage: ");
        double markup = double.Parse(Console.ReadLine());

        double totalPrice = price + (price * (markup / 100));
        return Math.Round(totalPrice, 2);
    }

    static double Celsius(double fTemp)
    {

        double cTemp = 5.0 / 9.0 * (fTemp - 32);

        return cTemp;

    }

    static bool IsPrime(int number)
    {
        for (int denominator = 2; denominator < number / 2; denominator++)
        {
            if (number % denominator == 0)
            {
                return false;
            }
        }
        return true;
    }

}




