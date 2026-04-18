using System;

namespace BasicCSharp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //1.cube

            //   int a = 7;
            //   double cube = a * a * a;
            //concatnation 
            //   Console.WriteLine("cube number is:+a+" +cube);
            //interpolation
            //  Console.WriteLine($"cube number is{a}=={cube}");

            // 2.factorial number

            //    int num = 4;
            //    int fact = 1;
            //    for (int i = 1; i <= num; i++) 
            //   {
            //        fact = fact * i;        
            //   }
            //   Console.WriteLine(fact);

            //3.square

            //    int a = 8;
            //   int square = a * a;

            //   Console.WriteLine($"square number is {a}={square}");

            //4.peimeter

            //   int side = 7;
            //   int perimeter = 4 * side;

            //    Console.WriteLine($"perimeter of {side}={perimeter}");

            //5.area

            //    int a = 7;
            //   int area = a * a;

            //   Console.WriteLine($"area of {a}={ area}");



            //-------------------------------------------------------------------------------------------------------------------------------


            //1.positive negative

            //int numb;
            //Console.WriteLine("\n enter any number check positive and negative");
            //numb = int.Parse(Console.ReadLine());

            //if(numb>2)
            //{
            //    Console.WriteLine("it positive number");

            //}
            //else 
            //{
            //    Console.WriteLine("it negative number");
            //}


            //2.even odd

            //int num;
            //Console.WriteLine("\n check even and odd");
            //num = int.Parse(Console.ReadLine());

            //if(num % 2 ==0)
            //    {
            //    Console.WriteLine($" {num} even number");
            //    }
            //   else
            //   {
            //     Console.WriteLine($"{num} odd number");
            //   }

            //3.leap or not

            //int year;
            //Console.WriteLine("\n enter the year");
            //year=int.Parse(Console.ReadLine());
            //if ((year % 4==0 && year %100 !=0)|| year%400==0 )
            //{
            //    Console.WriteLine($"{year} Leap year");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} not Leap year");
            //}

            //4.voting

            //int age;
            //Console.WriteLine("\n enter the age");
            //age =int.Parse(Console.ReadLine());

            //if (age > 18)
            //{
            //    Console.WriteLine($"{age} eligibla to vote");
            //}
            //else
            //{
            //    Console.WriteLine($"{age} not eligibla to vote");
            //}


            //5.divisible by 5 and 11

            //int num;
            //Console.WriteLine("\n  enter the number");
            //num=int.Parse(Console.ReadLine());
            //num=Convert.ToInt32(Console.ReadLine());

            //if(num % 5==0 && num % 11==0)
            //{
            //    Console.WriteLine($"{num} divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} not divisible by 5 and 11");
            //}


            //6.three digit number

            //int num;
            //Console.WriteLine("\n enter the number");
            //num = Convert.ToInt32(Console.ReadLine());

            //if(num>=100 && num<=999)
            //{
            //    Console.WriteLine($"{num} Three digit number ");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} Not Three digit number ");
            //}


            //7.Senior Citizen

            //int age;
            //Console.WriteLine("\n enter the age");
            //age =int.Parse(Console.ReadLine());

            //if(age>=60)
            //{
            //    Console.WriteLine($"{age} Senior citizen");
            //}
            //else
            //{
            //    Console.WriteLine($"{age} Not Senior citizen");
            //}

            //8.uppercase and lowercase

            //char ch;
            //Console.WriteLine("\n enter the character");
            //ch=Convert.ToChar(Console.ReadLine());

            //if(char.IsUpper(ch))
            //{
            //    Console.WriteLine($"{ch} it is uppercase");
            //}
            //else
            //{
            //    Console.WriteLine($"{ch} it is Lowercase");
            //}


            //9.Alphabet or not

            //char ch;
            //Console.WriteLine("\n enter the character");
            //ch=char.Parse(Console.ReadLine());

            //if(char.IsLetter(ch) )
            //{
            //    Console.WriteLine($"{ch} is Alphabet");
            //}
            //else
            //{
            //    Console.WriteLine($"{ch} is not Alphabet");
            //}

            //10.Positive negative or zero

            //int num;
            //Console.WriteLine("\n enter the number");
            //num=Convert.ToInt32(Console.ReadLine());

            //if(num > 0)
            //{
            //    Console.WriteLine($"{num} positive number");
            //}
            //else if(num < 0)
            //{
            //    Console.WriteLine($"{num} negative number");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} Zero");
            //}


            //even odd using ternary operator

            //int num;
            //Console.WriteLine("\n enter the number");
            //num=int.Parse(Console.ReadLine());

            //Console.WriteLine(num % 2 == 0 ? "Even":"Odd");


            //maximum two number
            //int a, b;
            //Console.WriteLine("enter two number");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine($"maximum {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"maximum {b}");
            //}



            //maximum three number
            //int a, b, c;
            //Console.WriteLine("enter any three number");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());

            //if(a > b && b > c)
            //{
            //    Console.WriteLine($"maximum {a}");
            //}
            //else if(b>c)
            //{
            //    Console.WriteLine($"maximum {b}");
            //}
            //else
            //{
            //    Console.WriteLine($"maximum {c}");
            //}



            //positive,negative,zero

            //int num;
            //Console.WriteLine("enter any number");
            //num=int.Parse(Console.ReadLine());

            //if(num > 0)
            //{
            //    Console.WriteLine($"positive number {num}");
            //}
            //else if(num<0)
            //{
            //    Console.WriteLine($"Negative number {num}");
            //}
            //else
            //{
            //    Console.WriteLine($"zero");
            //}



            //divisible 5 and 11 or not

            //int num;
            //Console.WriteLine("enter any number");
            //num=int.Parse(Console.ReadLine());

            //if(num % 5 ==0 && num % 11==0)
            //{
            //    Console.WriteLine($"divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine($" Not divisible 5 and 11");
            //}



            //odd even 
            //int num;
            //Console.WriteLine("enter any number");
            //num=int.Parse(Console.ReadLine());

            //if(num % 2==0 )
            //{
            //    Console.WriteLine($"odd number");
            //}
            //else
            //{
            //    Console.WriteLine($"even number");
            //}


            //leap year or not
            //int year;
            //Console.WriteLine("enter any year");
            //year = int.Parse(Console.ReadLine());

            //if(year%400==0||(year % 4==0 && year%100!=0))
            //{
            //    Console.WriteLine($"leap year");
            //}
            //else
            //{
            //    Console.WriteLine($"Not leap year");
            //}


            //alphabet or not 

            //char ch;
            //Console.WriteLine("enter any character");
            //ch=Convert.ToChar(Console.ReadLine());

            //if((ch<='A' && ch<='B')||(ch<='a' && ch<='z'))
            //{
            //    Console.WriteLine($"Alphabet");
            //}
            //else
            //{
            //    Console.WriteLine($"Not an Alphabet");
            //}


            //alphabet check vowel and consonent

            //char ch;
            //Console.WriteLine("enter any alphabet");
            //ch = Convert.ToChar(Console.ReadLine());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine($"Vowel");
            //}
            //else
            //{
            //    Console.WriteLine($"Consonant");
            //}


            //alphabet digit or special character

            //char ch;
            //Console.WriteLine("enter any digit");
            //ch=Convert.ToChar(Console.ReadLine());

            //if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            //{
            //    Console.WriteLine($"alphabet");
            //}
            //else if (ch >='0' &&  ch <='9')
            //{
            //    Console.WriteLine($" digit");
            //}
            //else
            //{
            //    Console.WriteLine($"special charcter");
            //}


            //uppercase or lowercase
            //char ch;
            //Console.WriteLine("enter any character");
            //ch = Convert.ToChar(Console.ReadLine());

            //if(ch>='A' && ch<='Z')
            //{
            //    Console.WriteLine($"uppercase Alphabet");
            //}
            //else if (ch>='a' && ch<='z')
            //{
            //    Console.WriteLine($"Lowercase alphabet");
            //}
            //else
            //{
            //    Console.WriteLine($"not an alphabet");
            //}



            //input week number and print week day

            //int week;
            //Console.WriteLine("enter any week number");
            //week=int.Parse(Console.ReadLine());

            //switch(week) 
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("invalid week number");
            //        break;
            //}


            //input month number and print number of days in that month
            //int month;
            //Console.WriteLine("enter month number");
            //month=int.Parse(Console.ReadLine());
            //switch(month)
            //{
            //    case 1: case 3: case 5: case 7: case 8:case 10:case 12:
            //        Console.WriteLine("31 days");
            //        break;

            //    case 4: case 6: case 9: case 11:
            //        Console.WriteLine("30 days");
            //        break;

            //    case 2:
            //        Console.WriteLine("28 & 29 days");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month");
            //        break;
            //}


            //count total number of notes in given amount.
            //int amount;
            //Console.WriteLine("enter the amount");
            //amount = int.Parse(Console.ReadLine());
            //int notes;
            //if (amount >= 2000)
            //{
            //    notes = amount / 2000;
            //    amount = amount % 2000;
            //    Console.WriteLine($"2000:{notes}notes");
            //}
            //if (amount >= 500)
            //{
            //    notes = amount / 500;
            //    amount = amount % 500;
            //    Console.WriteLine($"500:{notes}notes");
            //}

            //if (amount >= 200)

            //{
            //    notes = amount / 200;
            //    amount = amount % 200;
            //    Console.WriteLine($"200:{notes}notes");
            //}
            //if (amount >= 100)

            //{
            //    notes = amount / 100;
            //    amount = amount % 100;
            //    Console.WriteLine($"100:{notes}notes");
            //}

            //if (amount >= 50)

            //{
            //    notes = amount / 50;
            //    amount = amount % 50;
            //    Console.WriteLine($"50:{notes}notes");
            //}
            //if (amount >= 20)

            //{
            //    notes = amount / 20;
            //    amount = amount % 20;
            //    Console.WriteLine($"20:{notes}notes");
            //}
            //if (amount >= 10)

            //{
            //    notes = amount / 10;
            //    amount = amount % 10;
            //    Console.WriteLine($"10:{notes}notes");
            //}


            // input angles of a triangle and check whether triangle is valid or not

            //int a, b, c;
            //Console.WriteLine("enter angle of triangle");
            //a=int.Parse(Console.ReadLine());
            //b=int.Parse(Console.ReadLine());
            //c=int.Parse(Console.ReadLine());

            //if (a > 0 && b > 0 && c > 0 && (a + b + c == 180))
            //{
            //    Console.WriteLine($"triangle is valid");
            //}   
            //else 
            //{
            //  Console.WriteLine($"triangle is not valid");
            //}


            // input all sides of a triangle and check whether triangle is valid or not

            //int a,b,c;
            //Console.WriteLine("enter side of triangle");
            //a=int.Parse(Console.ReadLine());
            //b=int.Parse(Console.ReadLine());
            //c=int.Parse(Console.ReadLine());

            //if ((a + b > c) && (b + c > a) && (c + a > b))
            //    Console.WriteLine($"Traingle is valid");
            //else
            //    Console.WriteLine($"Triangle is not valid");


            //triangle is Equilateral, Isosceles or Scalene

            //int a, b, c;
            //Console.WriteLine("enter number of triangle");
            //a=int.Parse(Console.ReadLine());
            //b=int.Parse(Console.ReadLine());
            //c=int.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //    Console.WriteLine($"Equilateral traingle");
            //else if (a == b || b == c || a == c)
            //    Console.WriteLine($"Isosceles triangle");
            //else
            //    Console.WriteLine($"Scalene Triangle");


            //input marks of five subjects, calculate percentage and grade

            //float phy, chem, bio, math, comp;
            //float total, percentage;
            //Console.WriteLine("Enter mark of physics");
            //phy=float.Parse(Console.ReadLine());

            //Console.WriteLine("enter mark of chemistry");
            //chem=float.Parse(Console.ReadLine());

            //Console.WriteLine("enter mark of biology");
            //bio=float.Parse(Console.ReadLine());

            //Console.WriteLine("enter mark of mathematices");
            //math=float.Parse(Console.ReadLine());

            //Console.WriteLine("enter mark od computer");
            //comp=float.Parse(Console.ReadLine());

            //total = phy + chem + bio + math + comp;
            //percentage = (total / 500) * 100;

            //Console.WriteLine("percentage=" + percentage);

            //if (percentage >= 90)
            //    Console.WriteLine("Grade A");
            //else if (percentage >= 80)
            //    Console.WriteLine("Grade B");
            //else if (percentage >= 70)
            //    Console.WriteLine("Grade C");
            //else if (percentage >= 60)
            //    Console.WriteLine("Grade D");
            //else if (percentage >= 40)
            //    Console.WriteLine("Grade E");
            //else
            //    Console.WriteLine("Grade F (fail)");

            //---------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------Switch case-------------------------------------------------------------------------------

            // print day of week name using switch case.

            //Console.WriteLine("enter days number");
            //int day = Convert.ToInt32(Console.ReadLine());

            //String result = day switch
            //{
            //    1 => "Monday",
            //    2 => "Tuesday",
            //    3 => "Wednesday",
            //    4 => "Thursday",
            //    5 => "Friday",
            //    6 => "saturday",
            //    7 => "Sunday",
            //    _=>"Invalid day"
            //};
            //Console.WriteLine(result);


            //print total number of days in a month

            //Console.WriteLine("Enter month number (1-12):");
            //int month = Convert.ToInt32(Console.ReadLine());

            //int days = month switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            //    4 or 6 or 9 or 11 => 30,
            //    2 => 28,
            //    _ => 0
            //};

            //Console.WriteLine(days == 0 ? "Invalid month" : "Days = " + days);


            //alphabet is vowel or consonant 

            //Console.WriteLine("Enter an alphabet:");
            //char ch = Convert.ToChar(Console.ReadLine().ToLower());

            //string result = ch switch
            //{
            //    'a' or 'e' or 'i' or 'o' or 'u' => "Vowel",
            //    _ => "Consonant"
            //};

            //Console.WriteLine(result);


            //maximum between two numbers 

            //Console.WriteLine("Enter two numbers:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int max = a > b ? a : b;

            //Console.WriteLine("Maximum = " + max);



            //even or odd 

            //Console.WriteLine("Enter a number:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //string result = n % 2 == 0 ? "Even" : "Odd";

            //Console.WriteLine(result);

            //==========================================================================================================
            // ------------------------Simple Calculator-----------------------------------------------------



            //1. A user enters age.  Display "Child", "Adult", or "Senior Citizen".
            //int age;
            //Console.WriteLine("enter age");
            //age=int.Parse(Console.ReadLine());

            //if (age < 18)
            //    Console.WriteLine($"Child");
            //else if (age < 60)
            //    Console.WriteLine($"Adult");
            //else
            //    Console.WriteLine($"Senior Citizen");


            //2. A student enters marks.  Display Pass or Fail.
            //int marks;
            //Console.WriteLine("enter marks");
            //marks=int.Parse(Console.ReadLine());

            //if (marks >= 40)
            //    Console.WriteLine($"Pass");
            //else
            //    Console.WriteLine($"Fail");


            //3. A customer enters purchase amount.  If amount is more than 5000, apply discount.
            //double amount;
            //Console.WriteLine("enter purchase amount");
            //amount=double.Parse(Console.ReadLine());

            //if(amount>5000)
            //{
            //    double discount = amount * 0.20;
            //    Console.WriteLine("Discount applied:" + discount);
            //    Console.WriteLine("Final amount:" + (amount - discount));
            //}
            //else
            //{
            //    Console.WriteLine("No discount applied");
            //    Console.WriteLine("Final amount:"+amount);
            //}


            //4. A user enters temperature.   Display Cold, Normal, or Hot.

            //int temp;
            //Console.WriteLine("enter temperature");
            //temp=int.Parse(Console.ReadLine());

            //if(temp < 20)
            //{
            //    Console.WriteLine($"cold");
            //}
            //else if(temp <= 30) 
            //{
            //    Console.WriteLine($"Normal");
            //}
            //else
            //{
            //    Console.WriteLine($"Hot");
            //}


            //5. A user enters login status (true/false).   Display Login Successful or Login Failed.
            //bool status;
            //Console.WriteLine("enter login status(true/false)");
            //status=bool.Parse(Console.ReadLine());

            //if (status)
            //{
            //    Console.WriteLine($"Login successful");
            //}
            //else 
            //{
            //    Console.WriteLine($"Login failed");
            //}


            //-----even number
            //int n = 100;
            //int sum = 0;
            //for (int i = 1; i <= n; i++)

            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }   
            //}
            //Console.WriteLine(sum);





            //print fibonacci series 

            //int n1 = 0;
            //int n2 = 1;
            //int n3 = 20;
            //Console.WriteLine($"{n1},{n2}");
            //for (int i = 3; i < n3; i++)
            //{
            //    n3 = n1 + n2;
            //    Console.WriteLine($", {n3}");
            //    n1 = n2;
            //    n2 = n3;
            //}

            //alphabet A to Z

            // for (char i='A'; i<='Z';i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Ascii value

            //for (int i = 65; i <= 90; i++)
            //{
            //    Console.WriteLine((char)i);
            //}

            //----------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------- While loop--------------------------------------------------------------------

            //1.Print numbers from 1 to 10 using WHILE loop

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //2. Print numbers from 10 to 1 using WHILE loop.

            //int i=10;
            //while(i>=1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}


            //3. Print even numbers between 1 and 20 using WHILE.

            //int i = 2;
            //while(i<=20)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            //4. Print odd numbers between 1 and 20 using WHILE

            //int i = 1;
            //while (i <= 20) 
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}


            //5. Calculate sum of numbers from 1 to 10 using WHILE loop.

            //int i = 1;
            //int  sum = 0;
            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("sum ="+ sum);

            //6. Calculate factorial of a number using WHILE loop.

            //int n = 5;
            //int fact = 1;
            //while(n>0)
            //{
            //    fact = fact * n;
            //    n--;
            //}
            //Console.WriteLine(fact);

            //7. Count total digits in a number using WHILE loop.

            //int num=12345;
            //int count = 0;
            //while(num!=0)
            //{
            //    num=num / 10;
            //    count++;
            //}
            //Console.WriteLine("Total digit="+count);


            //8. Reverse a number using WHILE loop.

            //int num = 12345;
            //int rev = 0;
            //while (num != 0)
            //{
            //    int digit = num % 10;
            //    rev = rev * 10 + digit;
            //    num = num / 10;
            //}
            //Console.WriteLine("Reversed Number = " + rev);


            //9. Check whether a number is palindrome using WHILE loop.

            //int num = 121;
            //int temp = num;
            //int rev = 0;
            //while (num != 0)
            //{
            //    int digit = num % 10;
            //    rev = rev * 10 + digit;
            //    num = num / 10;
            //}
            //if (temp == rev)
            //    Console.WriteLine("palindrome number");
            //else
            //    Console.WriteLine("not palindrome number");


            //10. Print multiplication table of a number using WHILE loop.

            //11. Find sum of even digits of a number using WHILE loop.

            //int num;
            //int sum = 0;
            //Console.WriteLine("enter a number");
            //num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    int digit = num % 10;

            //    if (digit % 2 == 0)
            //    {
            //        sum = sum + digit;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("sum of even digit=" + sum);


            //12. Find sum of odd digits of a number using WHILE loop.

            //int num;
            //int sum = 0;
            //Console.WriteLine("enter a number");
            //num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    int digit = num % 10;

            //    if (digit % 2! == 0)
            //    {
            //        sum = sum + digit;
            //    }
            //    num = num / 10;
            //}
            //Console.WriteLine("sum of odd digit=" + sum);


            //13. Count even numbers between 1 and 50 using WHILE loop.

            //int i = 1;
            //int count = 0;
            //while (i <= 50)
            //{
            //    if (i % 2 == 0)
            //    count++;
            //    i++;
            //}
            //Console.WriteLine("Even count = " + count);


            //14. Find power of a number (a^b) using WHILE loop




            //15. Print first 10 natural numbers using WHILE loop. c sharp explain program with output

            //int i = 1;
            //while (i <= 10) ;
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //-----------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------FOR LOOP----------------------------------------------------------------------------

            //1. Print numbers from 1 to 10 using FOR loop.

            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine(i);
            //}


            //2. Print numbers from 10 to 1 using FOR loop.

            //for(int i=10;i>=1;i--)
            //{
            //    Console.WriteLine(i); 
            //}


            //3. Print even numbers between 1 and 20 using FOR.

            //for (int i = 2; i <= 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //4. Print odd numbers between 1 and 20 using FOR.

            //for (int i = 1; i <= 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            //5. Calculate sum of numbers from 1 to 10 using FOR loop.

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //6. Calculate factorial of a number using FOR loop.

            //int n = 5;
            //int fact = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    fact *= i;
            //}

            //Console.WriteLine("Factorial = " + fact);


            //7. Count total digits in a number using FOR loop.

            //int num = 12345;
            //int count = 0;

            //for (; num != 0; num /= 10)
            //{
            //    count++;
            //}

            //Console.WriteLine("Total digits = " + count);



            //8. Reverse a number using FOR loop.

            //int num = 12345;
            //int rev = 0;
            //for (; num != 0;num/=10)
            //{
            //    int digit = num % 10;
            //    rev = rev * 10 + digit;

            //}
            //Console.WriteLine("Reverse = " + rev);


            //9. Check whether a number is palindrome using FOR loop.

            //int num, temp, reverse = 0;

            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //temp = num;

            //for (; temp != 0; temp = temp / 10)
            //{
            //    int digit = temp % 10;
            //    reverse = reverse * 10 + digit;
            //}

            //if (num == reverse)
            //    Console.WriteLine("Number is Palindrome");
            //else
            //    Console.WriteLine("Number is Not Palindrome");


            //10. Print multiplication table of a number using FOR loop.




            //-----------------------=------------- Pattern printing-------------------------------------------------------------------------
             //---------------------------------------------------------------------------------------------------------------------------------

            //for (int i = 1; i <= 5; i++) 
            //{
            //    for(int j=5; j >= i; j--) 
            //    {
            //        Console.Write("-");
            //    }
            //    for (int k = 1; k <= i * 2 - 1; k++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //2.pattern
            //for (int i = 1; i <= 5; i++) 
            //{
            //    for (int j = 1; j <= 5; j++) 
            //    {
            //        if (i % 2 == 1)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}


            //3.pattern

            //for(int i=1;i<=5;i++)
            //{
            //    for (int j=1;j<=5;j++)
            //    {
            //        Console.Write(j%2);
            //    }
            //    Console.WriteLine();
            //}

            //4.pattern

            //for(int i=1;i<=5;i++)
            //{
            //    for (int j=1;j<=5;j++)
            //    {
            //        if (i == 1 || i == 5 || j == 1 || j == 5)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            //5.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (i == 3 && j==3)
            //            Console.Write("0");
            //        else
            //            Console.Write("1");
            //    }
            //    Console.WriteLine();
            //}


            //6.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            //7.pattern
            //for(int i=1;i<=5;i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (i == 3||j==3)
            //            Console.Write("0");
            //        else
            //            Console.Write("1");
            //    }
            //    Console.WriteLine();
            //}

            //8.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (i==j||i+j==5+1)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            //9.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (i == 1 || i == 5)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            //10.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //       Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //11.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //12.pattern

            //for (int i = 0; i <= 4;i=i+1)
            //{
            //    for (int j = 1; j <= 5; j=j+1)
            //    {
            //        Console.Write(i+j);
            //    }
            //    Console.WriteLine();
            //}

            //13.pattern
            //int num = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(num);
            //        num++;
            //    }
            //    Console.WriteLine();
            //}



            //14.pattern
            //for (int i = 1; i<=5; i++)
            //{
            //    int n = i;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(n);
            //        n--;
            //    }
            //    int m = 2;
            //    for (int k = 5; k > i; k--)
            //    {
            //        Console.Write(m);
            //        m++;
            //    }
            //    Console.WriteLine();
            //}

            //15.pattern
            //for(int i=5;i>=1;i--)
            //{

            //    for (int j=5;j>=i;j--)
            //    {
            //        Console.Write(j);

            //    }

            //    for(int k=i-1;k>=1;k--)
            //    {
            //        Console.Write(i);

            //    }
            //    Console.WriteLine();
            //}

            //16.pattern
            //for (int i = 1;i<=5;i++)
            //{
            //    int n = i;
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(n);
            //        n++;
            //    }
            //   for(int k=2;k<=i;k++)
            //    {
            //        Console.Write(5); 
            //    }
            //    Console.WriteLine();
            //}


            //17.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    int n = i;
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(n);
            //        n++;
            //    }

            //    for (int k =i-1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}


            //18.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}


            //19.pattern
            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //20.pattern

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //21.pattern
            //for(int i = 5; i >=1 ; i--)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //22.pattern
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(6-i);
            //    }
            //    Console.WriteLine();
            // }


            //23.pattern
            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=5;j>=i;j--)
            //    {
            //        Console.Write( i);
            //    }
            //    Console.WriteLine();
            //}





            //--------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------Pattern function---------------------------------------------------------------
            

            Pattern p = new Pattern();
            //p.NoPattern1();

            //p.NoPattern2(); 

            //p.NoPattern3();

            //p.NoPattern4();

            //p.NoPattern5();

            //p.NoPattern6();

            //p.NoPattern7();

            //p.NoPattern8();

            //p.NoPattern9();

            //p.NoPattern10();

            //p.NoPattern11();

            //p.NoPattern12();

            //p.NoPattern13();

            //p.NoPattern14();

            //p.NoPattern15();


            //p.NoPattern16();

            //p.NoPattern19();

            //p.NoPattern20();

            //p.NoPattern22();

            //p.NoPattern23();

            //p.NoPattern24();



        }


    
    }
}