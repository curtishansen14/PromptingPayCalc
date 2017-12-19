using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptingPayCalc
{
    class Program
    {
        static void Main(string[] args)
        {

              PayCalc pay = new PayCalc();
                string inputHours = pay.promptForHours();
                string inputWage = pay.promptForWage();
                pay.Calculator(inputHours, inputWage);
                Console.ReadKey();

        }
    }
}
