namespace EnglishTest
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this._messageWord = new System.Windows.Forms.ToolStripStatusLabel();
            this._message = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._vacancyGroupBox = new System.Windows.Forms.GroupBox();
            this._vacancyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._englishLabel = new System.Windows.Forms.Label();
            this._chineseLabel = new System.Windows.Forms.Label();
            this._answerTextBox = new System.Windows.Forms.TextBox();
            this._topic = new System.Windows.Forms.Label();
            this._startButton = new System.Windows.Forms.Button();
            this._selectGroupBox = new System.Windows.Forms.GroupBox();
            this._selectTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._selectLabel = new System.Windows.Forms.Label();
            this._selectRadioButton4 = new System.Windows.Forms.RadioButton();
            this._selectRadioButton1 = new System.Windows.Forms.RadioButton();
            this._selectRadioButton3 = new System.Windows.Forms.RadioButton();
            this._selectRadioButton2 = new System.Windows.Forms.RadioButton();
            this._nextButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._examinationGroupBox = new System.Windows.Forms.GroupBox();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._questionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._typeLabel = new System.Windows.Forms.Label();
            this._questionsLabel = new System.Windows.Forms.Label();
            this._buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._stopButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._timeLabel = new System.Windows.Forms.Label();
            this._scoreLabel = new System.Windows.Forms.Label();
            this._timeBar = new System.Windows.Forms.ProgressBar();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._examination = new System.Windows.Forms.ToolStripMenuItem();
            this._startToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._nextToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._stopToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._numberOfQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripTen = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripTwenty = new System.Windows.Forms.ToolStripMenuItem();
            this._questionsToolStripFifty = new System.Windows.Forms.ToolStripMenuItem();
            this._questionType = new System.Windows.Forms.ToolStripMenuItem();
            this._allFillIn = new System.Windows.Forms.ToolStripMenuItem();
            this._all = new System.Windows.Forms.ToolStripMenuItem();
            this._pickUpQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutSpellingChecker = new System.Windows.Forms.ToolStripMenuItem();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._statusStrip.SuspendLayout();
            this._vacancyGroupBox.SuspendLayout();
            this._vacancyTableLayoutPanel.SuspendLayout();
            this._selectGroupBox.SuspendLayout();
            this._selectTableLayoutPanel.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            this._examinationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._questionNumericUpDown)).BeginInit();
            this._buttonTableLayoutPanel.SuspendLayout();
            this._tableLayoutPanel4.SuspendLayout();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _messageWord
            // 
            this._messageWord.Name = "_messageWord";
            this._messageWord.Size = new System.Drawing.Size(0, 17);
            // 
            // _message
            // 
            this._message.Name = "_message";
            this._message.Size = new System.Drawing.Size(0, 17);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._messageWord,
            this._message});
            this._statusStrip.Location = new System.Drawing.Point(0, 546);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(385, 22);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _vacancyGroupBox
            // 
            this._vacancyGroupBox.Controls.Add(this._vacancyTableLayoutPanel);
            this._vacancyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._vacancyGroupBox.Location = new System.Drawing.Point(3, 120);
            this._vacancyGroupBox.Name = "_vacancyGroupBox";
            this._vacancyGroupBox.Size = new System.Drawing.Size(379, 102);
            this._vacancyGroupBox.TabIndex = 5;
            this._vacancyGroupBox.TabStop = false;
            // 
            // _vacancyTableLayoutPanel
            // 
            this._vacancyTableLayoutPanel.ColumnCount = 2;
            this._vacancyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._vacancyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this._vacancyTableLayoutPanel.Controls.Add(this._englishLabel, 0, 1);
            this._vacancyTableLayoutPanel.Controls.Add(this._chineseLabel, 0, 0);
            this._vacancyTableLayoutPanel.Controls.Add(this._answerTextBox, 1, 1);
            this._vacancyTableLayoutPanel.Controls.Add(this._topic, 1, 0);
            this._vacancyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._vacancyTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._vacancyTableLayoutPanel.Name = "_vacancyTableLayoutPanel";
            this._vacancyTableLayoutPanel.RowCount = 2;
            this._vacancyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._vacancyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._vacancyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._vacancyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._vacancyTableLayoutPanel.Size = new System.Drawing.Size(373, 81);
            this._vacancyTableLayoutPanel.TabIndex = 6;
            // 
            // _englishLabel
            // 
            this._englishLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._englishLabel.AutoSize = true;
            this._englishLabel.Location = new System.Drawing.Point(43, 54);
            this._englishLabel.Name = "_englishLabel";
            this._englishLabel.Size = new System.Drawing.Size(43, 12);
            this._englishLabel.TabIndex = 1;
            this._englishLabel.Text = "English:";
            // 
            // _chineseLabel
            // 
            this._chineseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._chineseLabel.AutoSize = true;
            this._chineseLabel.Location = new System.Drawing.Point(42, 14);
            this._chineseLabel.Name = "_chineseLabel";
            this._chineseLabel.Size = new System.Drawing.Size(45, 12);
            this._chineseLabel.TabIndex = 0;
            this._chineseLabel.Text = "Chinese:";
            // 
            // _answerTextBox
            // 
            this._answerTextBox.AccessibleName = "EnglishInput";
            this._answerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._answerTextBox.Location = new System.Drawing.Point(133, 49);
            this._answerTextBox.Name = "_answerTextBox";
            this._answerTextBox.Size = new System.Drawing.Size(233, 22);
            this._answerTextBox.TabIndex = 4;
            // 
            // _topic
            // 
            this._topic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._topic.AutoSize = true;
            this._topic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._topic.Location = new System.Drawing.Point(133, 14);
            this._topic.Name = "_topic";
            this._topic.Size = new System.Drawing.Size(0, 12);
            this._topic.TabIndex = 5;
            this._topic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _startButton
            // 
            this._startButton.Location = new System.Drawing.Point(3, 3);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(119, 35);
            this._startButton.TabIndex = 2;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // _selectGroupBox
            // 
            this._selectGroupBox.Controls.Add(this._selectTableLayoutPanel);
            this._selectGroupBox.Location = new System.Drawing.Point(3, 228);
            this._selectGroupBox.Name = "_selectGroupBox";
            this._selectGroupBox.Size = new System.Drawing.Size(379, 150);
            this._selectGroupBox.TabIndex = 5;
            this._selectGroupBox.TabStop = false;
            // 
            // _selectTableLayoutPanel
            // 
            this._selectTableLayoutPanel.ColumnCount = 1;
            this._selectTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._selectTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._selectTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._selectTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._selectTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._selectTableLayoutPanel.Controls.Add(this._selectLabel, 0, 0);
            this._selectTableLayoutPanel.Controls.Add(this._selectRadioButton4, 0, 4);
            this._selectTableLayoutPanel.Controls.Add(this._selectRadioButton1, 0, 1);
            this._selectTableLayoutPanel.Controls.Add(this._selectRadioButton3, 0, 3);
            this._selectTableLayoutPanel.Controls.Add(this._selectRadioButton2, 0, 2);
            this._selectTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._selectTableLayoutPanel.Name = "_selectTableLayoutPanel";
            this._selectTableLayoutPanel.RowCount = 5;
            this._selectTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._selectTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._selectTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._selectTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._selectTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._selectTableLayoutPanel.Size = new System.Drawing.Size(373, 132);
            this._selectTableLayoutPanel.TabIndex = 6;
            // 
            // _selectLabel
            // 
            this._selectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectLabel.AutoSize = true;
            this._selectLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._selectLabel.Location = new System.Drawing.Point(3, 7);
            this._selectLabel.Name = "_selectLabel";
            this._selectLabel.Size = new System.Drawing.Size(0, 12);
            this._selectLabel.TabIndex = 0;
            this._selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _selectRadioButton4
            // 
            this._selectRadioButton4.AccessibleName = "RadioButton4";
            this._selectRadioButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectRadioButton4.AutoSize = true;
            this._selectRadioButton4.Location = new System.Drawing.Point(3, 111);
            this._selectRadioButton4.Name = "_selectRadioButton4";
            this._selectRadioButton4.Size = new System.Drawing.Size(14, 13);
            this._selectRadioButton4.TabIndex = 4;
            this._selectRadioButton4.TabStop = true;
            this._selectRadioButton4.UseVisualStyleBackColor = true;
            // 
            // _selectRadioButton1
            // 
            this._selectRadioButton1.AccessibleName = "RadioButton1";
            this._selectRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectRadioButton1.AutoSize = true;
            this._selectRadioButton1.Location = new System.Drawing.Point(3, 32);
            this._selectRadioButton1.Name = "_selectRadioButton1";
            this._selectRadioButton1.Size = new System.Drawing.Size(14, 13);
            this._selectRadioButton1.TabIndex = 1;
            this._selectRadioButton1.TabStop = true;
            this._selectRadioButton1.UseVisualStyleBackColor = true;
            // 
            // _selectRadioButton3
            // 
            this._selectRadioButton3.AccessibleName = "RadioButton3";
            this._selectRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectRadioButton3.AutoSize = true;
            this._selectRadioButton3.Location = new System.Drawing.Point(3, 84);
            this._selectRadioButton3.Name = "_selectRadioButton3";
            this._selectRadioButton3.Size = new System.Drawing.Size(14, 13);
            this._selectRadioButton3.TabIndex = 3;
            this._selectRadioButton3.TabStop = true;
            this._selectRadioButton3.UseVisualStyleBackColor = true;
            // 
            // _selectRadioButton2
            // 
            this._selectRadioButton2.AccessibleName = "RadioButton2";
            this._selectRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._selectRadioButton2.AutoSize = true;
            this._selectRadioButton2.Location = new System.Drawing.Point(3, 58);
            this._selectRadioButton2.Name = "_selectRadioButton2";
            this._selectRadioButton2.Size = new System.Drawing.Size(14, 13);
            this._selectRadioButton2.TabIndex = 2;
            this._selectRadioButton2.TabStop = true;
            this._selectRadioButton2.UseVisualStyleBackColor = true;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(128, 3);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(119, 35);
            this._nextButton.TabIndex = 3;
            this._nextButton.Text = "Next";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.GoNextButton);
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 1;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel1.Controls.Add(this._examinationGroupBox, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._buttonTableLayoutPanel, 0, 3);
            this._tableLayoutPanel1.Controls.Add(this._vacancyGroupBox, 0, 1);
            this._tableLayoutPanel1.Controls.Add(this._selectGroupBox, 0, 2);
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel4, 0, 5);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 6;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(385, 522);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _examinationGroupBox
            // 
            this._examinationGroupBox.Controls.Add(this._typeComboBox);
            this._examinationGroupBox.Controls.Add(this._questionNumericUpDown);
            this._examinationGroupBox.Controls.Add(this._typeLabel);
            this._examinationGroupBox.Controls.Add(this._questionsLabel);
            this._examinationGroupBox.Location = new System.Drawing.Point(3, 3);
            this._examinationGroupBox.Name = "_examinationGroupBox";
            this._examinationGroupBox.Size = new System.Drawing.Size(374, 111);
            this._examinationGroupBox.TabIndex = 7;
            this._examinationGroupBox.TabStop = false;
            this._examinationGroupBox.Text = "Customize Your Examination";
            // 
            // _typeComboBox
            // 
            this._typeComboBox.AccessibleName = "QuestionType";
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Items.AddRange(new object[] {
            "All fill in the blank questions",
            "All multiple-choice questions",
            "Pick up questions randomly"});
            this._typeComboBox.Location = new System.Drawing.Point(169, 67);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(169, 20);
            this._typeComboBox.TabIndex = 3;
            this._typeComboBox.TabStop = false;
            this._typeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBoxSelectedIndexChanged);
            // 
            // _questionNumericUpDown
            // 
            this._questionNumericUpDown.AccessibleName = "SetNumberOfQuestions";
            this._questionNumericUpDown.Location = new System.Drawing.Point(170, 25);
            this._questionNumericUpDown.Name = "_questionNumericUpDown";
            this._questionNumericUpDown.Size = new System.Drawing.Size(168, 22);
            this._questionNumericUpDown.TabIndex = 2;
            this._questionNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _typeLabel
            // 
            this._typeLabel.AutoSize = true;
            this._typeLabel.Location = new System.Drawing.Point(61, 75);
            this._typeLabel.Name = "_typeLabel";
            this._typeLabel.Size = new System.Drawing.Size(73, 12);
            this._typeLabel.TabIndex = 1;
            this._typeLabel.Text = "Question Type";
            // 
            // _questionsLabel
            // 
            this._questionsLabel.AutoSize = true;
            this._questionsLabel.Location = new System.Drawing.Point(30, 35);
            this._questionsLabel.Name = "_questionsLabel";
            this._questionsLabel.Size = new System.Drawing.Size(104, 12);
            this._questionsLabel.TabIndex = 0;
            this._questionsLabel.Text = "Number of Questions";
            // 
            // _buttonTableLayoutPanel
            // 
            this._buttonTableLayoutPanel.ColumnCount = 3;
            this._buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._buttonTableLayoutPanel.Controls.Add(this._startButton, 0, 0);
            this._buttonTableLayoutPanel.Controls.Add(this._nextButton, 1, 0);
            this._buttonTableLayoutPanel.Controls.Add(this._stopButton, 2, 0);
            this._buttonTableLayoutPanel.Location = new System.Drawing.Point(3, 384);
            this._buttonTableLayoutPanel.Name = "_buttonTableLayoutPanel";
            this._buttonTableLayoutPanel.RowCount = 1;
            this._buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this._buttonTableLayoutPanel.Size = new System.Drawing.Size(377, 47);
            this._buttonTableLayoutPanel.TabIndex = 6;
            // 
            // _stopButton
            // 
            this._stopButton.Location = new System.Drawing.Point(253, 3);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(121, 35);
            this._stopButton.TabIndex = 4;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.StopButton);
            // 
            // _tableLayoutPanel4
            // 
            this._tableLayoutPanel4.ColumnCount = 3;
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.8153F));
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05013F));
            this._tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87071F));
            this._tableLayoutPanel4.Controls.Add(this._timeLabel, 0, 0);
            this._tableLayoutPanel4.Controls.Add(this._scoreLabel, 2, 0);
            this._tableLayoutPanel4.Controls.Add(this._timeBar, 1, 0);
            this._tableLayoutPanel4.Location = new System.Drawing.Point(3, 437);
            this._tableLayoutPanel4.Name = "_tableLayoutPanel4";
            this._tableLayoutPanel4.RowCount = 1;
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this._tableLayoutPanel4.Size = new System.Drawing.Size(379, 41);
            this._tableLayoutPanel4.TabIndex = 8;
            // 
            // _timeLabel
            // 
            this._timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._timeLabel.AutoSize = true;
            this._timeLabel.Location = new System.Drawing.Point(33, 12);
            this._timeLabel.Name = "_timeLabel";
            this._timeLabel.Size = new System.Drawing.Size(46, 17);
            this._timeLabel.TabIndex = 0;
            this._timeLabel.Text = "00:00:00";
            this._timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._timeLabel.UseCompatibleTextRendering = true;
            // 
            // _scoreLabel
            // 
            this._scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._scoreLabel.AutoSize = true;
            this._scoreLabel.Location = new System.Drawing.Point(300, 14);
            this._scoreLabel.Name = "_scoreLabel";
            this._scoreLabel.Size = new System.Drawing.Size(40, 12);
            this._scoreLabel.TabIndex = 1;
            this._scoreLabel.Text = "Score:0";
            // 
            // _timeBar
            // 
            this._timeBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._timeBar.ForeColor = System.Drawing.Color.Salmon;
            this._timeBar.Location = new System.Drawing.Point(132, 9);
            this._timeBar.Name = "_timeBar";
            this._timeBar.Size = new System.Drawing.Size(109, 23);
            this._timeBar.Step = 5;
            this._timeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._timeBar.TabIndex = 14;
            this._timeBar.Value = 100;
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStrip,
            this._examination,
            this._helpToolStrip});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(385, 24);
            this._menuStrip.TabIndex = 2;
            this._menuStrip.Text = "_menuStrip";
            // 
            // _fileToolStrip
            // 
            this._fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStrip});
            this._fileToolStrip.Name = "_fileToolStrip";
            this._fileToolStrip.Size = new System.Drawing.Size(38, 20);
            this._fileToolStrip.Text = "&File";
            // 
            // _exitToolStrip
            // 
            this._exitToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_exitToolStrip.Image")));
            this._exitToolStrip.Name = "_exitToolStrip";
            this._exitToolStrip.Size = new System.Drawing.Size(94, 22);
            this._exitToolStrip.Text = "&Exit";
            this._exitToolStrip.Click += new System.EventHandler(this.GoExitToolStripMenuItem);
            // 
            // _examination
            // 
            this._examination.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._startToolStrip,
            this._nextToolStrip,
            this._stopToolStrip,
            this._toolStripMenuItem1,
            this._numberOfQuestions,
            this._questionType});
            this._examination.Name = "_examination";
            this._examination.Size = new System.Drawing.Size(89, 20);
            this._examination.Text = "&Examination";
            // 
            // _startToolStrip
            // 
            this._startToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_startToolStrip.Image")));
            this._startToolStrip.Name = "_startToolStrip";
            this._startToolStrip.Size = new System.Drawing.Size(195, 22);
            this._startToolStrip.Text = "&Start";
            this._startToolStrip.Click += new System.EventHandler(this.StartToolStripClick);
            // 
            // _nextToolStrip
            // 
            this._nextToolStrip.Name = "_nextToolStrip";
            this._nextToolStrip.Size = new System.Drawing.Size(195, 22);
            this._nextToolStrip.Text = "&Next";
            this._nextToolStrip.Click += new System.EventHandler(this.GoNextToolStripClick);
            // 
            // _stopToolStrip
            // 
            this._stopToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("_stopToolStrip.Image")));
            this._stopToolStrip.Name = "_stopToolStrip";
            this._stopToolStrip.Size = new System.Drawing.Size(195, 22);
            this._stopToolStrip.Text = "S&top";
            this._stopToolStrip.Click += new System.EventHandler(this.StopToolStripClick);
            // 
            // _toolStripMenuItem1
            // 
            this._toolStripMenuItem1.Name = "_toolStripMenuItem1";
            this._toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // _numberOfQuestions
            // 
            this._numberOfQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._questionsToolStripTen,
            this._questionsToolStripTwenty,
            this._questionsToolStripFifty});
            this._numberOfQuestions.Name = "_numberOfQuestions";
            this._numberOfQuestions.Size = new System.Drawing.Size(195, 22);
            this._numberOfQuestions.Text = "N&umber of Questions";
            // 
            // _questionsToolStripTen
            // 
            this._questionsToolStripTen.Name = "_questionsToolStripTen";
            this._questionsToolStripTen.Size = new System.Drawing.Size(152, 22);
            this._questionsToolStripTen.Tag = "10";
            this._questionsToolStripTen.Text = "&10 Questions";
            this._questionsToolStripTen.Click += new System.EventHandler(this.GoQuestionsToolStripMenuItem);
            // 
            // _questionsToolStripTwenty
            // 
            this._questionsToolStripTwenty.Name = "_questionsToolStripTwenty";
            this._questionsToolStripTwenty.Size = new System.Drawing.Size(152, 22);
            this._questionsToolStripTwenty.Tag = "20";
            this._questionsToolStripTwenty.Text = "&20 Questions";
            this._questionsToolStripTwenty.Click += new System.EventHandler(this.GoQuestionsToolStripMenuItem);
            // 
            // _questionsToolStripFifty
            // 
            this._questionsToolStripFifty.Name = "_questionsToolStripFifty";
            this._questionsToolStripFifty.Size = new System.Drawing.Size(152, 22);
            this._questionsToolStripFifty.Tag = "50";
            this._questionsToolStripFifty.Text = "&50 Questions";
            this._questionsToolStripFifty.Click += new System.EventHandler(this.GoQuestionsToolStripMenuItem);
            // 
            // _questionType
            // 
            this._questionType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._allFillIn,
            this._all,
            this._pickUpQuestions});
            this._questionType.Name = "_questionType";
            this._questionType.Size = new System.Drawing.Size(195, 22);
            this._questionType.Text = "&Question Type";
            // 
            // _allFillIn
            // 
            this._allFillIn.Name = "_allFillIn";
            this._allFillIn.Size = new System.Drawing.Size(236, 22);
            this._allFillIn.Tag = "0";
            this._allFillIn.Text = "Al&l fill in the blank questions";
            this._allFillIn.Click += new System.EventHandler(this.GoAll);
            // 
            // _all
            // 
            this._all.Name = "_all";
            this._all.Size = new System.Drawing.Size(236, 22);
            this._all.Tag = "1";
            this._all.Text = "All multiple-&choice questions";
            this._all.Click += new System.EventHandler(this.GoAll);
            // 
            // _pickUpQuestions
            // 
            this._pickUpQuestions.Name = "_pickUpQuestions";
            this._pickUpQuestions.Size = new System.Drawing.Size(236, 22);
            this._pickUpQuestions.Tag = "2";
            this._pickUpQuestions.Text = "Pick up questions &randomly";
            this._pickUpQuestions.Click += new System.EventHandler(this.GoAll);
            // 
            // _helpToolStrip
            // 
            this._helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutDictionary,
            this._aboutSpellingChecker});
            this._helpToolStrip.Name = "_helpToolStrip";
            this._helpToolStrip.Size = new System.Drawing.Size(46, 20);
            this._helpToolStrip.Text = "&Help";
            // 
            // _aboutDictionary
            // 
            this._aboutDictionary.Name = "_aboutDictionary";
            this._aboutDictionary.Size = new System.Drawing.Size(206, 22);
            this._aboutDictionary.Text = "&About Dictionary";
            this._aboutDictionary.Click += new System.EventHandler(this.LookAboutDictionaryClick);
            // 
            // _aboutSpellingChecker
            // 
            this._aboutSpellingChecker.Image = ((System.Drawing.Image)(resources.GetObject("_aboutSpellingChecker.Image")));
            this._aboutSpellingChecker.Name = "_aboutSpellingChecker";
            this._aboutSpellingChecker.Size = new System.Drawing.Size(206, 22);
            this._aboutSpellingChecker.Text = "About &Spelling Checker";
            this._aboutSpellingChecker.Click += new System.EventHandler(this.GoAboutSpellingCheckerClick);
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this.Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 568);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._menuStrip);
            this.Name = "UserForm";
            this.Text = "Spelling Checker 1000 Words";
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._vacancyGroupBox.ResumeLayout(false);
            this._vacancyTableLayoutPanel.ResumeLayout(false);
            this._vacancyTableLayoutPanel.PerformLayout();
            this._selectGroupBox.ResumeLayout(false);
            this._selectTableLayoutPanel.ResumeLayout(false);
            this._selectTableLayoutPanel.PerformLayout();
            this._tableLayoutPanel1.ResumeLayout(false);
            this._examinationGroupBox.ResumeLayout(false);
            this._examinationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._questionNumericUpDown)).EndInit();
            this._buttonTableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel4.ResumeLayout(false);
            this._tableLayoutPanel4.PerformLayout();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel _messageWord;
        private System.Windows.Forms.ToolStripStatusLabel _message;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.GroupBox _vacancyGroupBox;
        private System.Windows.Forms.TableLayoutPanel _vacancyTableLayoutPanel;
        private System.Windows.Forms.Label _englishLabel;
        private System.Windows.Forms.Label _chineseLabel;
        private System.Windows.Forms.TextBox _answerTextBox;
        private System.Windows.Forms.Label _topic;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.GroupBox _selectGroupBox;
        private System.Windows.Forms.TableLayoutPanel _selectTableLayoutPanel;
        private System.Windows.Forms.Label _selectLabel;
        private System.Windows.Forms.RadioButton _selectRadioButton4;
        private System.Windows.Forms.RadioButton _selectRadioButton1;
        private System.Windows.Forms.RadioButton _selectRadioButton3;
        private System.Windows.Forms.RadioButton _selectRadioButton2;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel _buttonTableLayoutPanel;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _examination;
        private System.Windows.Forms.ToolStripMenuItem _startToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _nextToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _stopToolStrip;
        private System.Windows.Forms.ToolStripSeparator _toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _numberOfQuestions;
        private System.Windows.Forms.ToolStripMenuItem _questionType;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStrip;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripTen;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripTwenty;
        private System.Windows.Forms.ToolStripMenuItem _questionsToolStripFifty;
        private System.Windows.Forms.ToolStripMenuItem _allFillIn;
        private System.Windows.Forms.ToolStripMenuItem _all;
        private System.Windows.Forms.ToolStripMenuItem _aboutDictionary;
        private System.Windows.Forms.ToolStripMenuItem _aboutSpellingChecker;
        private System.Windows.Forms.ToolStripMenuItem _pickUpQuestions;
        private System.Windows.Forms.GroupBox _examinationGroupBox;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.NumericUpDown _questionNumericUpDown;
        private System.Windows.Forms.Label _typeLabel;
        private System.Windows.Forms.Label _questionsLabel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel4;
        private System.Windows.Forms.Label _timeLabel;
        private System.Windows.Forms.Label _scoreLabel;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.ProgressBar _timeBar;
    }
}