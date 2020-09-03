using System;
using System.Collections.Generic;

    class Program
    {
 

  
           static void Main(string[] args)
        {  
         

        //Program for Collections and Generics with additional methods.....
        //1. For using collections one need to us using Systems.Collections.Generics


       
       var names= new List<string>{"Guru", "Bani","Gauhar","David"};
       foreach (var name in names){
         Console.WriteLine($"The following enterd names are {name}");
       }

       
       //2. Adding names into the given list use add function.....Add()

       names.Add("Scott");
       names.Add("Peter");
       names.Add("Sela");

       //3. Removing names into the given list..........Remove()
       names.Remove("Sela");
       Console.WriteLine(names.Count);


       //In collections we can use count to get thelength of the list.

       //4. Accesing with index
       Console.WriteLine(names[3]);


       //5. IndexOf: Method uses to find the search of index and return the index of the item.
       var index= names.IndexOf("Bani");
       if(index == -1){
           Console.WriteLine("Elementnot found");
       }
       else{

      
       Console.WriteLine($"The index of {names[index]}is {index}");
       }

        

        //6. Sorting the list use Sort Functions Sort()
        Console.WriteLine("The original Lists is");
        foreach(var name in names){
          Console.WriteLine($"The list has name {name}");

        }
        names.Sort();
        Console.WriteLine("The sorted list is");
        foreach(var name in names){
          Console.WriteLine($"The list has name {name}");
        }



        }
    }

