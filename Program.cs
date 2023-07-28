using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._04Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =20, b =30;
            double area;
            Utility u= new Utility();
            Console.WriteLine("Trước khi hoán vị a={0},b={1}",a,b);
            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoán vị đang Fage a{0},b={1}", a, b);
            u.SwapReally(ref a,ref b);
            Console.WriteLine("Sau khi hoán vị dang really a={0},b={1}", a, b);
            u.AreaCircle(100,out area);
            Console.WriteLine("Chu vi hình tròn bán kính 100 là :{0}",area);
            Console.ReadKey();
        }
        
    }
}
