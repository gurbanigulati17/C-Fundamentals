using System;


    class Program
    {
 

  
        

  
     public  static string firstKCharacters(string str, int k) 
       { 
        
      
      if (str == null ) 
          return null; 
      if (str.Length > k) 
          return str.Substring(0, k); 
      else
          return str; 
  } 
    
  
static void Main(string[] args) 
  { 
      
      string str = "JacobScott"; 
      int k = 5;
      Console.WriteLine(firstKCharacters(str, k)); 
  } 
        
    }

