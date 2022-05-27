using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace anagram
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReverseWordTestStandartValue()
        {
            const string word = "qwe123asd";
            const string except = "dsa123ewq";

            string result = Anagram.ReverseWord(word);

            Assert.AreEqual(except, result);
        }

        [TestMethod]
        public void ReverseWordTestNotLetterInBeginEnd()
        {
            const string word = "1qweasd3";
            const string except = "1dsaewq3";

            string result = Anagram.ReverseWord(word);

            Assert.AreEqual(except, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWordTestIsNull()
        {
            const string word = null;

            Anagram.ReverseWord(word);
        }

        [TestMethod]
        public void ReverseSentenceTestStandrtValue()
        {
            const string sentence = "qwe123asd  zxcv     a3sdf2";       
            const string except = "dsa123ewq  vcxz     f3dsa2";

            string result = Anagram.ReverseSentence(sentence);
           
            Assert.AreEqual(except, result);
        }

        [TestMethod]
        public void ReverseSentenceTestSpacesBeginEnd()
        {
            const string sentence = "  1qweasd3  s  cvbn ";
            const string except = "  1dsaewq3  s  nbvc ";

            string result = Anagram.ReverseSentence(sentence);

            Assert.AreEqual(except, result);
        }

        [TestMethod]
        public void ReverseSentenceTestOneSymbol()
        {
            const string sentence = "a";
            const string except = "a";

            string result = Anagram.ReverseSentence(sentence);

            Assert.AreEqual(except, result);
        }

        [TestMethod]
        public void ReverseSentenceTestEmptySentence()
        {
            const string sentence = "";
            const string except = "";

            string result = Anagram.ReverseSentence(sentence);

            Assert.AreEqual(except, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseSentenceTestSentenceIsNull()
        {
            const string sentence = null;

            Anagram.ReverseSentence(sentence);
        }
    }
}
