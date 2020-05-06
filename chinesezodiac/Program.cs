using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 태어난 년도(ex 2002)>> ");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("당신은 원숭이 띠 입니다~");
                    break;
                case 1:
                    Console.WriteLine("당신은 닭 띠 입니다~");
                    break;
                case 2:
                    Console.WriteLine("당신은 개 띠 입니다~");
                    break;
                case 3:
                    Console.WriteLine("당신은 돼지 띠 입니다~");
                    break;
                case 4:
                    Console.WriteLine("당신은 쥐 띠 입니다~");
                    break;
                case 5:
                    Console.WriteLine("당신은 소 띠 입니다~");
                    break;
                case 6:
                    Console.WriteLine("당신은 호랑이 띠 입니다~");
                    break;
                case 7:
                    Console.WriteLine("당신은 토끼 띠 입니다~");
                    break;
                case 8:
                    Console.WriteLine("당신은 용 띠 입니다~");
                    break;
                case 9:
                    Console.WriteLine("당신은 뱀 띠 입니다~");
                    break;
                case 10:
                    Console.WriteLine("당신은 말 띠 입니다~");
                    break;
                case 11:
                    Console.WriteLine("당신은 양 띠 입니다~");
                    break;

            }
        }
    }
}
