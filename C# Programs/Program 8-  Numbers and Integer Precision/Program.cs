using System;


    class Program
    {
 

  
           static void Main(string[] args)
        {  
           //Getting Quotient
           int a=7;
           int b=4;
           int c=3;

           int d=(a+b)/c;
           Console.WriteLine(d);

           //Getting Remainder
           int r=(a+b)%c;
           Console.WriteLine(r);


           //int MinValue Function and the MaxValue Function
           //MinValue function gives the minimum
           //MaxValue Function gives the maximum

           int max=int.MaxValue;
           int min=int.MinValue;
           Console.WriteLine($"Min and max Values are {min} and {max}");
           
           int  what=min+3;
           Console.WriteLine("Overflow values "+ what);



           //double data type
           double v=1.0/3.0;
           Console.WriteLine("Value is "+v);
           
           
        }
    }

