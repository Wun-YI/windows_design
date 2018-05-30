using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EnglishTest
{
    public class DictionaryModel
    {
        public const string EMPTY_LINE = "";
        private List<Word> _wordList = new List<Word>();
        /// <summary> 抓第幾個單字 </summary>

        public Word GetElementAt(int number)
        {
            return this._wordList[number];
        }

        /// <summary> WordList長度 </summary>
        public int GetWordListLength()
        {
            return _wordList.Count;
        }

        /// <summary> 讀檔 </summary>
        public List<Word> ReadFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName, Encoding.Default); // 讀取入徑位置

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();// Read a new line
                if (line.Equals(EMPTY_LINE))// Ignore the line, if it is empty
                    continue;
                _wordList.Add(CutLine(line));
            }
            file.Close();
            return _wordList;
        }

        /*---------------------------------------------function*/

        /// <summary> 切割單字 </summary>
        private Word CutLine(string line)
        {
            string[] splitString = new string[] { ConstantWord.SYMBOL };
            string[] array = line.Split(splitString, StringSplitOptions.None);
            Word word = new Word(array[ConstantWord.ONE].Trim(), array[ConstantWord.ZERO].Trim());
            return word;
        }
    }
}