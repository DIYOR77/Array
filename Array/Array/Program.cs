namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Massivning qator ulchamini kiriting: ");
            string ustun=Console.ReadLine();
            bool isnumber1 = int.TryParse(ustun, out int number1);

            Console.Write(" Massivning ustun ulchamini kiriting: ");
            string qator = Console.ReadLine();
            bool isnumber2 = int.TryParse(qator,out int number2);

            if(isnumber1 && isnumber2)
            {
                int[,]arr=new int[number1,number2];
                fillArray(arr,number1,number2);
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            }
            Main(args);
        }
        public static int fillArray(int[,]arr,int nubmer1,int number2)
        {
            Random random= new Random();    
            for(int i = 0; i < nubmer1; i++)
            {
                for(int j=0;j<number2; j++)
                {
                    arr[i,j] = random.Next(10,99);
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine();
            }
            return nubmer1+number2;
        }
        
    }
}