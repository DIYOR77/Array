namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Massiv uzunligini kiriting: ");
            string son=Console.ReadLine();  
            bool isnumber=int.TryParse(son, out int number);
            if(isnumber)
            {
                int[]arr = new int[number];
                Fillarray(arr, number);
                Console.WriteLine();
            }
           
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz !!! ");
            }
            
            Main(args);
        }
        public static int Fillarray(int[] arr, int number)
        {
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                arr[i] = random.Next(11, 99);
                Console.Write(" " + arr[i]);
            }
            return number;
        }
    }
}