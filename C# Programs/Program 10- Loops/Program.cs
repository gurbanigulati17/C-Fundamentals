using System;


    class Program
    {
 

  
           static void Main(string[] args)
        {  
         

         //Programs For Loops

         //1. For Loop: 
         Console.WriteLine("For Loop");
         for(int i=0; i<10; i++){
            Console.WriteLine($" This is integer {i}");
         } 


         //2. While Loop:
         Console.WriteLine("While Loop");
         int c=1;
         while(c<10){
               Console.WriteLine($" This is integer {c}");
               c++;
         }


         //3. Do-While Loop
         Console.WriteLine("Do- while Loop");
         do{
               Console.WriteLine($" This is integer {c}");
               c++;
         }while(c<3);
        }
    }

