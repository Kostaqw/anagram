using System;
using System.Text;

namespace anagram
{
    public static class Anagram
    {
        /// <summary>
        /// Возвращает строку в которой перевернуты все слова
        /// </summary>
        /// <param name="sentence">входная строка</param>
        /// <returns>перевернутая строка</returns>
        public static string ReverseSentence(string sentence)
        {
            if (sentence == null)
            { 
                throw new ArgumentNullException("the input sentence is null", nameof(sentence));
            }

            for (byte i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    byte startSymbol = i;
                    byte finishSymbol = i;

                    try
                    {
                        while (sentence[i + 1] != ' ')
                        {
                            finishSymbol++;
                            i++;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                       
                        if (i++ != sentence.Length - 1)
                        { 
                            throw new AnagramException("the index is out of range more than 1"); 
                        }
                    }

                    i = finishSymbol;

                    string word = sentence.Substring(startSymbol, finishSymbol - startSymbol + 1);
                    word = ReverseWord(word);
                    
                    sentence = sentence.Remove(startSymbol, finishSymbol - startSymbol + 1);
                    sentence = sentence.Insert(startSymbol, word);                  
                }
            }

            return sentence;
        }
     
        /// <summary>
        /// Переворачивает слово игнорируя не буквеннуы символы
        /// </summary>
        /// <param name="word">входное слово</param>
        /// <returns>перевернутое слово</returns>
        public static string ReverseWord(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word),"the input word is null");
            }
 
            int length = word.Length;
            
            var newWord = new StringBuilder();
            var symbols = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    newWord.Append(" ");
                    symbols.Append(word[i]);
                }
                else
                {
                    newWord.Append(word[i]);
                }
            }

            int index = symbols.Length - 1;

            for (int i = 0; i < length; i++)
            {
                if (newWord[i] == ' ')
                {
                    newWord[i] = symbols[index];
                    index--;
                }
            }

            return newWord.ToString();
        }
    }
}
