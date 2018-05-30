namespace EnglishTest
{
    public class Word
    {
        private string _chinese;
        private string _english;

        public Word(string chinese, string english) // 建構子
        {
            this._chinese = chinese;
            this._english = english;
        }

        /// <summary>
        /// 抓出中文
        /// </summary>

        public string GetChinese()
        {
            return _chinese;
        }

        /// <summary>
        /// 抓出英文
        /// </summary>
        public string GetEnglish()
        {
            return _english;
        }

        /// <summary> 計算出英文長度和切割 </summary>
        public string GetLength()
        {
            int englishLength = _english.Length;// 計算出英文長度
            return _chinese + _english[ConstantWord.ZERO] + ConstantWord.BOTTOM + _english[englishLength - 1] + ConstantWord.LEFT + englishLength.ToString() + ConstantWord.RIGHT;
        }
    }
}