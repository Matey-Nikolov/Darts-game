using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameName = Console.ReadLine();

            int points = 301;
            string SingleDoubleTripleRetire = "";
            int successFulshots = 0;
            int unsuccessFulshots = 0;

            while (SingleDoubleTripleRetire != "Retire")
            {
                SingleDoubleTripleRetire = Console.ReadLine();
                if (SingleDoubleTripleRetire == "Retire")
                {
                    Console.WriteLine($"{gameName} retired after {unsuccessFulshots} unsuccessful shots.");
                    break;
                }

                int point = int.Parse(Console.ReadLine());

                switch (SingleDoubleTripleRetire)
                {
                    case "Single":
                        point = point * 1;
                        if (point <= points)
                        {
                            points = points - point;
                            successFulshots++;
                        }
                        else
                        {
                            unsuccessFulshots++;
                        }
                        break;
                    case "Double":
                        point = point * 2;
                        if (point <= points)
                        {
                            points = points - point;
                            successFulshots++;
                        }
                        else
                        {
                            unsuccessFulshots++;
                        }
                        break;
                    case "Triple":
                        point = point * 3;
                        if (point <= points)
                        {
                            points = points - point;
                            successFulshots++;
                        }
                        else
                        {
                            unsuccessFulshots++;
                        }
                        break;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{gameName} won the leg with {successFulshots} shots.");
                    break;
                }
            }
        }
    }
}
