
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

namespace EnglishTest.Tests
{
    /// <summary>
    /// CodedUITest1 的摘要描述
    /// </summary>
    [CodedUITest]

    public class CodedUITest1
    {
        const string PATH = "104590012_HW2.exe";
        const string WINDOW_NAME = "Spelling Checker 1000 Words";
        readonly string[] QuestionTypeNumber = { "All fill in the blank questions", "All multiple-choice questions", "Pick up questions randomly" };
        
        // 初始化
        [TestInitialize()]
     

        public void Initialize()
        {
            Robot.Initialize(PATH, WINDOW_NAME);
        }

        // 重整畫面
        [TestCleanup()]

        public void CleanUp()
        {
            Robot.CleanUp();
        }
        public CodedUITest1()
        {
        }

        // 測試start
        [TestMethod]

        public void StartTest()
        {
            Robot.ClickButton("Start");
            Robot.AssertButtonEnable("Start", false);
        }
        
        // 測試next
        [TestMethod]

        public void NextTest()
        {
            Robot.ClickButton("Start");
            Robot.ClickButton("Next");
            Robot.EnterTheKey("%en");
        }

        // 測試stop
        [TestMethod]

        public void StopTest()
        {
            Robot.ClickButton("Stop");
        }

        // 測試exit
        [TestMethod]

        public void ExitTest()
        {
            Robot.EnterTheKey("%fe");
        }

        // 測試meun help
        [TestMethod]

        public void MenuTest()
        {
            Robot.EnterTheKey("%ha");
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
        }

        // 測試關於程式
        [TestMethod]

        public void AboutSpeakChecker()
        {
            Robot.EnterTheKey("%hs");
            Robot.SetForm("About Spelling Checker");
            Robot.ClickHyperlink("CSIE");
            Robot.ClickHyperlink("NTUT");
            Robot.ClickButton("OK");
        }

        // 測試上面meun東西
        [TestMethod]

        public void ExaminationTest()
        {
            Robot.EnterTheKey("%es");
            Robot.EnterTheKey("%en");
            Robot.EnterTheKey("%et");
            Robot.EnterTheKey("%eu");
            Robot.EnterTheKey("%eu1");
            Robot.EnterTheKey("%eu2");
            Robot.EnterTheKey("%eu5");
            Robot.EnterTheKey("%eq");
            Robot.EnterTheKey("%eql");
            Robot.EnterTheKey("%eqc");
            Robot.EnterTheKey("%eqr");
        }

        // 測試出幾題
        [TestMethod]

        public void SetNumberOfQuestionsTest()
        {
            Robot.SetNumericUpDown("SetNumberOfQuestions", "2");
            Robot.SetNumericUpDown("SetNumberOfQuestions", "99");
        }

        // 測試填空題
        [TestMethod]

        public void FillTopicTest()
        {
            Robot.SetNumericUpDown("SetNumberOfQuestions", "1");
            SelectQuestionType(0);
            StartTest();
            Robot.SetEdit("EnglishInput", "testenglish");
            StopTest();
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
            StartTest();
        }

        // 選擇RadioButton
        private void SelectRadioButton()
        {
            Robot.ClickRadioButton("RadioButton1");
            Robot.ClickRadioButton("RadioButton2");
            Robot.ClickRadioButton("RadioButton3");
            Robot.ClickRadioButton("RadioButton4");
            NextTest();
        }

        // 測試選擇題
        [TestMethod]

        public void SelectTopicTest()
        {
            Robot.SetNumericUpDown("SetNumberOfQuestions", "5");
            SelectQuestionType(1);
            StartTest();
            SelectRadioButton();
        }

        // 選擇哪個題目type
        private void SelectQuestionType(int type)
        {
            Robot.SetComboBox("QuestionType", QuestionTypeNumber[type]);
        }

        // 測試題目和我本身答題數有沒有一樣
        [TestMethod]

        public void TopicNumberTest()
        {
            int counter = 0;
            Robot.SetNumericUpDown("SetNumberOfQuestions", "3");
            Robot.ClickButton("Start");
            while (counter < 3)
            {
                Robot.ClickButton("Next");
                counter++;
            }
            StopTest();
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
        }

        // 測試meun上面的題目數量
        [TestMethod]

        public void StopTopicTest()
        {
            Robot.EnterTheKey("%eu1");
            Robot.AssertNumericUpDown("SetNumberOfQuestions", "10");
            Robot.EnterTheKey("%eu2");
            Robot.AssertNumericUpDown("SetNumberOfQuestions", "20");
            Robot.EnterTheKey("%eu5");
            Robot.AssertNumericUpDown("SetNumberOfQuestions", "50");
            Robot.ClickButton("Start");
            Robot.ClickButton("Next");
            Robot.EnterTheKey("%et");
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
        }
        
        // 測試meun上面的題目type
        [TestMethod]

        public void StopTopicTypeTest()
        {
            Robot.EnterTheKey("%eql");
            Robot.AssertComboBox("QuestionType", QuestionTypeNumber[0]);
            Robot.EnterTheKey("%eqc");
            Robot.AssertComboBox("QuestionType", QuestionTypeNumber[1]);
            Robot.EnterTheKey("%eqr");
            Robot.AssertComboBox("QuestionType", QuestionTypeNumber[2]);
            Robot.ClickButton("Start");
            Robot.ClickButton("Next");
            Robot.EnterTheKey("%et");
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
        }

        // 測試meun上面的stop
        [TestMethod]

        public void StopMeunTopicTest()
        {
            Robot.SetNumericUpDown("SetNumberOfQuestions", "3");
            StartTest();
            Robot.ClickButton("Next");
            Robot.EnterTheKey("%et");
            Robot.AssertWindow(WINDOW_NAME);
            Robot.SendKeyEnterToMessageBox(WINDOW_NAME);
        }
        
    }
}
