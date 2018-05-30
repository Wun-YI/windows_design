using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class UserForm : Form
    {
        private AboutCheckerModel _aboutCheckerModel = new AboutCheckerModel();
        private const string ALL_FILL_IN_THE_BLANK_QUESTIONS = "All fill in the blank questions";
        private const string ALL_MULTIPLE_CHOICE_QUESTIONS = "All multiple-choice questions";
        private const string PICK_UP_QUESTION_RANDOM = "Pick up questions randomly";
        private const int THREE = 3;
        private const string TOTAL = "Total ";
        private const int TWO = 2;
        private const string WORDS_IN_THE_DICTIONARY = " words in the dictionary";
        private List<ToolStripMenuItem> _isQuestionType = new List<ToolStripMenuItem>();
        private PresentationModel _presentationModel;
        const String SCORE = "Score:";

        // 初始化
        public UserForm(PresentationModel presentationModel)
        {
            this._presentationModel = presentationModel; // 讓userform可以知道presentationModel
            _presentationModel._messageEvent += new PresentationModel.MessageEventHandler(ShowMessage);
            InitializeComponent();
            _isQuestionType.Add(_allFillIn);
            _isQuestionType.Add(_all);
            _isQuestionType.Add(_pickUpQuestions);
            _isQuestionType[0].Checked = true;
            _questionNumericUpDown.Minimum = 1;
            _nextButton.Enabled = false; // 初始化next顯示灰色
            _nextToolStrip.Enabled = false;
            _stopButton.Enabled = false;
            _stopToolStrip.Enabled = false;
            _allFillIn.Checked = true;
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeComboBox.SelectedIndex = 0;
        }

        // 關於程式
        private void GoAboutSpellingCheckerClick(object sender, EventArgs e)
        {
            _aboutCheckerModel.Open();
        }

        // 顯示_allMultiplechoiceQuestionsToolStripMenuItem勾勾其餘false
        private void GoAll(object sender, EventArgs e)
        {
            ToolStripMenuItem type = sender as ToolStripMenuItem;
            _presentationModel.QuestionType = int.Parse(type.Tag.ToString());
            RefreshSelectType();
        }

        // 案exit，直接關閉視窗
        private void GoExitToolStripMenuItem(object sender, EventArgs e)
        {
            this.Close();
        }

        // 觸發next按鈕時
        private void GoNextButton(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _presentationModel.BeNext(_answerTextBox.Text, new bool[] { _selectRadioButton1.Checked, _selectRadioButton2.Checked, _selectRadioButton3.Checked, _selectRadioButton4.Checked }, new string[] { _selectRadioButton1.Text, _selectRadioButton2.Text, _selectRadioButton3.Text, _selectRadioButton4.Text });
            _presentationModel.GetQuestion();
            _scoreLabel.Text = SCORE + _presentationModel.GetScore();
            _vacancyGroupBox.Text = _presentationModel.GetDisplayGroupBoxText();
            _selectGroupBox.Text = _presentationModel.GetDisplayGroupBoxText();
            RefreshScreen();
            RefreshScreenButton();
            RefreshButtonHeight();
        }

        // 讓上面的next連接到按鈕的next
        private void GoNextToolStripClick(object sender, EventArgs e)
        {
            GoNextButton(sender, e);
        }

        /// _questionsToolStripMenuItem直接讓視窗直接變成10題
        private void GoQuestionsToolStripMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem type = sender as ToolStripMenuItem;
            _questionNumericUpDown.Value = int.Parse(type.Tag.ToString());
        }

        // 顯示出我字典內有多少單字
        private void LookAboutDictionaryClick(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(TOTAL + _presentationModel.GetFileWords().ToString() + WORDS_IN_THE_DICTIONARY);
        }

        // 更改視窗大小
        private void RefreshButtonHeight()
        {
            int formHeight = 140;
            foreach (Control ControlElement in _tableLayoutPanel1.Controls)
                formHeight += !(ControlElement is Button) && ControlElement.Visible ? ControlElement.DisplayRectangle.Height : 0;

            this.Size = new Size(this.Size.Width, formHeight);
        }

        // 重整我的button高度
        // 重整畫面
        private void RefreshScreen()
        {
            _selectGroupBox.Visible = _presentationModel.IsSelect();
            _vacancyGroupBox.Visible = _presentationModel.IsVacancy();
            _topic.Text = _presentationModel.GetTopic();
            _selectLabel.Text = _presentationModel.GetTopic();
            _message.Text = _presentationModel.GetDisplayMessage();
            _startButton.Enabled = _presentationModel.IsStartEnabled();
            _startToolStrip.Enabled = _presentationModel.IsStartEnabled();
            _nextButton.Enabled = _presentationModel.IsReverseStartEnabled();
            _nextToolStrip.Enabled = _presentationModel.IsReverseStartEnabled();
            _examinationGroupBox.Visible = _presentationModel.IsStartEnabled();
            _stopToolStrip.Enabled = _presentationModel.IsReverseStartEnabled();
            _stopButton.Enabled = _presentationModel.IsReverseStartEnabled();
            _numberOfQuestions.Enabled = _presentationModel.IsStartEnabled();
            _questionType.Enabled = _presentationModel.IsStartEnabled();
            _answerTextBox.Text = "";
        }

        // 重整按鈕的效果
        private void RefreshScreenButton()
        {
            _timer.Enabled = !_presentationModel.IsStartEnabled();
            _selectRadioButton1.Text = _presentationModel.GetOptionTopic()[0];
            _selectRadioButton2.Text = _presentationModel.GetOptionTopic()[1];
            _selectRadioButton3.Text = _presentationModel.GetOptionTopic()[TWO];
            _selectRadioButton4.Text = _presentationModel.GetOptionTopic()[THREE];
            _selectRadioButton1.Checked = false;
            _selectRadioButton2.Checked = false;
            _selectRadioButton3.Checked = false;
            _selectRadioButton4.Checked = false;
        }

        // 重新刷新type的選項讓PM知道
        private void RefreshSelectType()
        {
            _isQuestionType[0].Checked = false;
            _isQuestionType[1].Checked = false;
            _isQuestionType[TWO].Checked = false;
            _isQuestionType[_presentationModel.QuestionType].Checked = true;
            _typeComboBox.SelectedIndex = _presentationModel.QuestionType;
        }

        // 傳入
        private void SetQuestionNumericUpDown()
        {
            _presentationModel.SetRangeQuestionNumericUpDown(Convert.ToInt32(_questionNumericUpDown.Value));
        }

        // shoe訊息
        private void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        // Start按鈕發生事件時
        private void StartButtonClick(object sender, EventArgs e)
        {
            SetQuestionNumericUpDown();
            _presentationModel.Start(_typeComboBox.SelectedIndex);
            _vacancyGroupBox.Text = _presentationModel.GetDisplayGroupBoxText();
            _selectGroupBox.Text = _presentationModel.GetDisplayGroupBoxText();
            RefreshScreen();
            RefreshScreenButton();
            RefreshButtonHeight();
        }

        // 讓上面的 Start連接到按鈕的 Start
        private void StartToolStripClick(object sender, EventArgs e)
        {
            StartButtonClick(sender, e);
        }

        // 結算到當前題目的數量
        private void StopButton(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _presentationModel.GetStop();
            RefreshScreen();
            RefreshScreenButton();
            RefreshButtonHeight();
        }

        // 讓上面的Stop連接到按鈕的Stop
        private void StopToolStripClick(object sender, EventArgs e)
        {
            StopButton(sender, e);
        }

        // 選擇type可以讓PM知道
        private void TypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int type = _typeComboBox.SelectedIndex;
            _presentationModel.QuestionType = type;
            RefreshSelectType();
        }

        //時間
        private void Tick(object sender, EventArgs e)
        {
            this._presentationModel.TickTimerSecond();
            _timeLabel.Text = _presentationModel.GetTime();
            _timeBar.Value = _presentationModel.GetSetAnswerTime * 10;
            _scoreLabel.Text = SCORE + _presentationModel.GetScore();
        }
    }
}