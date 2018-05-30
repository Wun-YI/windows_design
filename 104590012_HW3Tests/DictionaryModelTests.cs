using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EnglishTest.Tests
{
    [TestClass()]
    public class DictionaryModelTests
    {
        
        DictionaryModel _dictionaryModel = new DictionaryModel();

        /// <summary> 測試抓第幾個單字是否正確 </summary>

        [TestMethod()]
        public void TestGetElementAt()
        {
            DictionaryModel file = new DictionaryModel();
            List<Word> data = new List<Word>();
            data = file.ReadFile(ConstantWord.TEST_ONE);
            Assert.AreEqual(file.GetElementAt(ConstantWord.ZERO).GetEnglish(), ConstantWord.TEST_ENGLISH_1);
            Assert.AreEqual(file.GetElementAt(ConstantWord.ZERO).GetChinese(), ConstantWord.TEST_CHINESE_1);
            Assert.AreEqual(file.GetElementAt(ConstantWord.FIVE).GetEnglish(), ConstantWord.TEST_ENGLISH_2);
            Assert.AreEqual(file.GetElementAt(ConstantWord.FIVE).GetChinese(), ConstantWord.TEST_CHINESE_2);
        }

        /// <summary> 測試WordList長度是否正確 </summary>
        [TestMethod()]

        public void TestGetWordListLength()
        {
            DictionaryModel file = new DictionaryModel();
            List<Word> data = new List<Word>();
            data = file.ReadFile(ConstantWord.TEST_ONE);
            Assert.AreEqual(data.Count, ConstantWord.EIGHT);
        }

        /// <summary> 測試讀檔是否正確 </summary>
        [TestMethod()]

        public void TestReadFile()
        {
            List<Word> data1 = new List<Word>();
            DictionaryModel file1 = new DictionaryModel();
            data1 = file1.ReadFile(ConstantWord.TEST_ONE);
            Assert.AreEqual(data1[ConstantWord.ZERO].GetEnglish(), ConstantWord.TEST_ENGLISH_1);
            Assert.AreEqual(data1[ConstantWord.ZERO].GetChinese(), ConstantWord.TEST_CHINESE_1);
            Assert.AreEqual(data1[ConstantWord.FIVE].GetEnglish(), ConstantWord.TEST_ENGLISH_2);
            Assert.AreEqual(data1[ConstantWord.FIVE].GetChinese(), ConstantWord.TEST_CHINESE_2);
            DictionaryModel file2 = new DictionaryModel();
            List<Word> data2 = new List<Word>();
            data2 = file2.ReadFile(ConstantWord.TEST_TWO);
            Assert.AreEqual(data2.Count, ConstantWord.FIVE);
            DictionaryModel file3 = new DictionaryModel();
            List<Word> data3 = new List<Word>();
            data3 = file3.ReadFile(ConstantWord.TEST_THREE);
            Assert.AreEqual(data3.Count, ConstantWord.ZERO);
        }

        /// <summary> 測試切割單字是否正確 </summary>
        [TestMethod()]

        public void TestCutLine()
        {
            DictionaryModel file = new DictionaryModel();
            List<Word> data = new List<Word>();
            data = file.ReadFile(ConstantWord.TEST_ONE);
            Assert.AreEqual(data[ConstantWord.ZERO].GetEnglish(), ConstantWord.TEST_ENGLISH_1);
            Assert.AreEqual(data[ConstantWord.ZERO].GetChinese(), ConstantWord.TEST_CHINESE_1);
            Assert.AreEqual(data[ConstantWord.FIVE].GetEnglish(), ConstantWord.TEST_ENGLISH_2);
            Assert.AreEqual(data[ConstantWord.FIVE].GetChinese(), ConstantWord.TEST_CHINESE_2);
        }
    }
}