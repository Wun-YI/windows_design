using System;
using System.Collections.Generic;

namespace EnglishTest
{
    public partial class PresentationModel
    {
        public delegate void MessageEventHandler(String message);
        public event MessageEventHandler _messageEvent;
        private string _answer;
        private string _displayGroupBoxText;
        private int _examType;
        private bool _isSelect;
        private bool _isStartEnabled;
        private bool _isVacancy;
        private List<String> _optionTopic = new List<string>();
        private TestModel _testModel;
        private String _topic;
        private int _type;
        private int _answerScoreTime = ConstantWord.TEN;
        private int _time = 0;
        private int _score = 0;
        private int _correctNumber = 0; // 正確數量

        /// <summary> 初始化 </summary>
        public PresentationModel(TestModel testModel)
        {
            this._testModel = testModel; // 讓PresentationModel可以知道testmodel
        }

        /// <summary> SetGetQuestionType </summary>
        public int QuestionType
        {
            get;set;
        }

        /// <summary> 判斷選擇題的答案是否有答對 </summary>
        public void BeNext(string answerText, bool[] radioButton, string[] radioButtonText)
        {
            string radioButtonAnswer;
            radioButtonAnswer = answerText;
            for (int i = 0; i <= ConstantWord.THREE; i++)
            {
                if (radioButton[i])
                    radioButtonAnswer = radioButtonText[i];
            }
            CheckAnswer(radioButtonAnswer);
        }

        /// <summary> Test 設定答案 </summary>

        public void CheckAnswer(string answer)
        {
            if (_testModel.CheckAnswer(answer,_answer))
                _correctNumber++;
            _testModel.AddIndex();
        }

        /// <summary> 顯示是選擇題還是填空題 </summary>
        public string GetDisplayGroupBoxText()
        {
            return _displayGroupBoxText;
        }

        /// <summary> 取得訊息判斷是否正確 </summary>
        public string GetDisplayMessage()
        {
            return _testModel.GetDisplayMessage();
        }

        /// <summary> 取得單字有幾個 </summary>
        public int GetFileWords()
        {
            return _testModel.GetDictionaryWordsLength();
        }

        /// <summary> 取得題目list </summary>
        public List<String> GetOptionTopic()
        {
            return _optionTopic;
        }

        /// <summary> 取得問題 </summary>
        public void GetQuestion()
        {
            _answerScoreTime = ConstantWord.TEN;
            Question question = _testModel.GetQuestion();
            if (question == null)
            {
                _messageEvent(_testModel.GetResult());
                _isStartEnabled = true;
            }
            else
            {
                _topic = question.GetTopic();
                SelectType(_examType, question);
                _optionTopic = question.GetOption();
                _answer = question.GetAnswer();
                GetQuestionType();
            }
        }

        /// <summary> 取得填空問題還是選擇問題，顯示出是填空還是選擇 </summary>
        public void GetQuestionType()
        {
            if (_type == ConstantWord.ZERO)
                _displayGroupBoxText = ConstantWord.QUESTION + (_testModel.GetIndex() + 1).ToString() + ConstantWord.VACANCY;
            else
                _displayGroupBoxText = ConstantWord.QUESTION + (_testModel.GetIndex() + 1).ToString() + ConstantWord.SELECT;
            _isVacancy = (_type == ConstantWord.ZERO);
            _isSelect = !_isVacancy;
        }

        /// <summary> 按下stop直接取得當前題目數量，判斷答對幾題 </summary>
        public void GetStop()
        {
            _messageEvent(_testModel.GetResult());
            _isStartEnabled = true;
        }

        /// <summary> 取得_topic </summary>
        public string GetTopic()
        {
            return _topic;
        }

        /// <summary> 取得start的反向 </summary>
        public bool IsReverseStartEnabled()
        {
            return !(_isStartEnabled);
        }

        /// <summary> 取得_isGroupboxTwo </summary>
        public bool IsSelect()
        {
            return _isSelect;
        }

        /// <summary> 取得_startEnabled </summary>
        public bool IsStartEnabled()
        {
            return _isStartEnabled;
        }

        /// <summary> 取得_isGroupboxOne </summary>
        public bool IsVacancy()
        {
            return _isVacancy;
        }

        /// <summary> 選擇是填空題選擇題還是混合題 </summary>
        public void SelectType(int examType, Question question)
        {
            if (examType == ConstantWord.ZERO)
                _type = ConstantWord.ZERO;
            else if (examType == ConstantWord.ONE)
                _type = ConstantWord.ONE;
            else if (examType == ConstantWord.TWO)
                _type = question.GetRandomVacancySelect();
        }

        /// <summary> 設定Questio </summary>
        public void SetQuestion()
        {
            Word word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            DictionaryModel dictionaryModel = new DictionaryModel();
            dictionaryModel.ReadFile(ConstantWord.ENGLISH_WORD);
            TestModel testModel = new TestModel(dictionaryModel);
        }

        /// <summary> 設定RangeQuestionNumericUpDown的範圍在哪邊 </summary>
        public void SetRangeQuestionNumericUpDown(int number)
        {
            _testModel.SetQuestionNumericUpDown(number);
        }

        /// <summary> Test 讓question有東西  </summary>
        public void SetTestAnswer(string answer)
        {
            _answer = answer;
        }
        
        /// <summary> 按下start之後 </summary>
        public void Start(int examType)
        {
            _correctNumber = _time = _score = 0;
            _examType = examType;
            _testModel.SetType(_examType);
            _testModel.Start(Guid.NewGuid().GetHashCode());
            GetQuestion();
            _isStartEnabled = false;
        }

        /// <summary> Get分數  </summary>
        public int GetScore()
        {
            int temp;
            temp = _score + (_correctNumber * (ConstantWord.MAX_SCORE / _testModel.GetChangeQuestionNumber()));
            return (int)(temp * Convert.ToInt32(!(temp < 0)));
        }

        /// <summary> Get Time </summary>
        public String GetTime()
        {
            return String.Format(ConstantWord.TEXT, (_time / ConstantWord.SIXTY * ConstantWord.SIXTY).ToString().PadLeft(ConstantWord.TWO, ConstantWord.WORD_ZERO), ((_time / ConstantWord.SIXTY) % ConstantWord.SIXTY).ToString().PadLeft(ConstantWord.TWO, ConstantWord.WORD_ZERO), (_time % ConstantWord.SIXTY).ToString().PadLeft(ConstantWord.TWO, ConstantWord.WORD_ZERO));
        }

        /// <summary> Get _answerTime </summary>
        public int GetSetAnswerTime
        {
            get
            {
                return _answerScoreTime;
            }
            set
            {
                _answerScoreTime = value;
            }
        }

        /// <summary> 秒  </summary>
        public void TickTimerSecond()
        {
            _time++;
            _answerScoreTime--;
            if (_answerScoreTime == 0)
                _score--;
            if (_answerScoreTime == 0)
                _answerScoreTime = ConstantWord.TEN;
        }
    }
}