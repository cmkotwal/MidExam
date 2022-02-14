using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                int choice;
                string choiceValue;
                do
                {
                    Console.WriteLine("Choose Any one option:");
                    Console.WriteLine("1.Enter Screen Dimensions");
                    Console.WriteLine("2.Exit");
                    choiceValue = Console.ReadLine();
                } while (!int.TryParse(choiceValue, out choice) || (choice < 1) || (choice > 2));

                Program program = new Program();
                switch (choice)
                {
                    case 1:
                        program.GettingUserInput();
                        break;

                    case 2:
                        return;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.ReadKey();
            }

        public void GettingUserInput()
            {

                int width;
                string choiceWidth;
                do
                {
                    Console.Write("Enter Width of the screen in integer: ");
                    choiceWidth = Console.ReadLine();
                } while (!int.TryParse(choiceWidth, out width) || (width <= 0));

                int height;
                string choiceHeight;
                do
                {
                    Console.Write("Enter Height of the screen in integer: ");
                    choiceHeight = Console.ReadLine();
                } while (!int.TryParse(choiceHeight, out height) || (height <= 0));

                int diagonalSize;
                string choicediagonalSize;
                do
                {
                    Console.Write("Enter DiagonalSize of the screen in integer: ");
                    choicediagonalSize = Console.ReadLine();
                } while (!int.TryParse(choicediagonalSize, out diagonalSize) || (diagonalSize <= 0));

                Console.WriteLine("------------------Your All Result-------------------");


                double DiagonalSize = PixelCalc.DiagonalSize(width, height);
                Console.WriteLine("your diaogonal size in pixel {0}", DiagonalSize);

                double PPI = PixelCalc.PPI(diagonalSize);
                Console.WriteLine("your ppi value {0}", PPI);

                double DotPitch = PixelCalc.DotPitch(diagonalSize);
                Console.WriteLine("your dotpitch value {0}", DotPitch);

        }
    }
}
