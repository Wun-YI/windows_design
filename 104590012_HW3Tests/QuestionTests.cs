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
    public class QuestionTests
    {
        private List<string> _option = new List<string>();
        Word _word;
        DictionaryModel _dictionaryModel;
        Question _question;

        /// <summary> 測試建構子</summary>
        [TestMethod()]
        public void TestQuestion()
        {
        }
        /// <summary> 創造問題 </summary>
        [TestMethod()]

        public void TestCreateQueen()
        {
            _dictionaryModel = new DictionaryModel();
            _word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _dictionaryModel = new DictionaryModel();
            _dictionaryModel.ReadFile(ConstantWord.ENGLISH_WORD);
            _question = new Question(_word, _dictionaryModel);
            _question.SetTypeNumber(ConstantWord.ZERO);
            int temp = _question.CreateQueen();
            Assert.AreEqual(temp, ConstantWord.ZERO);
            _question.SetTypeNumber(ConstantWord.ONE);
            temp = _question.CreateQueen();
            Assert.AreEqual(temp, ConstantWord.ONE);
            _question.SetTypeNumber(ConstantWord.TWO);
            temp = _question.CreateQueen();
            Assert.AreEqual(temp, ConstantWord.TWO);
            _question.SetTypeNumber(ConstantWord.THREE);
            temp = _question.CreateQueen();
            Assert.AreEqual(temp, ConstantWord.THREE);
        }

        /// <summary> 取得我的答案 </summary>
        [TestMethod()]

        public void TestGetAnswer()
        {
            _question = new Question(_word, _dictionaryModel);
            _question.GetAnswer();
        }

        /// <summary> test 選項 </summary>
        [TestMethod()]

        public void TestGetOption()
        {
            _question = new Question(_word, _dictionaryModel);
            _question.GetOption();
        }
        /// <summary> test 取得亂數是是非題還是選擇題 </summary>
        [TestMethod()]

        public void TestGetRandomVacancySelect()
        {
            _question = new Question(_word, _dictionaryModel);
            _question.GetRandomVacancySelect();
        }
        /// <summary> test 抓題目 </summary>
        [TestMethod()]

        public void TestGetTopic()
        {
            _question = new Question(_word, _dictionaryModel);
            _question.GetTopic();
        }

        /// <summary> 創造填空題或是選擇題 </summary>
        [TestMethod()]

        public void TestCreateQueenOption()
        {
            _dictionaryModel = new DictionaryModel();
            _word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _dictionaryModel = new DictionaryModel();
            _dictionaryModel.ReadFile(ConstantWord.ENGLISH_WORD);
            _question = new Question(_word, _dictionaryModel);
            int temp = _question.CreateQueenOption(ConstantWord.ZERO);
            Assert.AreEqual(temp, ConstantWord.ZERO);
            temp = _question.CreateQueenOption(ConstantWord.ONE);
            Assert.AreEqual(temp, ConstantWord.ONE);
            temp = _question.CreateQueenOption(ConstantWord.TWO);
            Assert.AreEqual(temp, ConstantWord.TWO);
        }

        // <summary> 判斷陣列是否有重複 </summary>
        [TestMethod()]

        public void TestIsSomeWord()
        {
            _dictionaryModel = new DictionaryModel();
            _word = new Word(ConstantWord.CHINESE, ConstantWord.ENGLISH);
            _dictionaryModel = new DictionaryModel();
            _dictionaryModel.ReadFile(ConstantWord.ENGLISH_WORD);
            _question = new Question(_word, _dictionaryModel);
            _question.SetOptionList();
            _question.IsSomeWord(ConstantWord.ZERO, ConstantWord.CHINESE_A);
            _question.SetOptionList();
            _question.IsSomeWord(ConstantWord.ZERO, ConstantWord.CHINESE_AGAIN);
        }
    }
}