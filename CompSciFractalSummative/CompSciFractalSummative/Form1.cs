using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CompSciFractalSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colourOneDisplayLabel.BackColor = Color.FromArgb(255, 255, 0, 0);
            colourTwoDisplayLabel.BackColor = Color.FromArgb(255, 0, 0, 255);
            rulesRadioButton1.Checked = true;
        }
        
        #region feilds
        private Vector2 lastVector = new Vector2(4, 0);
        private int generationNumber = 0;
        private double lastPointX = 50;
        private double lastPointY = 300;

        private Color gradientColourOne = Color.FromArgb(255, 255, 0, 0);
        private Color gradientColourTwo = Color.FromArgb(255, 0, 0, 255);

        private Bitmap fractalBitmap = new Bitmap(800, 600);

        Stack<SavePosition> positions = new Stack<SavePosition>();
        #endregion

        #region Checking and Verification
        private bool isValidInput(string checkString)
        {
            foreach (char c in checkString)
            {
                if (c != 'f' && c != 'g' && c != '-' && c != '+' && c != '[' && c != ']' && c != 'x' && c != 'y' && c != 'b')
                {
                    return false;
                }
            }
            return true;
        }

        private void OnlyAllowNumbersInTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool isInputEmpty()
        {
            if (ruleOneFromTextBox.Text == "" || ruleOneToTextBox.Text == "")
            {
                return true;
            }
            else if ((ruleTwoFromTextBox.Text == "" || ruleTwoToTextBox.Text == "") && (rulesRadioButton2.Checked || rulesRadioButton3.Checked))
            {
                return true;
            }
            else if ((ruleThreeFromTextBox.Text == "" || ruleThreeToTextBox.Text == "") && rulesRadioButton3.Checked)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Click Event Handlers
        private void drawButton_Click(object sender, EventArgs e)
        {
            if (isInputEmpty())
            {
                MessageBox.Show("Please make sure you have filled out the input and outputs for all the avalible rules.", "Blank Rules");
                return;
            }
            Graphics fractalImage = Graphics.FromImage(fractalBitmap);
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(401, 10),
            gradientColourOne,
            gradientColourTwo);

            Pen drawPen = new Pen(linGrBrush);

            fractalImage.Clear(fractalPictureBox.BackColor);

            string axiom = axiomTextBox.Text.Replace(" ", string.Empty);
            double turnAngle;
            int xPosition;
            int yPosition;
            int sideLength;
            int maxDepth;
            bool isAngleNumeric = double.TryParse(turnAngleTextBox.Text, out turnAngle);
            bool isXPositionNumeric = Int32.TryParse(fractalXPositionTextbox.Text, out xPosition);
            bool isYPositionNumeric = Int32.TryParse(fractalYPositionTextbox.Text, out yPosition);
            bool isSideLengthNumeric = Int32.TryParse(sideLengthTextBox.Text, out sideLength);
            bool isMaxDepthNumeric = Int32.TryParse(recurrsionDepthTextbox.Text, out maxDepth);
            if (rulesRadioButton1.Checked)
            {
                string ruleOneFromString = ruleOneFromTextBox.Text.Replace(" ", string.Empty);
                string ruleOneToString = ruleOneToTextBox.Text.Replace(" ", string.Empty);

                if (!isValidInput(axiom + ruleOneFromString + ruleOneToString) || !isAngleNumeric || !isXPositionNumeric || !isYPositionNumeric || !isSideLengthNumeric || !isMaxDepthNumeric)
                {
                    MessageBox.Show("You have entered an invalid rule. Please check the list of valid input characters");
                    return;
                }
                lastPointX = xPosition;
                lastPointY = yPosition;
                lastVector.X = sideLength;
                lastVector.Y = 0;
                DrawFractal(InstructionSet(axiom, Convert.ToChar(ruleOneFromString), ruleOneToString, 0, maxDepth), fractalImage, drawPen, DegreesToRadians(turnAngle));
            }
            else if (rulesRadioButton2.Checked)
            {
                string ruleOneFromString = ruleOneFromTextBox.Text.Replace(" ", string.Empty);
                string ruleOneToString = ruleOneToTextBox.Text.Replace(" ", string.Empty);
                string ruleTwoFromString = ruleTwoFromTextBox.Text.Replace(" ", string.Empty);
                string ruleTwoToString = ruleTwoToTextBox.Text.Replace(" ", string.Empty);

                if (!isValidInput(axiom + ruleOneFromString + ruleOneToString + ruleTwoFromString + ruleTwoToString) || !isAngleNumeric || !isXPositionNumeric || !isYPositionNumeric || !isSideLengthNumeric || !isMaxDepthNumeric)
                {
                    MessageBox.Show("You have entered an invalid rule. Please check the list of valid input characters");
                    return;
                }
                lastPointX = xPosition;
                lastPointY = yPosition;
                lastVector.X = sideLength;
                lastVector.Y = 0;
                DrawFractal(InstructionSet(axiom, Convert.ToChar(ruleOneFromString), ruleOneToString, Convert.ToChar(ruleTwoFromString), ruleTwoToString, 0, maxDepth), fractalImage, drawPen, DegreesToRadians(turnAngle));
            }
            else
            {
                string ruleOneFromString = ruleOneFromTextBox.Text.Replace(" ", string.Empty);
                string ruleOneToString = ruleOneToTextBox.Text.Replace(" ", string.Empty);
                string ruleTwoFromString = ruleTwoFromTextBox.Text.Replace(" ", string.Empty);
                string ruleTwoToString = ruleTwoToTextBox.Text.Replace(" ", string.Empty);
                string ruleThreeFromString = ruleThreeFromTextBox.Text.Replace(" ", string.Empty);
                string ruleThreeToString = ruleThreeToTextBox.Text.Replace(" ", string.Empty);

                if (!isValidInput(axiom + ruleOneFromString + ruleOneToString + ruleTwoFromString + ruleTwoToString + ruleThreeFromString + ruleThreeToString) || !isAngleNumeric || !isXPositionNumeric || !isYPositionNumeric || !isSideLengthNumeric || !isMaxDepthNumeric)
                {
                    MessageBox.Show("You have entered an invalid rule. Please check the list of valid input characters");
                    return;
                }

                lastPointX = xPosition;
                lastPointY = yPosition;
                lastVector.X = sideLength;
                lastVector.Y = 0;
                DrawFractal(InstructionSet(axiom, Convert.ToChar(ruleOneFromString), ruleOneToString, Convert.ToChar(ruleTwoFromString), ruleTwoToString, Convert.ToChar(ruleThreeFromString), ruleThreeToString, 0, maxDepth), fractalImage, drawPen, DegreesToRadians(turnAngle));
            }
            fractalPictureBox.Refresh();
        }



        private void gradientColourButton_Click(object sender, EventArgs e)
        {
            if (gradientPickerColorDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                Button button = sender as Button;
                if (button.Name == "gradientColourOneButton")
                {
                    colourOneDisplayLabel.BackColor = gradientPickerColorDialog.Color;
                    gradientColourOne = gradientPickerColorDialog.Color;
                }
                else
                {
                    colourTwoDisplayLabel.BackColor = gradientPickerColorDialog.Color;
                    gradientColourTwo = gradientPickerColorDialog.Color;
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allowed Inputs: \n" +
                "   f: Draws a straight line with the inputted length \n" +
                "   g: Draws a straight line with the inputted length \n" +
                "   -: Next line drawn is rotated by the inputted angle counter clockwise \n" +
                "   +: Next line drawn is rotated by the inputted angle clockwise \n" +
                "   b: Skips forward by the inputted length without drawing \n" +
                "   [: saves the current position and angle \n" +
                "   ]: restores the last saved position and angle \n" +
                "   x: place holder \n" +
                "   y: place holder \n \n" +
                "Starting Information: \n" +
                "   Turn Angle: angle in degrees that is turned for a + or - \n" +
                "   Axiom: Starting instructions  \n" +
                "   Side Length: Length of line drawn for a f or g \n" +
                "   Recursion depth: Number of levels of instruction updates \n \n" +
                "How this Works: \n" +
                "   The fractals in this program are generated using the L-system \n" +
                "   (Lindenmayer system). This is a parallel rewriting system. An L-system \n" +
                "   consists of an alphabet of symbols that can be used to make strings, \n" +
                "   a collection of production rules that expand each symbol into some \n" +
                "   larger string of symbols, an initial 'axiom' string from which to begin \n" +
                "   construction, and a mechanism for translating the generated strings \n" +
                "   into an instruction set. \n \n" +
                "*WARNING!!!* \n" +
                "   If code is taking too long to execute restart the program \n" +
                "   and reduce the recursion depth");
        }
        #endregion

        #region GetInstructions

        private string InstructionSet(String instrutions, Char fromRuleOne, String toRuleOne, int currentDepth, int maxDepth)
        {
            if (currentDepth >= maxDepth)
            {
                return instrutions;
            }
            string nextInstructions = "";
            foreach (char c in instrutions)
            {
                if (c == fromRuleOne)
                {
                    nextInstructions += toRuleOne;
                }
                else
                {
                    nextInstructions += c;
                }
            }
            return InstructionSet(nextInstructions, fromRuleOne, toRuleOne, currentDepth + 1, maxDepth);
        }

        private string InstructionSet(String instrutions, Char fromRuleOne, String toRuleOne, Char fromRuleTwo, String toRuleTwo, int currentDepth, int maxDepth)
        {
            if (currentDepth >= maxDepth)
            {
                return instrutions;
            }
            string nextInstructions = "";
            foreach (char c in instrutions)
            {
                if (c == fromRuleOne)
                {
                    nextInstructions += toRuleOne;
                }
                else if (c == fromRuleTwo)
                {
                    nextInstructions += toRuleTwo;
                }
                else
                {
                    nextInstructions += c;
                }
            }
            return InstructionSet(nextInstructions, fromRuleOne, toRuleOne, fromRuleTwo, toRuleTwo, currentDepth + 1, maxDepth);
        }

        private string InstructionSet(String instrutions, Char fromRuleOne, String toRuleOne, Char fromRuleTwo, String toRuleTwo, char fromRuleThree, String toRuleThree, int currentDepth, int maxDepth)
        {
            if (currentDepth >= maxDepth)
            {
                return instrutions;
            }
            string nextInstructions = "";
            foreach (char c in instrutions)
            {
                if (c == fromRuleOne)
                {
                    nextInstructions += toRuleOne;
                }
                else if (c == fromRuleTwo)
                {
                    nextInstructions += toRuleTwo;
                }
                else if (c == fromRuleThree)
                {
                    nextInstructions += toRuleTwo;
                }
                else
                {
                    nextInstructions += c;
                }
            }
            return InstructionSet(nextInstructions, fromRuleOne, toRuleOne, fromRuleTwo, toRuleTwo, fromRuleThree, toRuleThree, currentDepth + 1, maxDepth);
        }
        #endregion

        #region Drawing Fractal 
        private void fractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(fractalBitmap, 0, 0);
        }

        private void DrawFractal(string instructions, Graphics drawingSurface, Pen drawingPen, double angle)
        {
            foreach (char c in instructions)
            {
                switch (c)
                {
                    case 'f':
                        Foward(drawingSurface, drawingPen);
                        break;
                    case 'g':
                        Foward(drawingSurface, drawingPen);
                        break;
                    case 'b':
                        SkipLine();
                        break;
                    case '-':
                        TurnCounterClockWise(angle);
                        break;
                    case '+':
                        TurnClockWise(angle);
                        break;
                    case '[':
                        PushPosition();
                        break;
                    case ']':
                        PopPosition();
                        break;
                }
            }
        }
        #endregion

        #region Follow Instructions
        private void Foward(Graphics drawingSurface, Pen drawingPen)
        {
            Point A = new Point(Convert.ToInt32(lastPointX), Convert.ToInt32(lastPointY));
            Point B = new Point((int)(lastPointX + lastVector.X), (int)(lastPointY - lastVector.Y));
            double Bx = lastPointX + lastVector.X;
            double By = lastPointY - lastVector.Y;
            Vector2 OA = new Vector2(A.X, A.Y);
            Vector2 OB = new Vector2(B.X, B.Y);

            lastPointX = Bx;
            lastPointY = By;
            drawingSurface.DrawLine(drawingPen, A, B);
        }

        private void SkipLine()
        {
            lastPointX = lastPointX + lastVector.X;
            lastPointY = lastPointY - lastVector.Y;
        }

        private void TurnClockWise(double theta)
        {
            theta = 2 * Math.PI - theta;
            if (theta == Math.PI * 3 / 2)
            {
                lastVector = new Vector2(lastVector.Y, lastVector.X * -1);
                return;
            }
            double cs = Math.Cos(theta);
            double sn = Math.Sin(theta);
            double px = lastVector.X * cs - lastVector.Y * sn;
            double py = lastVector.X * sn + lastVector.Y * cs;
            lastVector = new Vector2(px, py);
        }

        private void TurnCounterClockWise(double theta)
        {
            if (theta == Math.PI / 2)
            {
                lastVector = new Vector2(lastVector.Y * -1, lastVector.X);
                return;
            }
            double cs = Math.Cos(theta);
            double sn = Math.Sin(theta);
            double px = lastVector.X * cs - lastVector.Y * sn;
            double py = lastVector.X * sn + lastVector.Y * cs;
            lastVector = new Vector2(px, py);
        }

        private void PushPosition()
        {
            SavePosition currentPostion = new SavePosition(lastPointX, lastPointY, lastVector);
            positions.Push(currentPostion);
        }

        private void PopPosition()
        {
            SavePosition newPosition = positions.Pop();
            lastPointX = newPosition.saveX;
            lastPointY = newPosition.saveY;
            lastVector = newPosition.saveVector;
        }
        #endregion

        #region Value Changed Event Handlers
        private void presetFractalComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox presetComboBox = sender as ComboBox;
            switch (presetComboBox.SelectedItem)
            {
                case "Kosh Snowflake":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "f--f--f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f + f--f + f";
                    turnAngleTextBox.Text = "60";
                    sideLengthTextBox.Text = "4";
                    fractalXPositionTextbox.Text = "50";
                    fractalYPositionTextbox.Text = "300";
                    recurrsionDepthTextbox.Text = "4";
                    break;
                case "Sierpinski Triangle":
                    rulesRadioButton2.Select();
                    axiomTextBox.Text = "f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "+g-f-g+";
                    ruleTwoFromTextBox.Text = "g";
                    ruleTwoToTextBox.Text = "-f+g+f-";
                    turnAngleTextBox.Text = "60";
                    sideLengthTextBox.Text = "6";
                    fractalXPositionTextbox.Text = "7";
                    fractalYPositionTextbox.Text = "25";
                    recurrsionDepthTextbox.Text = "6";
                    break;
                case "Dragon Curve":
                    rulesRadioButton2.Select();
                    axiomTextBox.Text = "+fx";
                    ruleOneFromTextBox.Text = "x";
                    ruleOneToTextBox.Text = "x+yf+";
                    ruleTwoFromTextBox.Text = "y";
                    ruleTwoToTextBox.Text = "-fx-y";
                    turnAngleTextBox.Text = "90";
                    sideLengthTextBox.Text = "6";
                    fractalXPositionTextbox.Text = "300";
                    fractalYPositionTextbox.Text = "260";
                    recurrsionDepthTextbox.Text = "11";
                    break;
                case "Crystal":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "f+xf+f+xf";
                    ruleOneFromTextBox.Text = "x";
                    ruleOneToTextBox.Text = "xf-f+f-xf+f+xf-f+f-x";
                    turnAngleTextBox.Text = "90";
                    sideLengthTextBox.Text = "6";
                    fractalXPositionTextbox.Text = "195";
                    fractalYPositionTextbox.Text = "15";
                    recurrsionDepthTextbox.Text = "4";
                    break;
                case "Binary Tree":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "---f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f[-f][+f]";
                    turnAngleTextBox.Text = "30";
                    sideLengthTextBox.Text = "60";
                    fractalXPositionTextbox.Text = "200";
                    fractalYPositionTextbox.Text = "375";
                    recurrsionDepthTextbox.Text = "4";
                    break;
                case "Cool 1":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "f-f-f-f-f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f-f++f+f-f-f";
                    turnAngleTextBox.Text = "72";
                    sideLengthTextBox.Text = "10";
                    fractalXPositionTextbox.Text = "100";
                    fractalYPositionTextbox.Text = "75";
                    recurrsionDepthTextbox.Text = "3";
                    break;
                case "Cool 2":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "f++f++f++f++f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f++f++f+++++f-f++f";
                    turnAngleTextBox.Text = "36";
                    sideLengthTextBox.Text = "13";
                    fractalXPositionTextbox.Text = "85";
                    fractalYPositionTextbox.Text = "25";
                    recurrsionDepthTextbox.Text = "3";
                    break;
                case "Round Star":
                    rulesRadioButton1.Select();
                    axiomTextBox.Text = "f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f++f";
                    turnAngleTextBox.Text = "77";
                    sideLengthTextBox.Text = "350";
                    fractalXPositionTextbox.Text = "25";
                    fractalYPositionTextbox.Text = "150";
                    recurrsionDepthTextbox.Text = "7";
                    break;
                case "Island Curve":
                    rulesRadioButton2.Select();
                    axiomTextBox.Text = "f-f-f-f";
                    ruleOneFromTextBox.Text = "f";
                    ruleOneToTextBox.Text = "f-b+ff-f-ff-fb-ff+b-ff+f+ff+fb+fff";
                    ruleTwoFromTextBox.Text = "b";
                    ruleTwoToTextBox.Text = "bbbbbb";
                    turnAngleTextBox.Text = "90";
                    sideLengthTextBox.Text = "6";
                    fractalXPositionTextbox.Text = "90";
                    fractalYPositionTextbox.Text = "310";
                    recurrsionDepthTextbox.Text = "2";
                    break;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Name == "rulesRadioButton1")
            {
                ruleTwoGroupBox.Enabled = false;
                ruleThreeGroupBox.Enabled = false;
            }
            else if (radioButton.Name == "rulesRadioButton2")
            {
                ruleTwoGroupBox.Enabled = true;
                ruleThreeGroupBox.Enabled = false;
            }
            else
            {
                ruleTwoGroupBox.Enabled = true;
                ruleThreeGroupBox.Enabled = true;
            }
        }
        #endregion

        #region Helper Methods
        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        #endregion

    }
}
