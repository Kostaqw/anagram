using System;

namespace anagram
{
    public class AnagramException: Exception
    {
        public AnagramException(string message):base(message)
        {
        }
    }
}
