using System.Globalization;

namespace Binary_to_Decimal
{
    internal class Program
    {
        static void Main()
        {
            //Convert an unsigned binary to decimal and vice versa 
            List<int> number = new List<int>();
            number.Add(128);
            number.Add(64);
            number.Add(32);
            number.Add(16);
            number.Add(8);
            number.Add(4);
            number.Add(2);
            number.Add(1);
            int total=0;
            Console.Write("Please enter in a 8 bit unsigned binary number: ");
            string binaryNum = Console.ReadLine();
            List<string> list = new List<string>();
            foreach (char character in binaryNum)//looking for each character in string c
            {
                list.Add(Convert.ToString(character));
            }
           for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "1")
                {
                    total = total + number[i];
                }
            }
            Console.WriteLine(total);
            List<int> deci = new List<int>();
            for (int i = 0;i < list.Count; i++) 
            {
                if (total < number[i])
                {
                    deci.Add(0);
                }
                if (total >= number[i])
                {
                        deci.Add(1);
                    total = total - number[i];
                }
                
            }
            for (int i = 0; i < deci.Count; i++)
            {
                Console.Write(deci[i]);
            }
        }
    }
}