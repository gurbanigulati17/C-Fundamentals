using System;


    class Program
    {
 

    static void Main(string[] args)
        {
            // Three category of data types : Namely;
            //1. Value Data Types
            //2. Referenced Data Type
            //3. Pointer Data Types......................................

            //In this program we ll concentrate highly on Pointer  Data Types.
          
            /*The Pointer Data Types will contain a memory address of the variable value.
              To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
              ampersand (&): It is Known as Address Operator. It is used to determine the address of a variable.
              asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.*/


          unsafe{

          
            // declare variable 
            int n = 30; 
              
            // store variable n address  
            // location in pointer variable p 
            int*p = &n; 
            Console.WriteLine("Value :{0}", n); 
            Console.WriteLine("Address :{0}", (int)p); 
     

          }
           
        }
    }

