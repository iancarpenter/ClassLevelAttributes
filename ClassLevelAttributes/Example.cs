using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLevelAttributes
{
    [UsefulClassMessage(s:"This is something useful")]
    class Example
    {
        public void Foo()
        {
            Console.WriteLine("Called Foo");
        }
    }
}
