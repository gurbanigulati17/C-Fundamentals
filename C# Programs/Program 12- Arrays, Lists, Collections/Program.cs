using System;
using System.Collections.Generic;

    class Program
    {
 

  
           static void Main(string[] args)
        {  
         

        //Program for Collections and Generics.....
        //For using collections one need to us using Systems.Collections.Generics


       
       var names= new List<string>{"Guru", "Bani","Gauhar","David"};
       foreach (var name in names){
         Console.WriteLine($"The following enterd names are {name}");
       }

       
       //Adding names into the given list use add function.....

       names.Add("Scott");
       names.Add("Peter");
       names.Add("Sela");
       Console.WriteLine(names.Count);


       //In collections we can use count to get thelength of the list.

        }
    }

