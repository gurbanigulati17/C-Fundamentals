using System;


    class Program
    {
 

  
           static void Main(string[] args)
        {  
         

         //Programs For Branches and Loop.
        // Write a program to sum the number from 1 to 20 those are divisible by 3.
         
        int sum=0;
        for(int i=1; i<=20; i++){
              if(i % 3 == 0){
                    sum += i;
              }
        }
         Console.WriteLine($"Sum of no is {sum}");
        }
    }

