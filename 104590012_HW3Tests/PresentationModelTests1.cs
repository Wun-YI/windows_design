using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnglishTest.Tests
{
    [TestClass()]
    public class PresentationModelTests1
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

        /// <summary> Test 傳入按鈕答案 </summary>
        [TestMethod()]

        public void TestBeNext()
        {
            _presentationModel.SetTestAnswer(ConstantWord.CHINESE_A);
            _presentationModel.BeNext(ConstantWord.CHINESE_A, new bool[] { true, false, false, false }, new string[] { ConstantWord.CHINESE_A, ConstantWord.CHINESE_FEW, ConstantWord.CHINESE_LITTLE, ConstantWord.CHINESE_LOT });
            _presentationModel.SetTestAnswer(ConstantWord.CHINESE_LOT);
            _presentationModel.BeNext(ConstantWord.CHINESE_LOT, new bool[] { false, false, false, true }, new string[] { ConstantWord.CHINESE_A, ConstantWord.CHINESE_FEW, ConstantWord.CHINESE_LITTLE, ConstantWord.CHINESE_LOT });
        }

        /// <summary> Test 確認答案是否正確 </summary>
        [TestMethod()]

        public void TestCheckAnswer()
        {
            _testModel.SetGetIndex = 0;
            _presentationModel.SetTestAnswer(ConstantWord.TEST_ANSWER);
            _presentationModel.CheckAnswer(ConstantWord.TEST_ANSWER);
        }

        /// <summary> Test 顯示是選擇題還是填空題 </summary>
        [TestMethod()]

        public void TestGetDisplayGroupBoxText()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.GetDisplayGroupBoxText();
        }

        /// <summary> Test 取得訊息判斷是否正確 </summary>
        [TestMethod()]

        public void TestGetDisplayMessage()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.GetDisplayMessage();
        }

        /// <summary> Test 取得單字有幾個 </summary>
        [TestMethod()]

        public void TestGetFileWords()
        {
            _presentationModel.GetFileWords();
        }

        /// <summary> Test 取得題目list </summary>
        [TestMethod()]

        public void TestGetOptionTopic()
        {
            _presentationModel.GetOptionTopic();
        }

        /// <summary> Test 取得問題 </summary>
        [TestMethod()]

        public void TestGetQuestion()
        {
            TestModel testModel = new TestModel(_dictionaryModel);
            PresentationModel presentationModel = new PresentationModel(testModel);
            presentationModel.SetQuestion();
            bool flag = false;
            presentationModel._messageEvent += (e) => flag = true;
            testModel.SetGetIndex = ConstantWord.TWO;
            testModel.GetQuestion();
            Word word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _testModel.SetQuestionList(word);
            _testModel.SetGetIndex = ConstantWord.TWO;
            _testModel.SetChangeQuestionNumber(ConstantWord.ZERO);
            _testModel.GetQuestion();
            _target1.SetFieldOrProperty(ConstantWord.INDEX, 0);
            presentationModel.GetQuestion();
            Assert.IsTrue(flag);
        }

        /// <summary> Test 取得填空問題還是選擇問題，顯示出是填空還是選擇 </summary>
        [TestMethod()]

        public void TestGetQuestionType()
        {
            _target2.SetFieldOrProperty(ConstantWord.TYPE, 0);
            _presentationModel.GetQuestionType();
            _target2.SetFieldOrProperty(ConstantWord.TYPE, 1);
            _presentationModel.GetQuestionType();
        }

        /// <summary> Test 按下stop直接取得當前題目數量，判斷答對幾題 </summary>
        [TestMethod()]

        public void TestGetStop()
        {
            _presentationModel = new PresentationModel(_testModel);
            bool flag = false;
            _presentationModel._messageEvent += (e) => flag = true;
            _presentationModel.GetStop();
            Assert.IsTrue(flag);
        }

        /// <summary> Test 取得_topic </summary>
        [TestMethod()]

        public void TestGetTopic()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.GetTopic();
        }

        /// <summary> Test 取得start的反向 </summary>
        [TestMethod()]

        public void TestIsReverseStartEnabled()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.IsReverseStartEnabled();
        }

        /// <summary> Test 取得_isGroupboxTwo </summary>
        [TestMethod()]

        public void TestIsSelect()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.IsSelect();
        }

        /// <summary> Test 取得_startEnabled </summary>
        [TestMethod()]

        public void TestIsStartEnabled()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.IsStartEnabled();
        }

        /// <summary> Test 取得_isGroupboxOne </summary>
        [TestMethod()]

        public void TestIsVacancy()
        {
            _presentationModel = new PresentationModel(_testModel);
            _presentationModel.IsVacancy();
        }
    }
}