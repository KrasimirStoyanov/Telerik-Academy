using System;
namespace FirstExample
{
     /* ...*****...
        ..*..*..*..
        .*...*...*.
        ***********
        .*...*...*.
        ..*..*..*..
        ...*.*.*...
        ....***....
        .....*.....   */
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            int size = int.Parse(userinput);
            int width = (size * 2) + 1;
            int height = 6 + ((size - 3) / 2) * 3;

            string firstLineDots = new String('.', (width - size) / 2);
            string firstLineStars = new String('*', size);

            Console.WriteLine("{0}{1}{0}",firstLineDots,firstLineStars,firstLineDots);

            for (int row = 0; row < height/3 - 1; row++)
            {
                int dotsCount = (width - 3) / 4 - row;
                string endsDots = new String('.', dotsCount);
                string middleDots = new String('.', (width - 2 * dotsCount - 3) / 2);
                Console.WriteLine("{0}*{1}*{1}*{0}", endsDots, middleDots);
            }
            string middleSymbols = new String('*', width);
            Console.WriteLine(middleSymbols);

            int middleDotsCounts = size - 2;

            for (int row = 0; row < size; row++)
            {
                int begginingDotsCount = row + 1;
                string begginingDots = new String('.', begginingDotsCount);
                if (middleDotsCounts >= 0)
                {
                    string middleDots = new String('.', middleDotsCounts);
                    Console.WriteLine("{0}*{1}*{1}*{0}", begginingDots, middleDots);
                    middleDotsCounts--;
                }
                else
                {
                    Console.WriteLine("{0}*{0}", begginingDots);
                }
            }
        }
    }
}
