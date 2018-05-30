using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Tests
{
    [TestClass()]
    public class TestModelTests
    {
        private DictionaryModel _dictionaryModel;
        private PrivateObject _targetOne;
        private PrivateObject _targetTwo;
        private TestModel _testModel;
        List<Word> _wordList = new List<Word>();

        /// <summary> 初始化 </summary>
        [TestInitialize()]

        public void Initialize()
        {
            InitializeFunction();
            Word word = new Word(ConstantWord.CHINESE_A, ConstantWord.TEST_ENGLISH_1);
            Word word1 = new Word(ConstantWord.CHINESE_FEW, ConstantWord.ENGLISH_FEW);
            Word word2 = new Word(ConstantWord.CHINESE_LITTLE, ConstantWord.ENGLISH_LITTLE);
            Word word3 = new Word(ConstantWord.CHINESE_LOT, ConstantWord.ENGLISH_LOT);
            Word word4 = new Word(ConstantWord.CHINESE_AM, ConstantWord.ENGLISH_AM);
            _wordList.Add(word);
            _wordList.Add(word1);
            _wordList.Add(word2);
            _wordList.Add(word3);
            _wordList.Add(word3);
            _wordList.Add(word4);
            _targetOne.SetFieldOrProperty(ConstantWord.WORD_LIST, _wordList);
            _targetTwo.SetFieldOrProperty(ConstantWord.TOPIC_LIST, _wordList);
        }

        /// <summary> 幫忙初始化 </summary>
        private void InitializeFunction()
        {
            DictionaryModel dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(dictionaryModel);
            _targetOne = new PrivateObject(dictionaryModel);
            _targetTwo = new PrivateObject(_testModel);
        }

        /// <summary> Test 設定我的type給testmodel知道 讓Question可以用 </summary>
        [TestMethod()]

        public void SetType()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.SetType(ConstantWord.ONE);
        }

        /// <summary> Test 案開始扭之後 </summary>
        [TestMethod()]

        public void Start()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.Start(ConstantWord.ZERO);
        }

        /// <summary> Test index++ </summary>
        [TestMethod()]

        public void TestAddIndex()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.SetGetIndex = ConstantWord.ONE;
            _testModel.AddIndex();
            Assert.AreEqual(_testModel.SetGetIndex, ConstantWord.TWO);
        }

        /// <summary> Test index++ </summary>
        [TestMethod()]

        public void TestGetChangeQuestionNumber()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.GetChangeQuestionNumber();
        }

        /// <summary> Test 取得字典的長度 </summary>
        [TestMethod()]

        public void TestGetDictionaryWordsLength()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.GetDictionaryWordsLength();
        }

        /// <summary> Test index </summary>
        [TestMethod()]

        public void TestGetIndex()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.SetGetIndex = ConstantWord.ONE;
            Assert.AreEqual(_testModel.GetIndex(), ConstantWord.ONE);
        }

        /// <summary> 取得一個問題 </summary>
        [TestMethod()]

        public void TestGetQuestion()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            Word word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _testModel.SetQuestionList(word);
            _testModel.SetGetIndex = ConstantWord.TWO;
            _testModel.SetChangeQuestionNumber(ConstantWord.ZERO);
            _testModel.GetQuestion();
            _testModel.SetGetIndex = ConstantWord.ZERO;
            _testModel.SetChangeQuestionNumber(ConstantWord.TWO);
            _testModel.GetQuestion();
        }

        /// <summary> 如果沒有重複我的答案我就存進list裡面 </summary>
        [TestMethod()]

        public void TestIsCheck()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.IsCheck(ConstantWord.ZERO);
            _testModel.IsCheck(ConstantWord.ONE);
        }

        /// <summary> Test 判斷我的亂數是否有跟list裡面重複 </summary>
        [TestMethod()]

        public void TestIsSomeWord()
        {
            _testModel.IsSomeWord(ConstantWord.ZERO);
        }

        /// <summary> Test 製造一個問題 </summary>
        [TestMethod()]

        public void TestMakeQuestion()
        {
            _testModel.SetChangeQuestionNumber(ConstantWord.FIVE);
            _testModel.MakeQuestion();
        }

        /// <summary> Test 讀取我的題目產生出亂數 </summary>
        [TestMethod()]

        public void TestReadTextTopic()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _targetOne = new PrivateObject(_testModel);
            _targetOne.SetFieldOrProperty(ConstantWord.BE_QUESTION_NUMBER, ConstantWord.TWO);
            _testModel.ReadTextTopic(ConstantWord.ZERO);
        }

        /// <summary> 設定範圍讓testmodel知道  </summary>
        [TestMethod()]

        public void TestSetQuestionNumericUpDown()
        {
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.SetQuestionNumericUpDown(ConstantWord.ONE);
            Assert.AreEqual(_testModel.GetChangeQuestionNumber(), ConstantWord.ONE);
        }

        /// <summary> 初始化  </summary>
        [TestMethod()]

        public void TestTestModel()
        {
        }

        /// <summary> 初始化  </summary>
        [TestMethod()]

        public void TestCheckAnswer()
        {
            Word word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _testModel.SetGetIndex = 0;
            _dictionaryModel = new DictionaryModel();
            _testModel = new TestModel(_dictionaryModel);
            _testModel.SetQuestionList(word);
            _testModel.SetGetIndex = ConstantWord.ZERO;
            _testModel.GetQuestion();
            _testModel.CheckAnswer(ConstantWord.CHINESE_ABLE, ConstantWord.CHINESE_ABLE);
            _testModel.CheckAnswer(ConstantWord.CHINESE_ABLE, ConstantWord.CHINESE_ABOUT);
        }
    }
}