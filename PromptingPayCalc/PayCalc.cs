using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptingPayCalc
{
    class PayCalc
    {

        public string promptForHours()
        {
            string hoursInput;
            Console.WriteLine("Please enter your hours");
            hoursInput = Console.ReadLine();
            return hoursInput;
        }

        public string promptForWage()
        {
            string wageInput;
            Console.WriteLine("Please enter your wage");
            wageInput = Console.ReadLine();
            return wageInput;
        }

        public float Calculator(string hoursInput, string wageInput)
        {
             float hours = float.Parse(hoursInput);
             float wage = float.Parse(wageInput);

            float pay = hours * wage;
            
            Console.WriteLine("Your pay is {0}", pay);
            Console.ReadKey();
            
            return pay; 
           
        }    

    }
}
