namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hello sir ,our bussines is  Carpet Cleaning Service: \n");
            //menu
            Console.WriteLine("islam,s Carpet Cleaning Service");
            Console.WriteLine("Charges:");
            Console.WriteLine("$25 per small room");
            Console.WriteLine("$35 per large room");
            Console.WriteLine(" Sales tax rate is 6.6%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("------------------------------------");
            //read how many room do you want to clean 
            Console.Write(" please enter a number of small room: ");
            int smallRoom = int.Parse(Console.ReadLine());
            Console.Write(" and enter a number of large  room: ");
            int largeRoom = int.Parse(Console.ReadLine());
            // inthilaize price for small and price for larg  and tax and cost 
            double tax = 6.6;

            int PricePerSmallRoom = 25;
            int PricePerLargeRoom = 35;
            int cost = (PricePerSmallRoom * smallRoom) + (PricePerLargeRoom * largeRoom);
            //print all variabls
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($"Number of small rooms:{smallRoom}");
            Console.WriteLine($"Number of large rooms:{largeRoom}");
            Console.WriteLine($"Price per small room:{PricePerSmallRoom:c}");
            Console.WriteLine($"Price per large room:${PricePerLargeRoom:c}");
            Console.WriteLine($"Cost:{cost:c}");
            Console.WriteLine($"tax:{tax:c1}");
            Console.WriteLine("============================");
            Console.WriteLine($"Total estimate:{cost + tax:c1}");
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine("mohamed osama:-) " + "thanks mester mohamed nabih and mester ahmed for teaching me amazing things ");





        }
    }
}
