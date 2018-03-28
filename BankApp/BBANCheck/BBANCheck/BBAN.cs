using System;
using System.Collections.Generic;
using System.Text;

namespace BBANCheck
{
    class BBAN
    {
        public string bban;
        public BBAN(string Bban)
        {
            bban = Bban;
        }
        

        public string Bbantran()
        {
            Console.WriteLine("Input account number:");
            string bban = Console.ReadLine();
            var dashremove = new string[] { "-"," ",",","." };
            foreach (var d in dashremove)
            {
                bban = bban.Replace(d, string.Empty);
            }
            if (bban[0] == '1' || bban[0] == '2' || bban[0] == '3' || bban[0] == '6' || bban[0] == '8')
            {
                int zp = 6;
                for(int length = bban.Length;length<14;length++)
                {
                    bban = bban.Insert(zp, "0");
                }
                Console.WriteLine(bban);
                
            }



            if (bban[0] == 4 || bban[0] == 5)
            {
                int zp = 7;
                for (int length = bban.Length; length < 14; length++)
                {
                    bban = bban.Insert(zp, "0");
                }
                Console.WriteLine(bban);
            }
            string checkbban = bban.Substring(0, 13);
            string checkbban2 = bban.Substring(13, 1);
            Console.WriteLine(checkbban);
            Console.WriteLine(checkbban2);
            int i = 12;
            int t = 0;
            int l = 0;
            do
            {
                int k = (int)Char.GetNumericValue(checkbban[i]);
                Console.WriteLine(checkbban[i]);
                Console.WriteLine(k);
                t = k * 2;
                
                string T = t.ToString();
                if (T.Length > 1)
                {

                }
                
                l = l + t;
                i -= 2;
                
                Console.WriteLine(l);
                Console.WriteLine(i);
            }
            while (i > 0);
            Console.WriteLine(l);





            return bban;

        }

    }
}
