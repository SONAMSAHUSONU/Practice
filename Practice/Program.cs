using System;



//1-Write C# program to print alphabets from a to z
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        char ch;

        Console.WriteLine("Alphabets from a - z are: ");
        for (ch = 'a'; ch <= 'z'; ch++)
        {
            //Printing all alphabets with tab
            Console.Write(ch + "\t");
        }

        Console.ReadLine();
    }
}*/
//2-Write C# program to print ASCII values of all characters
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int i;

        // Printing ASCII values from 0 to 255
        for (i = 0; i <= 255; i++)
        {
            Console.WriteLine("ASCII value of " + i + " = " + i);
        }
        Console.ReadLine();
    }
}*/
//3-Write C# program to print multiplication table of a given number
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int i, num;

        //Reading number
        Console.WriteLine("Enter number to print table: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= 10; i++)
        {
            //Printing table of number entered by user            
            Console.Write("{0} X {1} = {2} \n", num, i, num * i);
        }
        Console.ReadLine();
    }
}*/
//4-Write C# program to print all natural numbers in reverse order
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int i, num;

        //Read a number from user
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Running loop from the number entered by user,
         // and Decrementing by 1
        for (i = num; i >= 1; i--)
        {
            Console.WriteLine("\n" + i);
        }

        Console.ReadLine();
    }
}*/
//5-Write C# program to print sum of digits enter by user
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, total;

        //Reading number
        Console.WriteLine("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Adding sum of digit in total variable
        for (total = 0; num > 0; num = num / 10)
            total = total + (num % 10);

        //Printing sum of digit
        Console.WriteLine("Sum of digits: " + total);

        Console.ReadLine();
    }
}*/
//6-Write C# program to find sum of even numbers between 1 to n
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int i, num, sum = 0;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (i = 2; i <= num; i += 2)
        {
            //Adding current even number to sum variable
            sum += i;
        }
        Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);

        Console.ReadLine();
    }
}*/
//7-Write C# program to find sum of odd numbers between 1 to n
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int i, num, sum = 0;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= num; i += 2)
        {
            //Adding current odd number to sum variable
            sum += i;
        }
        Console.WriteLine("Sum of all odd numbers between 1 to " + num + " = " + sum);

        Console.ReadLine();
    }
}*/
//8-Write C# program to swap first and last digit of a number
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, last, first, temp, count = 0;
        double swap;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        temp = num;
        last = temp % 10;
        count = (int)Math.Log10(temp);

        while (temp >= 10)
        {
            temp /= 10;
        }
        first = temp;
        swap = (last * Math.Pow(10, count) + first) + (num - (first * Math.Pow(10, count) + last));

        Console.WriteLine("Last Digit:" + last);

        Console.WriteLine("First Digit:" + first);

        Console.WriteLine(num + " is swapped to " + swap);

        Console.ReadLine();
    }
}*/
//9-Write C# program to find the sum of first and last digit of any number
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, sum = 0, firstDigit, lastDigit;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        lastDigit = num % 10;

        firstDigit = num;

        while (num >= 10)
        {
            num = num / 10;
        }
        firstDigit = num;

        //Finding sum of first and last digit
        sum = firstDigit + lastDigit;

        Console.WriteLine("Sum of first and last digit: " + sum);

        Console.ReadLine();
    }
}*/
/*10-Write C# program to find first and last digit of any number
public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, last;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        last = num % 10;
        Console.WriteLine("The last digit of entered number: " + last);

        while (num >= 10)
        {
            num = num / 10;
        }

        Console.WriteLine("The first digit of entered number: " + num);

        Console.ReadLine();
    }
}*/
//11-Write C# program to calculate product of digits of a number
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, product = 1;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Repeat the steps till n becomes 0
        while (num != 0)
        {
            product = product * (num % 10);

            // Remove the last digit from n
            num = num / 10;
        }

        Console.WriteLine("Product of digits = " + product);

        Console.ReadLine();
    }
}*/
//12-Write C# program to reverse a number
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, rev = 0;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //finding reverse number using while loop
        while (num > 0)
        {
            rev = rev * 10;
            rev = rev + num % 10;
            num = num / 10;
        }

        Console.Write("Reversed number is = " + rev);

        Console.ReadLine();
    }
}*/
//13-Write C# program to calculate power using while & for loop
/*public class csharpExercise
{
    static void Main(string[] args)
    {

        int basenumber, exponent, power, i;

        // Reading number
        Console.Write("Enter any number: ");
        basenumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter any number: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        power = 1;
        i = 1;
        //caculatinh power of given number
        while (i <= exponent)
        {
            power = power * basenumber;
            i++;
        }
        Console.Write("Power : " + power);

        Console.ReadLine();
    }
}
Calculating power of a number using for loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class csharpExercise
{
    static void Main(string[] args)
    {
        int basenumber, exponent, i, power;

        // Reading number
        Console.Write("Enter any number: ");
        basenumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter any number: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        power = 1;
        //caculatinh power of given number
        for (i = 1; i <= exponent; i++)
            power = power * basenumber;


        Console.Write("Power : " + power);

        Console.ReadLine();
    }
}*/
//14-Write C# program to find factorial of any number
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, i;
        long fact = 1;

        // Reading number
        Console.Write("Enter any number to calculate factorial:  ");
        num = Convert.ToInt32(Console.ReadLine());
        fact = 1;
        i = 1;

        //Run loop from 1 to number entered by user
        while (i <= num)
        {
            fact = fact * i;
            i++;
        }

        Console.Write("Factorial of : " + num + " is " + fact);

        Console.ReadLine();
    }
}*/
/*15-Write C# program to check whether a number is Armstrong number or not
public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, sum = 0, i, r;

        // Reading number
        Console.Write("Please enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Finding armstrong number or not
        for (i = num; i > 0; i = i / 10)
        {
            r = i % 10;
            sum = sum + r * r * r;
        }

        if (num == sum)
        {
            Console.WriteLine(num + " is an armstrong number.");
        }
        else
        {
            Console.WriteLine(num + " is not an armstrong number.");
        }

        Console.ReadLine();
    }
}*/
/*16-Write C# program to find Armstrong numbers between 1 to n
public class csharpExercise
{
    static void Main(string[] args)
    {
        int lower, higher, i, temp1, temp2, remainder, n = 0;
        double result = 0;

        // Reading number
        Console.Write("Please Enter two numbers: ");
        lower = Convert.ToInt32(Console.ReadLine());
        higher = Convert.ToInt32(Console.ReadLine());

        Console.Write("Armstrong numbers between " + lower + " and " + higher + " are: ");

        for (i = lower + 1; i < higher; ++i)
        {
            temp2 = i;
            temp1 = i;

            // number of digits calculation
            while (temp1 != 0)
            {
                temp1 /= 10;
                ++n;
            }

            // result contains sum of nth power of its digits
            while (temp2 != 0)
            {
                remainder = temp2 % 10;
                result += Math.Pow(remainder, n);
                temp2 /= 10;
            }

            // checking if number i is equal to the sum of nth power of its digits
            if (result == i)
            {
                Console.WriteLine(i);
            }

            // resetting the values to check Armstrong number for next iteration
            n = 0;
            result = 0;

        }

        Console.ReadLine();
    }
}*/
//17-Write C# program to calculate compound Interest
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        float amount, rate, intrest, time, ci, a;

        //Reading amount, rate of intrest
        //and period in years from user
        

        Console.Write("Type the amount : ");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the interest rate : ");
        rate = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the period in years: ");
        time = Convert.ToInt32(Console.ReadLine());

        intrest = 1 + (rate / 100);

        // ci=pow(intrest,time);
        ci = 1;
        for (a = 1; a <= time; a++)
            ci = ci * intrest;

        ci = amount * ci - amount;

        Console.WriteLine("Your compound interest is : " + ci);



        Console.ReadLine();
    }
}*/
//18-Write C# program to check a enter number is Prime number or not using while & for loop
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, i, f;

        //Reading number      
         //

        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        f = 0;
        i = 2;
        while (i <= num / 2)
        {
            if (num % i == 0)
            {
                f = 1;
                break;
            }
            i++;
        }
        if (f == 0)
            Console.WriteLine(num + " is a Prime Number");
        else
            Console.WriteLine(num + " is not a Prime Number");


        Console.ReadLine();
    }
}*/
//19-Write C# program to check whether a number is palindrome or not
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, i, rev;

        // Reading a number from user
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        rev = num;
        for (i = 0; num > 0; num = num / 10)
        {
            i = i * 10;
            i = i + (num % 10);
        }

        //Checking if reverse number is equal to original num or not.
        if (rev == i)
            Console.WriteLine(rev + " is a Palindrome Number.");
        else
            Console.WriteLine(rev + " is not a Palindrome Number.");


        Console.ReadLine();
    }
}*/
//20-Write C# program to print number in words
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int n, num = 0;

        // Reading a number from user
        Console.WriteLine("Enter any number to print in words: ");
        n = Convert.ToInt32(Console.ReadLine());

        while (n != 0)
        {
            num = (num * 10) + (n % 10);
            n /= 10;
        }

        //print corresponding digit in words till num becomes 0
        while (num != 0)
        {
            switch (num % 10)
            {
                case 0:
                    Console.Write("zero ");
                    break;
                case 1:
                    Console.Write("one ");
                    break;
                case 2:
                    Console.Write("two ");
                    break;
                case 3:
                    Console.Write("three ");
                    break;
                case 4:
                    Console.Write("four ");
                    break;
                case 5:
                    Console.Write("five ");
                    break;
                case 6:
                    Console.Write("six ");
                    break;
                case 7:
                    Console.Write("seven ");
                    break;
                case 8:
                    Console.Write("eight ");
                    break;
                case 9:
                    Console.Write("nine ");
                    break;
            }
            num = num / 10;



        }
        Console.ReadLine();
    }
}*/
//21-Write C# program to find HCF of two numbers
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int i, num1, num2, min, HCF = 1;

        // Reading 2 numbers from user
        Console.WriteLine("Enter any number to print in words: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());


        // Find min number between two numbers
        min = (num1 < num2) ? num1 : num2;

        for (i = 1; i <= min; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                HCF = i;
            }
        }

        Console.WriteLine("HCF of " + num1 + " and " + num2 + " is: " + HCF);

        Console.ReadLine();
    }
}*/
//22-Write C# program to find LCM of two numbers
/*public class csharpExercise
{
    static void Main(string[] args)
    {
        int num1, num2, x, y, lcm = 0;
        Console.Write("Enter the First Number : ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        num2 = int.Parse(Console.ReadLine());
        x = num1;
        y = num2;
        while (num1 != num2)
        {
            if (num1 > num2)
            {
                num1 = num1 - num2;
            }
            else
            {
                num2 = num2 - num1;
            }
        }
        lcm = (x * y) / num1;
        Console.Write("Least Common Multiple is : " + lcm);

        Console.ReadLine();
    }
}*/

