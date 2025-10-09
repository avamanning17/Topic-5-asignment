using System.ComponentModel.Design;
using System.Numerics;

namespace Topic_5_asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double venus, mars, jupiter, saturn, uranus, neptune;
            double earthWeight, planetWeight;
            string planet;
            venus = 0.78;
            mars = 0.39;
            jupiter = 2.65;
            saturn = 1.17;
            uranus = 1.05;
            neptune = 1.23;




            Console.WriteLine("Please enter your current earth weight");
            double.TryParse(Console.ReadLine(), out earthWeight);

            Console.WriteLine("I have information for the following 6 planets");
            Console.WriteLine(" 1.Venus  2.Mars  3.Jupiter  4.Saturn  5.Uranus  6.Neptune");
            Console.WriteLine("Which planet are you visiting?");
            planet = Console.ReadLine();

            if (planet.ToLower() == "venus" || planet == "1")
            {
                planetWeight = earthWeight * venus;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on Venus.");

            }

            else if (planet.ToLower() == "mars" || planet == "2")
            {
                planetWeight = earthWeight * mars;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on mars.");

            }

            else if (planet.ToLower() == "jupiter" || planet == "3")
            {
                planetWeight = earthWeight * jupiter;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on jupiter.");

            }

            else if (planet.ToLower() == "staurn" || planet == "4")
            {
                planetWeight = earthWeight * saturn;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on saturn.");

            }
            else if (planet.ToLower() == "uranus" || planet == "5")
            {
                planetWeight = earthWeight * uranus;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on uranus.");

            }

            else if (planet.ToLower() == "neptune" || planet == "6")
            {
                planetWeight = earthWeight * neptune;
                Console.WriteLine("Your weight would be " + planetWeight + " pounds on neptune.");

            }
            else
            {

                Console.WriteLine("Error");

            }

            int legs, equation;
            Console.WriteLine("Quiz time!");
            Console.WriteLine();
            Console.WriteLine("How many legs does a dog have?");
            int.TryParse(Console.ReadLine(), out legs);
            if (legs == 4)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are incorrect!");

            }
            Console.WriteLine();
            Console.WriteLine("What is 3*(2-1)?");
            int.TryParse(Console.ReadLine(), out equation);
            if (equation == 3)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are incorrect!");
            }

            int tempature;
            Console.WriteLine();
            Console.WriteLine("Enter any tempature in degrees celsius at wich water is liquid");
            int.TryParse(Console.ReadLine(), out tempature);
            if (tempature >= 0 && tempature <= 100)
            {
                Console.WriteLine("You are Correct!");
            }

            string correctAnswer, color;
            Console.WriteLine("What is the color of a stop sign?");
            Console.WriteLine("Your options are A.blue B.yellow C.red D.green");
            Console.WriteLine("Wich one is correct?");
            color = Console.ReadLine();
          
            correctAnswer = "c";

            if (color.ToLower() == "red" || color.ToLower() == correctAnswer)
            {
                Console.WriteLine("You are correct");

            }

            else
            {
                Console.WriteLine("You are incorrect");
            }

            Console.WriteLine("Here is your mark on the quiz!");

            

        }

    }
}
