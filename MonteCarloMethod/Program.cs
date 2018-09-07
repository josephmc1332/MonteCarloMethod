using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    public struct CoOrds
    {
        public double x, y;

        public CoOrds(double p1, double p2)
        {
            x = p1;
            y = p2;
        }

        public CoOrds(double[] args) 
        {
            Random random = new Random();
            x = random.NextDouble();
            y = random.NextDouble();
          
        }

        
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("How many?");
            int iterations = Convert.ToInt32(Console.ReadLine());

            double[] coordinates = new double [iterations];
            CoOrds coords = new CoOrds(coordinates);

         
            double inTheCircle = 0.0;

            Random random = new Random();

            for (double i = 0.0; i <= iterations; ++i)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();
               if (Calculate(x,y) < 1.0)
                {
                    inTheCircle++;
                }
            }
            double myEstimate = inTheCircle/iterations * 4.0;



            Console.WriteLine($"in the circle {inTheCircle}");

            double difference = Math.Abs( Math.PI - myEstimate);

            Console.WriteLine($"my estimate of pi {myEstimate}");

            Console.WriteLine($"diff of my estimate and pi {difference}");

            Console.ReadLine();
        }


        public static double Calculate(double x, double y)
        {
            CoOrds coords = new CoOrds(x, y);


            double hyp = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return hyp;
        }
    }
}
