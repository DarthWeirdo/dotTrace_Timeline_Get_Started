using System;

namespace MassFileProcessing
{
    internal class StringReverser
    {
        private readonly string _original;

        public StringReverser(string original)
        {
            _original = original;
        }

        public string Reverse()
        {
            char[] charArray = _original.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}