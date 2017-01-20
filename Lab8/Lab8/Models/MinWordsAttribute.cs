using System;

namespace Lab8.Models
{
    internal class MinWordsAttribute : Attribute
    {
        private int v;

        public MinWordsAttribute(int v)
        {
            this.v = v;
        }
    }
}