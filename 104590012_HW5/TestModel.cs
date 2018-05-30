using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishTest
{
    public class TestModel
    {
        private int _beQuestionNumber = 1;
        private DictionaryModel _dictionaryModel;
        private int _index = 0;
        private bool _isCheck = false;
        private List<Question> _questionList = new List<Question>();
        private List<Word> _topicList = new List<Word>();
        private int _type;
        private string _displayMessage;
        private string _result;
        private int _checkTopicNumber;

        /// <summary> 初始化 </summary>
        public TestModel(DictionaryModel dictionaryModel)
        {
            this._dictionaryModel = dictionaryModel;
            dictionaryModel.ReadFile(@"EnglishWord.txt");
        }

        /// <summary> Test index </summary>
        public int SetGetIndex
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        /// <summary> index++ </summary>
        public void AddIndex()
        {
            _index++;
        }

        /// <summary> 取得變動題目的數量 </summary>
        public int GetChangeQuestionNumber()
        {
            return _beQuestionNumber;
        }

        /// <summary> 取得字典的長度 </summary>
        public int GetDictionaryWordsLength()
        {
            return _dictionaryModel.GetWordListLength();
        }

        /// <summary> 取得index才知道第幾題 </summary>
        public int GetIndex()
        {
            return _index;
        }

        /// <summary> 取得一個問題 </summary>
        public Question GetQuestion()
        {
            if (_index >= GetChangeQuestionNumber())
                return null;
            return _questionList[_index];
        }

        /// <summary> 如果沒有重複我的答案我就存進list裡面 </summary>
        public void IsCheck(int tempNumber)
        {
            if (!_isCheck)
            {
                _topicList.Add(this._dictionaryModel.GetElementAt(tempNumber));
            }
        }

        /// <summary> 判斷我的亂數是否有跟list裡面重複。 </summary>
        public void IsSomeWord(int tempNumber)
        {
            for (int i = 0; i < _topicList.Count(); i++)
            {
                if (this._dictionaryModel.GetElementAt(tempNumber) == _topicList.ElementAt(i))
                {
                    _isCheck = true;
                }
            }
        }

        /// <summary> 製造一個問題 </summary>
        public void MakeQuestion()
        {
            for (int i = 0; i < GetChangeQuestionNumber(); i++)
            {
                Question question = new Question(_topicList[i], _dictionaryModel);
                question.SetTypeNumber(_type);
                question.CreateQueen();
                _questionList.Add(question);
            }
        }

        /// <summary> 讀取我的題目產生出亂數 </summary>
        public void ReadTextTopic(int seed)
        {
            Random randomNumber = new Random(seed); // 亂數種子
            while (_topicList.Count <= GetChangeQuestionNumber() - 1)
            {
                _isCheck = false;
                int tempNumber = randomNumber.Next(0, this._dictionaryModel.GetWordListLength());

                IsSomeWord(tempNumber);
                IsCheck(tempNumber);
            }
        }

        /// <summary> Test TopicList </summary>
        public void SetAddTopicList()
        {
            Word word = new Word(ConstantWord.CHINESE_A, ConstantWord.TEST_ENGLISH_1);
            Word word1 = new Word(ConstantWord.CHINESE_FEW, ConstantWord.ENGLISH_FEW);
            Word word2 = new Word(ConstantWord.CHINESE_LITTLE, ConstantWord.ENGLISH_LITTLE);
            Word word3 = new Word(ConstantWord.CHINESE_LOT, ConstantWord.ENGLISH_LOT);
            Word word4 = new Word(ConstantWord.CHINESE_AM, ConstantWord.ENGLISH_AM);
            Word word5 = new Word(ConstantWord.CHINESE_ABLE, ConstantWord.ENGLISH_ABLE);
            Word word6 = new Word(ConstantWord.CHINESE_ABOUT, ConstantWord.ENGLISH_ABOUT);
            Word word7 = new Word(ConstantWord.CHINESE_ABOVE, ConstantWord.ENGLISH_ABOVE);
            _topicList.Add(word);
            _topicList.Add(word1);
            _topicList.Add(word2);
            _topicList.Add(word3);
            _topicList.Add(word3);
            _topicList.Add(word4);
            _topicList.Add(word5);
            _topicList.Add(word6);
            _topicList.Add(word7);
        }

        /// <summary> Test 設定取得變動題目的數量 </summary>
        public void SetChangeQuestionNumber(int number)
        {
            _beQuestionNumber = number;
        }

        /// <summary> Test set取得一個問題 </summary>
        public void SetQuestionList(Word word)
        {
            SetAddTopicList();
            Question question = new Question(word, _dictionaryModel);
            question.SetTypeNumber(0);
            question.CreateQueen();
            _questionList.Add(question);
        }

        /// <summary> 設定範圍讓testmodel知道  </summary>
        public void SetQuestionNumericUpDown(int number)
        {
            _beQuestionNumber = number;
        }

        /// <summary> 設定我的type給testmodel知道 讓Question可以用 </summary>
        public void SetType(int type)
        {
            _type = type;
        }

        /// <summary> 案開始扭之後 </summary>
        public void Start(int seed)
        {
            _checkTopicNumber = 0;
            _result = "";
            _index = 0;
            _questionList.Clear();
            _topicList.Clear();
            ReadTextTopic(seed);
            MakeQuestion();
        }

        /// <summary> Test 設定答案 </summary>
        public bool CheckAnswer(string answer, string peopleAnswer)
        {
            const string FORMAT = "Question:{0} Anwer:{1}\n\n";
            if (answer.Equals(peopleAnswer))
            {
                _displayMessage = ConstantWord.CORRECT;
                _checkTopicNumber++;
                return true;
            }
            else
            {
                _displayMessage = ConstantWord.ERROR + peopleAnswer.ToString() + ConstantWord.ERROR_SYMBOL;
                _result += String.Format(FORMAT, _questionList[GetIndex()].GetTopic(), peopleAnswer);
                return false;
            }
            
        }

        /// <summary> 取得訊息判斷是否正確 </summary>
        public string GetResult()
        {
            return ConstantWord.PASS + _checkTopicNumber.ToString() + ConstantWord.OF + GetIndex().ToString() + ConstantWord.QUESTIONS + ConstantWord.WRAP + _result;
        }

        /// <summary> 取得訊息判斷是否正確 </summary>
        public string GetDisplayMessage()
        {
            return _displayMessage;
        }
    }
}