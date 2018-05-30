using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnglishTest.Tests
{
    [TestClass()]

    public class WordTests
    {

        /// <summary> 測試建構子 </summary>
        [TestMethod()]

        public void TestWord()
        {
            Word testWord = new Word(ConstantWord.TEST_CHINESE, ConstantWord.TEST_ENGLISH);
            Assert.AreEqual(testWord.GetEnglish(), ConstantWord.ENGLISH);
            Assert.AreEqual(testWord.GetChinese(), ConstantWord.CHINESE);
        }
        /// <summary> 測試中文是否正確 </summary>
        [TestMethod()]

        public void TestGetChinese()
        {
            Word testWord = new Word(ConstantWord.TEST_CHINESE, ConstantWord.TEST_ENGLISH);
            Assert.AreEqual(testWord.GetChinese(), ConstantWord.CHINESE);
        }
        /// <summary> 測試英文是否正確 </summary>

        [TestMethod()]

        public void TestGetEnglish()
        {
            Word testWord = new Word(ConstantWord.TEST_CHINESE, ConstantWord.TEST_ENGLISH);
            Assert.AreEqual(testWord.GetEnglish(), ConstantWord.ENGLISH);
        }
        /// <summary> 測試切割文字是否正確 </summary>
        [TestMethod()]

        public void TestGetLength()
        {
            Word testWordOne = new Word(ConstantWord.CHINESE_ONE, ConstantWord.ENGLISH_ONE);
            Assert.AreEqual(testWordOne.GetLength(), ConstantWord.ANSWER_ONE);
            Word testWordTwo = new Word(ConstantWord.CHINESE_TWO, ConstantWord.ENGLISH_TWO);
            Assert.AreEqual(testWordTwo.GetLength(), ConstantWord.ANSWER_TWO);
        }
    }
}