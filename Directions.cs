using TjuvOchPolis;

namespace CaseTest
{
    internal class Program
    {
        public void Directions(Personer person)
        {


            Random rnd = new Random();
            int value = rnd.Next(1, 5);
            Console.WriteLine("Random value = " + value);

            int posX = 0;
            int posY = 0;

            switch (value)
            {
                case 1:
                    posX += 0;
                    posY += 1;
                    Console.WriteLine("Direction är y: " + posY + " direction x:" + posX);
                    break;

                case 2:
                    posX += 1;
                    posY += 0;
                    Console.WriteLine("Direction är y: " + posY + " direction x:" + posX);
                    break;

                case 3:
                    posX += 1;
                    posY += 1;
                    Console.WriteLine("Direction är y: " + posY + " direction x:" + posX);
                    break;

                default:
                    Console.WriteLine("Direction är y: " + posY + " direction x:" + posX);
                    break;




            }






        }
    }
}
