using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishTest
{
    public class Question
    {
        private string _answer;
        private DictionaryModel _dictionaryModel;
        private bool _isCheck = false;
        private List<string> _option = new List<string>();
        private int _randomVacancySelect = 0;
        private string _topic;
        private int _typeNumber;
        private Word _word;

        /// <summary> 初始化 </summary>
        public Question(Word word, DictionaryModel dictionaryModel)
        {
            this._word = word;
            this._dictionaryModel = dictionaryModel;
            _randomVacancySelect = 0;
        }

        /// <summary> 創造問題 </summary>
        public int CreateQueen()
        {
            if (_typeNumber == ConstantWord.ZERO)
            {
                CreateQueenOption(ConstantWord.ZERO);
                return ConstantWord.ZERO;
            }
            else if (_typeNumber == ConstantWord.ONE)
            {
                CreateQueenOption(ConstantWord.ONE);
                return ConstantWord.ONE;
            }
            else if (_typeNumber == ConstantWord.TWO)
            {
                CreateQueenFunction();
                return ConstantWord.TWO;

            }
            return ConstantWord.THREE ;
        }

        /// <summary> 幫忙分擔function行數 </summary>
        private void CreateQueenFunction()
        {
            const int RANDOM = 2;
            Random makeRandomNumber = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = makeRandomNumber.Next(ConstantWord.ZERO, RANDOM);
            CreateQueenOption(randomNumber);
            this._randomVacancySelect = randomNumber;
        }

        /// <summary> 取得我的答案 </summary>
        public string GetAnswer()
        {
            return _answer;
        }

        /// <summary> 取得我的選項 </summary>
        public List<string> GetOption()
        {
            return _option;
        }

        /// <summary> 取得亂數是是非題還是選擇題 </summary>
        public int GetRandomVacancySelect()
        {
            return _randomVacancySelect;
        }

        /// <summary> 抓題目 </summary>
        public string GetTopic()
        {
            return _topic;
        }

        /// <summary> 設定SetTypeNumber </summary>
        public void SetTypeNumber(int examType)
        {
            _typeNumber = examType;
        }

        /// <summary> 判斷中文是否有對 </summary>
        private string CheckAnswerChinese(int tempNumber)
        {
            return this._dictionaryModel.GetElementAt(tempNumber).GetChinese();
        }

        /// <summary> 創造選項  </summary>
        private List<string> CreateOption()
        {
            List<string> tempOption = new List<string>();
            const int LENGTH = 3; // 選項有三個
            const int RANDOM = 4; // 亂數回傳最多4個
            Random randomNumber = new Random(Guid.NewGuid().GetHashCode());// 亂數種子

            while (tempOption.Count < LENGTH)
            {
                _isCheck = false;
                int tempNumber = randomNumber.Next(ConstantWord.ZERO, this._dictionaryModel.GetWordListLength());
                IsSomeWord(tempNumber, _answer);
                if (!_isCheck)
                    tempOption.Add(CheckAnswerChinese(tempNumber));
            }
            int random = randomNumber.Next(ConstantWord.ZERO, RANDOM);//回傳0123
            tempOption.Insert(random, _answer);
            return tempOption;
        }

        /// <summary> 創造填空題或是選擇題 </summary>
        public int CreateQueenOption(int randomNumber)
        {
            if (randomNumber == ConstantWord.ZERO)
            {
                _topic = _word.GetLength();
                _answer = _word.GetEnglish();
                _option.Add("");
                _option.Add("");
                _option.Add("");
                _option.Add("");
                return ConstantWord.ZERO;
            }
            else if (randomNumber == ConstantWord.ONE)
            {
                CreateQueenOptionFunction();
                return ConstantWord.ONE;
            }
            return ConstantWord.TWO;
        }

        /// <summary> 幫忙分擔CreateQueenOption </summary>
        private void CreateQueenOptionFunction()
        {
            _topic = _word.GetEnglish();
            _answer = _word.GetChinese();
            _option = new List<string>(CreateOption());
        }
        /// <summary> Test讓list可以做測試</summary>

        public void SetOptionList()
        {
            _option.Add(ConstantWord.CHINESE_A);
            _option.Add(ConstantWord.CHINESE_FEW);
            _option.Add(ConstantWord.CHINESE_LITTLE);
            _option.Add(ConstantWord.CHINESE_LOT);
            _option.Add(ConstantWord.CHINESE_AM);
            _option.Add(ConstantWord.CHINESE_ABLE);
            _option.Add(ConstantWord.CHINESE_ABOUT);
            _option.Add(ConstantWord.CHINESE_ABOVE);
        }
        /// <summary> 判斷陣列是否有重複 </summary>

        public void IsSomeWord(int tempNumber, string textAnswer)
        {
            for (int i = 0; i < _option.Count(); i++)
            {
                if (this._dictionaryModel.GetElementAt(tempNumber).GetChinese() == _option.ElementAt(i) && CheckAnswerChinese(tempNumber) == textAnswer)
                {
                    _isCheck = true;
                }
            }
        }
    }
}