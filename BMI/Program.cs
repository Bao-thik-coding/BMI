using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Nhập căn nặng");
            double weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chiều cao");
            double height = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine(" Bạn Ốm quá :)))");

            else if (bmi < 25.0)
                Console.WriteLine(" Chúc mừng bạn là một người bình thường");

            else if (bmi < 30.0)
                Console.WriteLine(" Trời ơi cũng hơn mập");

            else
                Console.WriteLine(" Chia buồn tại bạn bị bèo phì rồi");
        }
    }
}
