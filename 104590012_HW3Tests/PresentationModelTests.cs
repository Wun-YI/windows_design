using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnglishTest.Tests
{
    [TestClass()]
    public class PresentationModelTests
    {
        private DictionaryModel _dictionaryModel;
        private PresentationModel _presentationModel;
        private PrivateObject _target1;
        private PrivateObject _target2;
        private TestModel _testModel;

        ///  <summary> PrivateObject target1, target2; </summary>
        [TestInitialize()]
        public void Initialize()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _presentationModel = new PresentationModel(_testModel);
            _target1 = new PrivateObject(_testModel);
            _target2 = new PrivateObject(_presentationModel);
        }

        /// <summary> 初始化 </summary>
        [TestMethod()]

        public void TestPresentationModel()
        {
        }

        /// <summary> SetGetQuestionType </summary>
        [TestMethod()]

        public void TestQuestionType()
        {
            _presentationModel.QuestionType = 1;
            Assert.AreEqual(1, _presentationModel.QuestionType);
        }

        /// <summary>  Test選擇是填空題選擇題還是混合題 </summary>
        [TestMethod()]

        public void TestSelectType()
        {
            Word word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            Question question = new Question(word, _dictionaryModel);
            _presentationModel.SelectType(ConstantWord.ZERO, question);
            _presentationModel.SelectType(ConstantWord.ONE, question);
            _presentationModel.SelectType(ConstantWord.TWO, question);
        }

        /// <summary> Test 讓question有東西  </summary>
        [TestMethod()]

        public void TestSetQuestion()
        {
            _presentationModel.SetQuestion();
        }

        /// <summary> Test 設定RangeQuestionNumericUpDown的範圍在哪邊 </summary>
        [TestMethod()]

        public void TestSetRangeQuestionNumericUpDown()
        {
            _presentationModel.SetRangeQuestionNumericUpDown(ConstantWord.ZERO);
        }

        /// <summary> 按下start之後 </summary>
        [TestMethod()]

        public void TestStart()
        {
            _presentationModel.SetQuestion();
            bool flag = false;
            _presentationModel._messageEvent += (e) => flag = true;
            _presentationModel.Start(ConstantWord.ZERO);
            Assert.IsTrue(!flag);
        }

        /// <summary> Test Get分數 </summary>

        [TestMethod()]

        public void TestGetScore()
        {
            _presentationModel.GetScore();
        }

        /// <summary> Test Get Time </summary>

        [TestMethod()]

        public void TestGetTime()
        {
            _presentationModel.GetTime();
        }

        /// <summary> Test Get_answerTime </summary>

        [TestMethod()]

        public void TestGetSetAnswerTime()
        {
            _presentationModel.GetSetAnswerTime = 0;
            Assert.AreEqual(0, _presentationModel.GetSetAnswerTime);
        }

        /// <summary> Test 秒 </summary>

        [TestMethod()]

        public void TestTick()
        {
            _presentationModel.GetSetAnswerTime = 0;
            _presentationModel.TickTimerSecond();
            _presentationModel.GetSetAnswerTime = 1;
            _presentationModel.TickTimerSecond();
        }
    }
}