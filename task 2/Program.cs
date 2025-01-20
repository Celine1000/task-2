// See https://aka.ms/new-console-template for more information
using System.Security.Principal;
using System;
using System.ComponentModel;

int x = 10; //declare variable with type integer named x  with  value 10
int y = 20;//declare variable with type integer named y with  value 20
int sum = x + y;/* declare variable called sum with integer type to store
                 the product from the summation between x and y*/
Console.WriteLine(sum);//print out sum which will view 30

//Problem: Identify and fix the errors in this code snippet: 
int x = 10;
int y = 5;
Console.WriteLine(x + y);
// x is declared as integer but the assigment value with sting type FIX: remove ""
// the c in console was not capital
// y was not declares or have an assigning value
// Declare variables using proper naming conventions to store: 
/*your full name. */
String fullName="Celine ayman kamil";
 /*Your age.*/ int age=20;
 /*Your monthly salary.*/ double salary= 5000.50;
 /*Whether you are a student.*/ Boolean student=true;
Console.WriteLine(age +" "+ salary+" "+ fullName+" "+ student);
/*Write a program to demonstrate that changing the value of a reference type affects all 
references pointing to that object.*/
int z=10;
int c=20;
z = c;
Console.WriteLine(z+c);
//Create a program that calculates the following using variables x = 15 and y = 4: 
// Sum 
// Difference 
// Product 
// Division result 
// Remainder 
int x = 15;
int y = 4;
int sum = x + y;
int diff = x - y;
int product = x * y;
int division = x / y;
int reminder = x % y;
//Problem: Write a program that checks if a given number is both: 
// Greater than 10. 
//Even.
if (x>10 && x%2)
{ Console.WriteLine(x); }
/*Implement a program that takes a double input from the user and casts it to an int. 
Use both implicit and explicit casting, then print the results.*/ 
Console.Write("Enter a double value: ");
double inputValue = Convert.ToDouble(Console.ReadLine());
int explicitCast = (int)inputValue;
Console.WriteLine($"Explicit cast: {explicitCast}");

//Problem: Write a program that: (G01 Bonus, G02 mandatory)
// Prompts the user for their age as a string. 
// Converts the string to an integer using Parse
//Checks if the age is valid (e.g., greater than 0). 
Console.Write("Enter your age: ");
string ageStr = Console.ReadLine();
int Age = int.Parse(ageStr);

if (Age > 0)
{
    Console.WriteLine($"Your age is: {Age}");
}
else
{
    Console.WriteLine("Invalid age. Age must be greater than 0.");
}
/* Write a program that demonstrates the difference between prefix and postfix 
increment operators using a variable x.*/
int d = 6;
Console.WriteLine(++d);//prefix 
Console.WriteLine(d++);//postfix
