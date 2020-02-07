using System;

namespace w3schoolexcercise
{
    class car
    {
        string color;
        int maxSpeed = 200;          // field
        string model;
         int year;

        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    
    static void Main(string[] args)
        {
            {
                car tesla = new car();
                tesla.color = "black";
                car bmw = new car();
                bmw.color = "grey";
                Console.WriteLine(tesla.color);
                Console.WriteLine(bmw.color);


                
                Console.WriteLine(tesla.color);
                Console.WriteLine(tesla.maxSpeed);

                car Ford = new car();
                Ford.model = "Mustang";
                Ford.color = "red";
                Ford.year = 1969;

                car Opel = new car();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;
                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);
            } 
        }
    }
    }

