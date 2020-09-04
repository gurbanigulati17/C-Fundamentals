using System;


    class Program
    {
      //Program for Dice Roll...............

    static void Main(string[] args){
        String[] Player=new String[2];
        Console.WriteLine("Enter the name of Player 1: ");
        Player[0]= Console.ReadLine();
        Console.WriteLine("Enter the name of Player 2: ");
        Player[1] = Console.ReadLine();

        Random DiceRandom = new Random();
      /* int[] DiceThrow=new int[2];
       int[] PlayerTotal=new int[20];
      do
       {

        int i = 0;
        while (i <= 1)
        {
            int thisThrow = DiceRandom.Next(1, 6);
           DiceThrow[0 + i] += thisThrow;

            Console.ReadLine();
            Console.Write(Player[0 + i] + " rolled a " + thisThrow);
            if (thisThrow != 6) i++;
        }

        Console.ReadLine();
        PlayerTotal[0] += DiceThrow[0];
        PlayerTotal[1] += DiceThrow[1];


        Console.ReadLine();
        Console.Write(Player[0] + " currently has " + PlayerTotal[0]);
        Console.ReadLine();
        Console.Write(Player[1] + " currently has " + PlayerTotal[1]);
        Console.ReadLine();

    }
    while (PlayerTotal[0] < 20 && PlayerTotal[1] < 20);*/
    int[] DiceThrow=new int[2];
    int[] PlayerTotal=new int[2];
    do
        {
            

            int i = 0;
            while (i <= 1)
            {
                int thisThrow = DiceRandom.Next(1, 6);
                DiceThrow[0 + i] += thisThrow;
                
                Console.ReadLine();
                Console.Write(Player[0 + i] + " rolled a " + DiceThrow[0 + i]);
                if (DiceThrow[0 + i] != 6) i++;
            }

            Console.ReadLine();
            PlayerTotal[0] += DiceThrow[0];
            PlayerTotal[1] += DiceThrow[1];


            Console.ReadLine();
            Console.Write(Player[0] + " currently has " + PlayerTotal[0]);
            Console.ReadLine();
            Console.Write(Player[1] + " currently has " + PlayerTotal[1]);
            Console.ReadLine();

        }
        while (PlayerTotal[0] < 20 && PlayerTotal[1] <20);

       }
   }
    

