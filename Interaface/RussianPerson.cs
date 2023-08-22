using System;
using System.Collections.Generic;
using System.Text;

namespace Interaface
{
    public class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("привет");
        }
    }
}
