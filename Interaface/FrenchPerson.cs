using System;
using System.Collections.Generic;
using System.Text;

namespace Interaface
{
    public class FrenchPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }
}
