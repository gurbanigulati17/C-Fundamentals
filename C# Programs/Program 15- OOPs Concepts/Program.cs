using System;
using System.Collections.Generic;
namespace C__Programs__Beginner
{

  class Vehicle{

    public string brandName="Cruise"; //Public Access Specifier
    private string color="Black"; //Private Access Specifier

    public void display(){      //Reflects method overriding (Polymorphism)
      Console.WriteLine($" The Brand Name and the color is {brandName} and {color}");
    }

  }

  class Car:Vehicle{    //Inheritance
    public string modelName="Scott";
    public void display(){          //Reflects mathod overriding (Polymorishm)
      Console.WriteLine($"The Brand name and the model name is {brandName} and {modelName} ");
     // Console.WriteLine($"The Brand name and the color is {brandName} and {color}"); //ERROR
    }
  }
    

    class Program
    {
           static void Main(string[] args)
        {  
            Vehicle car=new Car(); //Object of class Vehicle Type
            car.display();        //Calls the display method of class Vehicle
            Car car1=(Car)car;   //TypeCasting to convert the car object to Car Type
            car1.display();     //Calls the display method of class Car

        }
    }
}

