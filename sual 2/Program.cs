using System;

namespace sual_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum = 0;
            
            
                Console.Write("Birinci ededinizi daxil edin: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ikinci  ededinizi daxil edin: ");
                number2 = Convert.ToInt32(Console.ReadLine());
            while (number1<=number2)
            {
                if (number1%2!=0)
                {
                    
                    sum=sum+ number1;
                }
               number1++;
              
            }
           Console.WriteLine("Toplam:"+sum);
            
        }
    }
}
