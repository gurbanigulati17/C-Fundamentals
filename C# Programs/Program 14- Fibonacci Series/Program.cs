using System;
using System.Collections.Generic;

    class Program
    {
 

  
           static void Main(string[] args)
        {  
         
             //Write a program for printing fibonacci series..................

 
             var fibonacciSeries= new List<int>{1,1};
                  
             while(fibonacciSeries.Count < 20){
                           var previous=fibonacciSeries[fibonacciSeries.Count-1];
                           var previous2= fibonacciSeries[fibonacciSeries.Count-2];
                           fibonacciSeries.Add(previous+previous2);

             }
             Console.WriteLine("0");
             foreach(var number in fibonacciSeries){
               Console.WriteLine(number);
             }


        }
    }

