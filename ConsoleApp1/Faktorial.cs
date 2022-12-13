using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Faktorial
    {
        public int n;
        

        public void FaktorialNum(int n)
        {
            int res = 1;
            for (int i = 1; i < n; i++)
            {
                if (n > i)
                {
                    res = i * res;
                }
                
            }
            Console.WriteLine(res);

        }
    }
}
    
