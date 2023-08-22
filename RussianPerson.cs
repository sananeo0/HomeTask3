using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    public class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("здороваться");
        }
    }
}
