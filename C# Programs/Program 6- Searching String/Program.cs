using System;


    class Program
    {
 

  
           static void Main(string[] args)
        { 

          //Program for Searching Strings........................
          //1. Contains
          //Contains Function will return value in boolean means either true or false.


          string sentence="I love India and I am the citizen of India";
          Console.WriteLine(sentence.Contains("India"));
          Console.WriteLine(sentence.Contains("citizen"));
          Console.WriteLine(sentence.Contains("Greetings"));
          Console.WriteLine(sentence.Contains("INDIA"));



        //..........................................
        Console.WriteLine("StartsWith and EndsWith Output");

         //2. StartsWith
         // StartsWith function determines whether the given string started with the entered letter 
         // Return Boolean type.

          Console.WriteLine(sentence.StartsWith("I"));
          Console.WriteLine(sentence.StartsWith("You"));


          //3. EndsWith
          // EndsWith function detemines whether the given string end with the entered letter
          // Return Boolean Type

           Console.WriteLine(sentence.EndsWith("India"));
           Console.WriteLine(sentence.EndsWith("UK"));
          
          
        }
    }

