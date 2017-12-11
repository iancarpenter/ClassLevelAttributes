using System;

namespace ClassLevelAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed class UsefulClassMessageAttribute : Attribute
    {
        private string s;

        public string S
        {
            get
            {
                return s;
            }
        }

        public UsefulClassMessageAttribute(string s)
        {
            this.s = s;
        }

    }
}
