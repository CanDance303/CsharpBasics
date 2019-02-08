using System;

namespace CsharpBasics
{
    class Program
    {

        static void Main(string[] args)
        {
            /*constants*/
            const byte sample1 = 0x3A;
            const float acceleration = 9.800f;
            const string greeting = "Hello";

            /*variables*/
            byte sample2;
            int heartrate;
            double deposits;
            float mass = 14.6f;
            double distance;
            bool lost = true;
            bool expensive = true;
            int choice;
            char integral = '\u222B';
            string name = "Karen";
            float force;
            int age;

            /* actual initialization */
            sample2 = 58;
            heartrate = 85;
            deposits = 135002796;
            distance = 129.763001;
            choice = 2;
            integral = '\u222B';
            age = 0;
            force = mass * acceleration;

            /* WriteLines */
            Console.WriteLine("sample1 = {0}", sample1);
            Console.WriteLine("sample2 = {0}, heartrate = {1}, deposits = {2}", sample2, heartrate, deposits);
            Console.WriteLine("acceleration = {0}, mass = {1}, choice = {2}", acceleration, mass, choice);
            Console.WriteLine(integral);
            Console.WriteLine("greeting = {0}, name = {1}", greeting, name);


            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not the same.");
            }


            if (heartrate >= 40 && heartrate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are very wealthy!");
            }
            else
            {
                Console.WriteLine("Sorry, that you're so poor.");
            }


            Console.WriteLine("force = {0}", force);
            Console.WriteLine(distance + " is the distance.");


            if (lost == true
            && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }


            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }


            Console.WriteLine(integral + " is an integral.");


            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i = {0}", i);
            }


            while (true)
            {
                Console.WriteLine("Age = {0}", age);

                age++;

                if (age > 6)
                    break;
            }

            Console.WriteLine(greeting + " " + name);
            Console.ReadLine();

        }
    }
}

