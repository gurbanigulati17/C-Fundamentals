using System;


    class Program
    {
 

  
           static void Main(string[] args)
        { 


          //Baiscs Of String

          //1. Printing String 
          string firstFriend="Riya";
          string secondFriend="Priya";
          Console.WriteLine($"My Friends are {firstFriend} and {secondFriend} ");
         

          //2, String Length function to determine Length Of the String......
          Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} Letters");
          Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} Letters");

        
          //3. Trimming of the String Methods.......
          //1.  TrimStart()   Trimmed From the start
          //2.  TrimEnd()     Trimmed From the end
          //3.  Trim()        Trimmed from start and end



          string word="      Gurubani Gulati!       ";
          Console.WriteLine(word);
          string wordtrimstart= word.TrimStart();
          string wordtrimend= word.TrimEnd();
          string wordtrim=word.Trim();
          Console.WriteLine(wordtrimstart);
          Console.WriteLine(wordtrimend);
          Console.WriteLine(wordtrim);

        
          
          //4. ToUpper() and ToLower()  Methods ...................
          string variable="GURU";
          Console.WriteLine(firstFriend.ToUpper());
          Console.WriteLine(variable.ToLower());

        

          //5. Replace Function Of Strings.........................
          string sayWelcome="Hello Welcome";
          Console.WriteLine(sayWelcome);
          sayWelcome=sayWelcome.Replace("Hello", "Greetings");
          Console.WriteLine(sayWelcome);



          
          
        }
    }

