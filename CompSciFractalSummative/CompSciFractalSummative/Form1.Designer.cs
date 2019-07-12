namespace CompSciFractalSummative
{
    partial class Form1
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
            this.fractalPictureBox = new System.Windows.Forms.PictureBox();
            this.rulesRadioButton1 = new System.Windows.Forms.RadioButton();
            this.rulesRadioButton2 = new System.Windows.Forms.RadioButton();
            this.rulesRadioButton3 = new System.Windows.Forms.RadioButton();
            this.ruleOneFromTextBox = new System.Windows.Forms.TextBox();
            this.ruleOneArrowLabel = new System.Windows.Forms.Label();
            this.ruleOneToTextBox = new System.Windows.Forms.TextBox();
            this.ruleTwoFromTextBox = new System.Windows.Forms.TextBox();
            this.ruleTwoToTextBox = new System.Windows.Forms.TextBox();
            this.ruleTwoArrowLabel = new System.Windows.Forms.Label();
            this.ruleThreeFromTextBox = new System.Windows.Forms.TextBox();
            this.ruleThreeArrowTextBox = new System.Windows.Forms.Label();
            this.ruleThreeToTextBox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.turnAngleLabel = new System.Windows.Forms.Label();
            this.turnAngleTextBox = new System.Windows.Forms.TextBox();
            this.axiomLabel = new System.Windows.Forms.Label();
            this.axiomTextBox = new System.Windows.Forms.TextBox();
            this.presetFractalComboBox = new System.Windows.Forms.ComboBox();
            this.sideLengthLabel = new System.Windows.Forms.Label();
            this.sideLengthTextBox = new System.Windows.Forms.TextBox();
            this.fractalXPosition = new System.Windows.Forms.Label();
            this.fractalYPosition = new System.Windows.Forms.Label();
            this.fractalXPositionTextbox = new System.Windows.Forms.TextBox();
            this.fractalYPositionTextbox = new System.Windows.Forms.TextBox();
            this.recurrsionDepthLabel = new System.Windows.Forms.Label();
            this.recurrsionDepthTextbox = new System.Windows.Forms.TextBox();
            this.gradientPickerColorDialog = new System.Windows.Forms.ColorDialog();
            this.gradientColourOneButton = new System.Windows.Forms.Button();
            this.gradientColourTwoButton = new System.Windows.Forms.Button();
            this.colourOneDisplayLabel = new System.Windows.Forms.Label();
            this.colourTwoDisplayLabel = new System.Windows.Forms.Label();
            this.numberOfRulesGroupBox = new System.Windows.Forms.GroupBox();
            this.startingInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.fractalPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleOneGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleTwoGroupBox = new System.Windows.Forms.GroupBox();
            this.ruleThreeGroupBox = new System.Windows.Forms.GroupBox();
            this.inputRulesGroupBox = new System.Windows.Forms.GroupBox();
            this.colourChooseGroupBox = new System.Windows.Forms.GroupBox();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).BeginInit();
            this.numberOfRulesGroupBox.SuspendLayout();
            this.startingInformationGroupBox.SuspendLayout();
            this.fractalPositionGroupBox.SuspendLayout();
            this.ruleOneGroupBox.SuspendLayout();
            this.ruleTwoGroupBox.SuspendLayout();
            this.ruleThreeGroupBox.SuspendLayout();
            this.inputRulesGroupBox.SuspendLayout();
            this.colourChooseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalPictureBox
            // 
            this.fractalPictureBox.BackColor = System.Drawing.Color.Black;
            this.fractalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fractalPictureBox.Name = "fractalPictureBox";
            this.fractalPictureBox.Size = new System.Drawing.Size(401, 401);
            this.fractalPictureBox.TabIndex = 0;
            this.fractalPictureBox.TabStop = false;
            this.fractalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalPictureBox_Paint);
            // 
            // rulesRadioButton1
            // 
            this.rulesRadioButton1.AutoSize = true;
            this.rulesRadioButton1.Location = new System.Drawing.Point(15, 19);
            this.rulesRadioButton1.Name = "rulesRadioButton1";
            this.rulesRadioButton1.Size = new System.Drawing.Size(56, 17);
            this.rulesRadioButton1.TabIndex = 1;
            this.rulesRadioButton1.TabStop = true;
            this.rulesRadioButton1.Text = "1 Rule";
            this.rulesRadioButton1.UseVisualStyleBackColor = true;
            this.rulesRadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rulesRadioButton2
            // 
            this.rulesRadioButton2.AutoSize = true;
            this.rulesRadioButton2.Location = new System.Drawing.Point(15, 42);
            this.rulesRadioButton2.Name = "rulesRadioButton2";
            this.rulesRadioButton2.Size = new System.Drawing.Size(61, 17);
            this.rulesRadioButton2.TabIndex = 2;
            this.rulesRadioButton2.TabStop = true;
            this.rulesRadioButton2.Text = "2 Rules";
            this.rulesRadioButton2.UseVisualStyleBackColor = true;
            this.rulesRadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rulesRadioButton3
            // 
            this.rulesRadioButton3.AutoSize = true;
            this.rulesRadioButton3.Location = new System.Drawing.Point(15, 65);
            this.rulesRadioButton3.Name = "rulesRadioButton3";
            this.rulesRadioButton3.Size = new System.Drawing.Size(61, 17);
            this.rulesRadioButton3.TabIndex = 3;
            this.rulesRadioButton3.TabStop = true;
            this.rulesRadioButton3.Text = "3 Rules";
            this.rulesRadioButton3.UseVisualStyleBackColor = true;
            this.rulesRadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // ruleOneFromTextBox
            // 
            this.ruleOneFromTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleOneFromTextBox.Location = new System.Drawing.Point(7, 20);
            this.ruleOneFromTextBox.MaxLength = 1;
            this.ruleOneFromTextBox.Name = "ruleOneFromTextBox";
            this.ruleOneFromTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleOneFromTextBox.TabIndex = 5;
            // 
            // ruleOneArrowLabel
            // 
            this.ruleOneArrowLabel.AutoSize = true;
            this.ruleOneArrowLabel.Location = new System.Drawing.Point(53, 23);
            this.ruleOneArrowLabel.Name = "ruleOneArrowLabel";
            this.ruleOneArrowLabel.Size = new System.Drawing.Size(16, 13);
            this.ruleOneArrowLabel.TabIndex = 6;
            this.ruleOneArrowLabel.Text = "->";
            // 
            // ruleOneToTextBox
            // 
            this.ruleOneToTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleOneToTextBox.Location = new System.Drawing.Point(81, 19);
            this.ruleOneToTextBox.Name = "ruleOneToTextBox";
            this.ruleOneToTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleOneToTextBox.TabIndex = 7;
            // 
            // ruleTwoFromTextBox
            // 
            this.ruleTwoFromTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleTwoFromTextBox.Location = new System.Drawing.Point(7, 19);
            this.ruleTwoFromTextBox.MaxLength = 1;
            this.ruleTwoFromTextBox.Name = "ruleTwoFromTextBox";
            this.ruleTwoFromTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleTwoFromTextBox.TabIndex = 8;
            // 
            // ruleTwoToTextBox
            // 
            this.ruleTwoToTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleTwoToTextBox.Location = new System.Drawing.Point(81, 19);
            this.ruleTwoToTextBox.Name = "ruleTwoToTextBox";
            this.ruleTwoToTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleTwoToTextBox.TabIndex = 9;
            // 
            // ruleTwoArrowLabel
            // 
            this.ruleTwoArrowLabel.AutoSize = true;
            this.ruleTwoArrowLabel.Location = new System.Drawing.Point(53, 22);
            this.ruleTwoArrowLabel.Name = "ruleTwoArrowLabel";
            this.ruleTwoArrowLabel.Size = new System.Drawing.Size(16, 13);
            this.ruleTwoArrowLabel.TabIndex = 10;
            this.ruleTwoArrowLabel.Text = "->";
            // 
            // ruleThreeFromTextBox
            // 
            this.ruleThreeFromTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleThreeFromTextBox.Location = new System.Drawing.Point(7, 19);
            this.ruleThreeFromTextBox.MaxLength = 1;
            this.ruleThreeFromTextBox.Name = "ruleThreeFromTextBox";
            this.ruleThreeFromTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleThreeFromTextBox.TabIndex = 11;
            // 
            // ruleThreeArrowTextBox
            // 
            this.ruleThreeArrowTextBox.AutoSize = true;
            this.ruleThreeArrowTextBox.Location = new System.Drawing.Point(53, 22);
            this.ruleThreeArrowTextBox.Name = "ruleThreeArrowTextBox";
            this.ruleThreeArrowTextBox.Size = new System.Drawing.Size(16, 13);
            this.ruleThreeArrowTextBox.TabIndex = 12;
            this.ruleThreeArrowTextBox.Text = "->";
            // 
            // ruleThreeToTextBox
            // 
            this.ruleThreeToTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ruleThreeToTextBox.Location = new System.Drawing.Point(81, 22);
            this.ruleThreeToTextBox.Name = "ruleThreeToTextBox";
            this.ruleThreeToTextBox.Size = new System.Drawing.Size(38, 20);
            this.ruleThreeToTextBox.TabIndex = 13;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(599, 346);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(70, 22);
            this.drawButton.TabIndex = 14;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // turnAngleLabel
            // 
            this.turnAngleLabel.AutoSize = true;
            this.turnAngleLabel.Location = new System.Drawing.Point(10, 21);
            this.turnAngleLabel.Name = "turnAngleLabel";
            this.turnAngleLabel.Size = new System.Drawing.Size(62, 13);
            this.turnAngleLabel.TabIndex = 15;
            this.turnAngleLabel.Text = "Turn Angle:";
            // 
            // turnAngleTextBox
            // 
            this.turnAngleTextBox.Location = new System.Drawing.Point(79, 19);
            this.turnAngleTextBox.Name = "turnAngleTextBox";
            this.turnAngleTextBox.Size = new System.Drawing.Size(53, 20);
            this.turnAngleTextBox.TabIndex = 16;
            this.turnAngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowNumbersInTextBox_KeyPress);
            // 
            // axiomLabel
            // 
            this.axiomLabel.AutoSize = true;
            this.axiomLabel.Location = new System.Drawing.Point(12, 48);
            this.axiomLabel.Name = "axiomLabel";
            this.axiomLabel.Size = new System.Drawing.Size(38, 13);
            this.axiomLabel.TabIndex = 17;
            this.axiomLabel.Text = "Axiom:";
            // 
            // axiomTextBox
            // 
            this.axiomTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.axiomTextBox.Location = new System.Drawing.Point(79, 45);
            this.axiomTextBox.Name = "axiomTextBox";
            this.axiomTextBox.Size = new System.Drawing.Size(53, 20);
            this.axiomTextBox.TabIndex = 18;
            // 
            // presetFractalComboBox
            // 
            this.presetFractalComboBox.FormattingEnabled = true;
            this.presetFractalComboBox.Items.AddRange(new object[] {
            "Kosh Snowflake",
            "Sierpinski Triangle",
            "Dragon Curve",
            "Crystal",
            "Binary Tree",
            "Cool 1",
            "Cool 2",
            "Round Star",
            "Island Curve"});
            this.presetFractalComboBox.Location = new System.Drawing.Point(416, 348);
            this.presetFractalComboBox.Name = "presetFractalComboBox";
            this.presetFractalComboBox.Size = new System.Drawing.Size(107, 21);
            this.presetFractalComboBox.TabIndex = 19;
            this.presetFractalComboBox.Text = "Preset Fractals";
            this.presetFractalComboBox.SelectedValueChanged += new System.EventHandler(this.presetFractalComboBox_SelectedValueChanged);
            // 
            // sideLengthLabel
            // 
            this.sideLengthLabel.AutoSize = true;
            this.sideLengthLabel.Location = new System.Drawing.Point(11, 73);
            this.sideLengthLabel.Name = "sideLengthLabel";
            this.sideLengthLabel.Size = new System.Drawing.Size(67, 13);
            this.sideLengthLabel.TabIndex = 20;
            this.sideLengthLabel.Text = "Side Length:";
            // 
            // sideLengthTextBox
            // 
            this.sideLengthTextBox.Location = new System.Drawing.Point(79, 70);
            this.sideLengthTextBox.Name = "sideLengthTextBox";
            this.sideLengthTextBox.Size = new System.Drawing.Size(53, 20);
            this.sideLengthTextBox.TabIndex = 21;
            this.sideLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowNumbersInTextBox_KeyPress);
            // 
            // fractalXPosition
            // 
            this.fractalXPosition.AutoSize = true;
            this.fractalXPosition.Location = new System.Drawing.Point(17, 22);
            this.fractalXPosition.Name = "fractalXPosition";
            this.fractalXPosition.Size = new System.Drawing.Size(15, 13);
            this.fractalXPosition.TabIndex = 23;
            this.fractalXPosition.Text = "x:";
            // 
            // fractalYPosition
            // 
            this.fractalYPosition.AutoSize = true;
            this.fractalYPosition.Location = new System.Drawing.Point(18, 48);
            this.fractalYPosition.Name = "fractalYPosition";
            this.fractalYPosition.Size = new System.Drawing.Size(15, 13);
            this.fractalYPosition.TabIndex = 24;
            this.fractalYPosition.Text = "y:";
            // 
            // fractalXPositionTextbox
            // 
            this.fractalXPositionTextbox.Location = new System.Drawing.Point(38, 19);
            this.fractalXPositionTextbox.Name = "fractalXPositionTextbox";
            this.fractalXPositionTextbox.Size = new System.Drawing.Size(30, 20);
            this.fractalXPositionTextbox.TabIndex = 25;
            this.fractalXPositionTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowNumbersInTextBox_KeyPress);
            // 
            // fractalYPositionTextbox
            // 
            this.fractalYPositionTextbox.Location = new System.Drawing.Point(38, 45);
            this.fractalYPositionTextbox.Name = "fractalYPositionTextbox";
            this.fractalYPositionTextbox.Size = new System.Drawing.Size(30, 20);
            this.fractalYPositionTextbox.TabIndex = 26;
            this.fractalYPositionTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowNumbersInTextBox_KeyPress);
            // 
            // recurrsionDepthLabel
            // 
            this.recurrsionDepthLabel.Location = new System.Drawing.Point(6, 96);
            this.recurrsionDepthLabel.Name = "recurrsionDepthLabel";
            this.recurrsionDepthLabel.Size = new System.Drawing.Size(128, 21);
            this.recurrsionDepthLabel.TabIndex = 27;
            this.recurrsionDepthLabel.Text = "Recurrsion Depth:";
            this.recurrsionDepthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recurrsionDepthTextbox
            // 
            this.recurrsionDepthTextbox.Location = new System.Drawing.Point(44, 112);
            this.recurrsionDepthTextbox.Name = "recurrsionDepthTextbox";
            this.recurrsionDepthTextbox.Size = new System.Drawing.Size(55, 20);
            this.recurrsionDepthTextbox.TabIndex = 28;
            this.recurrsionDepthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowNumbersInTextBox_KeyPress);
            // 
            // gradientColourOneButton
            // 
            this.gradientColourOneButton.Location = new System.Drawing.Point(6, 26);
            this.gradientColourOneButton.Name = "gradientColourOneButton";
            this.gradientColourOneButton.Size = new System.Drawing.Size(93, 23);
            this.gradientColourOneButton.TabIndex = 29;
            this.gradientColourOneButton.Text = "Choose Colour 1";
            this.gradientColourOneButton.UseVisualStyleBackColor = true;
            this.gradientColourOneButton.Click += new System.EventHandler(this.gradientColourButton_Click);
            // 
            // gradientColourTwoButton
            // 
            this.gradientColourTwoButton.Location = new System.Drawing.Point(6, 80);
            this.gradientColourTwoButton.Name = "gradientColourTwoButton";
            this.gradientColourTwoButton.Size = new System.Drawing.Size(93, 23);
            this.gradientColourTwoButton.TabIndex = 30;
            this.gradientColourTwoButton.Text = "Choose Colour 2";
            this.gradientColourTwoButton.UseVisualStyleBackColor = true;
            this.gradientColourTwoButton.Click += new System.EventHandler(this.gradientColourButton_Click);
            // 
            // colourOneDisplayLabel
            // 
            this.colourOneDisplayLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colourOneDisplayLabel.Location = new System.Drawing.Point(24, 56);
            this.colourOneDisplayLabel.Name = "colourOneDisplayLabel";
            this.colourOneDisplayLabel.Size = new System.Drawing.Size(54, 11);
            this.colourOneDisplayLabel.TabIndex = 31;
            // 
            // colourTwoDisplayLabel
            // 
            this.colourTwoDisplayLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colourTwoDisplayLabel.Location = new System.Drawing.Point(24, 112);
            this.colourTwoDisplayLabel.Name = "colourTwoDisplayLabel";
            this.colourTwoDisplayLabel.Size = new System.Drawing.Size(54, 11);
            this.colourTwoDisplayLabel.TabIndex = 32;
            // 
            // numberOfRulesGroupBox
            // 
            this.numberOfRulesGroupBox.Controls.Add(this.rulesRadioButton1);
            this.numberOfRulesGroupBox.Controls.Add(this.rulesRadioButton2);
            this.numberOfRulesGroupBox.Controls.Add(this.rulesRadioButton3);
            this.numberOfRulesGroupBox.Location = new System.Drawing.Point(416, 12);
            this.numberOfRulesGroupBox.Name = "numberOfRulesGroupBox";
            this.numberOfRulesGroupBox.Size = new System.Drawing.Size(107, 97);
            this.numberOfRulesGroupBox.TabIndex = 33;
            this.numberOfRulesGroupBox.TabStop = false;
            this.numberOfRulesGroupBox.Text = "Number Of Rules";
            // 
            // startingInformationGroupBox
            // 
            this.startingInformationGroupBox.Controls.Add(this.turnAngleTextBox);
            this.startingInformationGroupBox.Controls.Add(this.turnAngleLabel);
            this.startingInformationGroupBox.Controls.Add(this.axiomLabel);
            this.startingInformationGroupBox.Controls.Add(this.axiomTextBox);
            this.startingInformationGroupBox.Controls.Add(this.sideLengthLabel);
            this.startingInformationGroupBox.Controls.Add(this.sideLengthTextBox);
            this.startingInformationGroupBox.Controls.Add(this.recurrsionDepthTextbox);
            this.startingInformationGroupBox.Controls.Add(this.recurrsionDepthLabel);
            this.startingInformationGroupBox.Location = new System.Drawing.Point(529, 12);
            this.startingInformationGroupBox.Name = "startingInformationGroupBox";
            this.startingInformationGroupBox.Size = new System.Drawing.Size(140, 143);
            this.startingInformationGroupBox.TabIndex = 34;
            this.startingInformationGroupBox.TabStop = false;
            this.startingInformationGroupBox.Text = "Starting Information";
            // 
            // fractalPositionGroupBox
            // 
            this.fractalPositionGroupBox.Controls.Add(this.fractalYPositionTextbox);
            this.fractalPositionGroupBox.Controls.Add(this.fractalXPosition);
            this.fractalPositionGroupBox.Controls.Add(this.fractalYPosition);
            this.fractalPositionGroupBox.Controls.Add(this.fractalXPositionTextbox);
            this.fractalPositionGroupBox.Location = new System.Drawing.Point(416, 115);
            this.fractalPositionGroupBox.Name = "fractalPositionGroupBox";
            this.fractalPositionGroupBox.Size = new System.Drawing.Size(107, 76);
            this.fractalPositionGroupBox.TabIndex = 35;
            this.fractalPositionGroupBox.TabStop = false;
            this.fractalPositionGroupBox.Text = "Starting Position";
            // 
            // ruleOneGroupBox
            // 
            this.ruleOneGroupBox.Controls.Add(this.ruleOneToTextBox);
            this.ruleOneGroupBox.Controls.Add(this.ruleOneFromTextBox);
            this.ruleOneGroupBox.Controls.Add(this.ruleOneArrowLabel);
            this.ruleOneGroupBox.Location = new System.Drawing.Point(9, 19);
            this.ruleOneGroupBox.Name = "ruleOneGroupBox";
            this.ruleOneGroupBox.Size = new System.Drawing.Size(126, 47);
            this.ruleOneGroupBox.TabIndex = 36;
            this.ruleOneGroupBox.TabStop = false;
            this.ruleOneGroupBox.Text = "Rule 1";
            // 
            // ruleTwoGroupBox
            // 
            this.ruleTwoGroupBox.Controls.Add(this.ruleTwoToTextBox);
            this.ruleTwoGroupBox.Controls.Add(this.ruleTwoFromTextBox);
            this.ruleTwoGroupBox.Controls.Add(this.ruleTwoArrowLabel);
            this.ruleTwoGroupBox.Location = new System.Drawing.Point(9, 72);
            this.ruleTwoGroupBox.Name = "ruleTwoGroupBox";
            this.ruleTwoGroupBox.Size = new System.Drawing.Size(126, 47);
            this.ruleTwoGroupBox.TabIndex = 37;
            this.ruleTwoGroupBox.TabStop = false;
            this.ruleTwoGroupBox.Text = "Rule 2";
            // 
            // ruleThreeGroupBox
            // 
            this.ruleThreeGroupBox.Controls.Add(this.ruleThreeToTextBox);
            this.ruleThreeGroupBox.Controls.Add(this.ruleThreeFromTextBox);
            this.ruleThreeGroupBox.Controls.Add(this.ruleThreeArrowTextBox);
            this.ruleThreeGroupBox.Location = new System.Drawing.Point(9, 125);
            this.ruleThreeGroupBox.Name = "ruleThreeGroupBox";
            this.ruleThreeGroupBox.Size = new System.Drawing.Size(126, 47);
            this.ruleThreeGroupBox.TabIndex = 38;
            this.ruleThreeGroupBox.TabStop = false;
            this.ruleThreeGroupBox.Text = "Rule 3";
            // 
            // inputRulesGroupBox
            // 
            this.inputRulesGroupBox.Controls.Add(this.ruleOneGroupBox);
            this.inputRulesGroupBox.Controls.Add(this.ruleThreeGroupBox);
            this.inputRulesGroupBox.Controls.Add(this.ruleTwoGroupBox);
            this.inputRulesGroupBox.Location = new System.Drawing.Point(529, 160);
            this.inputRulesGroupBox.Name = "inputRulesGroupBox";
            this.inputRulesGroupBox.Size = new System.Drawing.Size(140, 182);
            this.inputRulesGroupBox.TabIndex = 39;
            this.inputRulesGroupBox.TabStop = false;
            this.inputRulesGroupBox.Text = "Input Rules";
            // 
            // colourChooseGroupBox
            // 
            this.colourChooseGroupBox.Controls.Add(this.gradientColourOneButton);
            this.colourChooseGroupBox.Controls.Add(this.colourOneDisplayLabel);
            this.colourChooseGroupBox.Controls.Add(this.gradientColourTwoButton);
            this.colourChooseGroupBox.Controls.Add(this.colourTwoDisplayLabel);
            this.colourChooseGroupBox.Location = new System.Drawing.Point(416, 197);
            this.colourChooseGroupBox.Name = "colourChooseGroupBox";
            this.colourChooseGroupBox.Size = new System.Drawing.Size(107, 145);
            this.colourChooseGroupBox.TabIndex = 40;
            this.colourChooseGroupBox.TabStop = false;
            this.colourChooseGroupBox.Text = "Gradient Colours";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(529, 346);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(70, 22);
            this.helpButton.TabIndex = 41;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 401);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.colourChooseGroupBox);
            this.Controls.Add(this.inputRulesGroupBox);
            this.Controls.Add(this.fractalPositionGroupBox);
            this.Controls.Add(this.startingInformationGroupBox);
            this.Controls.Add(this.numberOfRulesGroupBox);
            this.Controls.Add(this.presetFractalComboBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.fractalPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).EndInit();
            this.numberOfRulesGroupBox.ResumeLayout(false);
            this.numberOfRulesGroupBox.PerformLayout();
            this.startingInformationGroupBox.ResumeLayout(false);
            this.startingInformationGroupBox.PerformLayout();
            this.fractalPositionGroupBox.ResumeLayout(false);
            this.fractalPositionGroupBox.PerformLayout();
            this.ruleOneGroupBox.ResumeLayout(false);
            this.ruleOneGroupBox.PerformLayout();
            this.ruleTwoGroupBox.ResumeLayout(false);
            this.ruleTwoGroupBox.PerformLayout();
            this.ruleThreeGroupBox.ResumeLayout(false);
            this.ruleThreeGroupBox.PerformLayout();
            this.inputRulesGroupBox.ResumeLayout(false);
            this.colourChooseGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalPictureBox;
        private System.Windows.Forms.RadioButton rulesRadioButton1;
        private System.Windows.Forms.RadioButton rulesRadioButton2;
        private System.Windows.Forms.RadioButton rulesRadioButton3;
        private System.Windows.Forms.TextBox ruleOneFromTextBox;
        private System.Windows.Forms.Label ruleOneArrowLabel;
        private System.Windows.Forms.TextBox ruleOneToTextBox;
        private System.Windows.Forms.TextBox ruleTwoFromTextBox;
        private System.Windows.Forms.TextBox ruleTwoToTextBox;
        private System.Windows.Forms.Label ruleTwoArrowLabel;
        private System.Windows.Forms.TextBox ruleThreeFromTextBox;
        private System.Windows.Forms.Label ruleThreeArrowTextBox;
        private System.Windows.Forms.TextBox ruleThreeToTextBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label turnAngleLabel;
        private System.Windows.Forms.TextBox turnAngleTextBox;
        private System.Windows.Forms.Label axiomLabel;
        private System.Windows.Forms.TextBox axiomTextBox;
        private System.Windows.Forms.ComboBox presetFractalComboBox;
        private System.Windows.Forms.Label sideLengthLabel;
        private System.Windows.Forms.TextBox sideLengthTextBox;
        private System.Windows.Forms.Label fractalXPosition;
        private System.Windows.Forms.Label fractalYPosition;
        private System.Windows.Forms.TextBox fractalXPositionTextbox;
        private System.Windows.Forms.TextBox fractalYPositionTextbox;
        private System.Windows.Forms.Label recurrsionDepthLabel;
        private System.Windows.Forms.TextBox recurrsionDepthTextbox;
        private System.Windows.Forms.ColorDialog gradientPickerColorDialog;
        private System.Windows.Forms.Button gradientColourOneButton;
        private System.Windows.Forms.Button gradientColourTwoButton;
        private System.Windows.Forms.Label colourOneDisplayLabel;
        private System.Windows.Forms.Label colourTwoDisplayLabel;
        private System.Windows.Forms.GroupBox numberOfRulesGroupBox;
        private System.Windows.Forms.GroupBox startingInformationGroupBox;
        private System.Windows.Forms.GroupBox fractalPositionGroupBox;
        private System.Windows.Forms.GroupBox ruleOneGroupBox;
        private System.Windows.Forms.GroupBox ruleTwoGroupBox;
        private System.Windows.Forms.GroupBox ruleThreeGroupBox;
        private System.Windows.Forms.GroupBox inputRulesGroupBox;
        private System.Windows.Forms.GroupBox colourChooseGroupBox;
        private System.Windows.Forms.Button helpButton;
    }
}

