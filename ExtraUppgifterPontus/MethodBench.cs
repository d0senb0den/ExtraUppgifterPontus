using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUppgifterPontus
{
    public class MethodBench
    {

        public void FirstMethod()
        {
            Console.WriteLine("Merry Methods");
        }
        public void SecondMethod(string text)
        {
            Console.WriteLine(text);
        }
        public void ThirdMethod(string text , bool something)
        {
            if (something)
            {
                SecondMethod(text.ToUpper());
            }
            else
            {
                SecondMethod(text.ToLower());
            }

        }
        public bool FourthMethod()
        {
            Console.WriteLine("Skrika eller viska? S = skrika , V = viska.");
            var input = Console.ReadKey(true);

            switch (input.KeyChar)
            {
                case 's':
                    return true;
                    
                case 'v':
                    return false;

            }
            return false;
        }
    }
}
