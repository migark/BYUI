using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator  = new Random();
        int magicNumber = randomGenerator.Next(1,20);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess) 
            {
                Console.WriteLine("Magic number is Highest");        
            }
            else if (magicNumber < guess)
            {   
                Console.WriteLine("Magic Number is Lower");            
            }
            else{
                Console.WriteLine("You guess it! ");
            }

        }
    }
}