using System;
using System.Collections.Generic;


namespace C__Programs__Beginner
{
    public class BankAccount
    {
        //1. varables declaration in a class...........
       public string Number {get;}
       public string Owner{get; set;}
       public decimal Balance{get;}

       
       //2. Constructors in a class.....................
       public BankAccount(string name, decimal initialBalance){
           this.Owner=name;
           this.Balance=initialBalance;
           
       }

       //3. Functions creation in a class...............
       public void MakeADeposit(decimal amount, DateTime date, string note){

       }
       public void MakeAwithdrawal(decimal amount, DateTime date, string note){

       }

    }
}