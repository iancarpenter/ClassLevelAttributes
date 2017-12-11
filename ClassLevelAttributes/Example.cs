using System;

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
