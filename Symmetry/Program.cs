using System;
using System.Text;

namespace Symmetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dk = true;
            do {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("........................");
                Console.WriteLine("Nhập lựa chọn:");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("1. Tiếp tục");
                Console.WriteLine("........................");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 0:
                        {
                            dk = false;
                            break;
                        }
                        case 1:
                        {
                            dk = true;
                            Console.Write("Nhập chuỗi: ");
                            string chuoi = Console.ReadLine();
                            bool check = CheckStringIsSymmetry(chuoi);
                            string result = check ? "Chuỗi đối xứng" : "Chuỗi không đối xứng";
                            Console.WriteLine(result);
                            continue;
                        }
                }
            }
            while(dk);
        }
        public static bool CheckStringIsSymmetry(string chuoi)
        {
            for(int i =0;i<chuoi.Length/2;i++)
            {
                if(chuoi[i] != chuoi[chuoi.Length - 1 - i])
                {
                    return false;
                }    
            }    
            return true;
        }
    }
   
}
