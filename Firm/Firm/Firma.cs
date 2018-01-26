using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    public class Firma
    {
        public string title;
        public string address;
        public string phone;
        public int outcome;
        public int expense;

        public Firma(string Title = "no title", string Address = "no address", string Phone = "No number", int Outcome = 0, int Expense =0)
        {
            title = Title;
            address = Address;
            phone = Phone;
            outcome = Outcome;
            expense = Expense;

        }
        public Firma(Firma previousFirma)
        {
            title = previousFirma.title;
            address = previousFirma.address;
            phone = previousFirma.phone;
            outcome = previousFirma.outcome;
            expense = previousFirma.expense;
        }
        public void Askdata()
        {
            Console.WriteLine("Title:");
            title = Console.ReadLine();
            Console.WriteLine("Address:");
            address = Console.ReadLine();
            Console.WriteLine("Phone:");
            phone = Console.ReadLine();
            Console.WriteLine("Outcome");
            outcome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expense:");
            expense = Convert.ToInt32(Console.ReadLine());
        }
        public string Win()
        {

            if ((this.outcome/this.expense) <= 2) // voitto alle 100% suurempi kuin menot
                return $"Yrityksellä {title} menee huonosti";

            else if ((this.outcome/this.expense) >= 3 && (this.outcome/this.expense) <4 ) // voitto vähintään 200% suurempi kuin menot
                return $"Yrityksellä {title} menee tyydyttävästi";

            if ((this.outcome/this.expense) >= 4) // voitto vähintään 300% suurempi kuin menot
                return $"Yrityksellä {title} menee hyvin";

            else
                return $"Firman {title} voittoprosentti suhteessa kuluihin on välillä 100-200 prosenttia tai lähtötiedot ovat puutteelliset";




        }
    }

}
