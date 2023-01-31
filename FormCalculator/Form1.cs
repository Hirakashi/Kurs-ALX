using FormCalculator.Services;
using System.Linq.Expressions;
using System.Text;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        public StringBuilder ExpressionBuilder { get; set; }
        public Form1()
        {
            ExpressionBuilder = new StringBuilder();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void OperationButtons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ExpressionService.CheckIfNumberIsLast(ExpressionBuilder.ToString()) || ExpressionBuilder.ToString().Last() == ')')
            {
                ExpressionBuilder.Append(button.Text);
                Display.Text = ExpressionBuilder.ToString();
            }
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ExpressionBuilder.Append(button.Text);
            Display.Text = ExpressionBuilder.ToString();
            ResultDisplay.Text = ExpressionService.ProcessExpresion(ExpressionBuilder.ToString()).ToString();
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ExpressionBuilder.ToString() != "0")
            {
                ExpressionBuilder.Append(button.Text);
                Display.Text = ExpressionBuilder.ToString();
                var result = ExpressionService.ProcessExpresion(ExpressionBuilder.ToString());
                ResultDisplay.Text = result.ToString();
            }
        }
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            char[]? expressionArray = ExpressionBuilder.ToString().ToCharArray();
            var numberBuilder = new StringBuilder();
            int i=expressionArray.Length-1;
            int trim = 0;
            while (true)
            {
                trim++;
                if (expressionArray[i] != '+' && expressionArray[i] != '-' && expressionArray[i] != 'x' && expressionArray[i] != '/')
                {
                    i--;
                    if (i == -1)
                    {
                        for (int j = 0; j< expressionArray.Length;j++) 
                        {
                            numberBuilder.Append(expressionArray[j]);
                        }
                        ExpressionBuilder.Length -= trim;
                        ExpressionBuilder.Append($"(-{double.Parse(numberBuilder.ToString())})");
                        break;
                    }
                }
                else
                {
                    if((i-1)=='(')
                    {
                        for (int j = i+1; j < (expressionArray.Length -1); j++)
                        {
                            numberBuilder.Append(expressionArray[j]);
                        }
                        ExpressionBuilder.Length -= trim;
                        ExpressionBuilder.Append($"{numberBuilder.ToString()}");
                        break;
                    }
                    else
                    {
                        for (int j=(i+1); j< expressionArray.Length; j++)
                        {
                            numberBuilder.Append(expressionArray[j]);
                        }
                        ExpressionBuilder.Length -= trim;
                        ExpressionBuilder.Append($"(-{numberBuilder.ToString()})");
                        break;
                    }
                }
            }
            Display.Text = ExpressionBuilder.ToString();
            //ResultDisplay.Text = ExpressionService.ProcessExpresion(ExpressionBuilder.ToString()).ToString();
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            Display.Clear();
            ResultDisplay.Clear();
            Display.Font = new Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ResultDisplay.Font = new Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ExpressionBuilder.ToString()))
            {
                var result = ExpressionService.ProcessExpresion(ExpressionBuilder.ToString());
                ResultDisplay.Text = result.ToString();
                ExpressionBuilder.Append("=");
                Display.Text = ExpressionBuilder.ToString();
                ExpressionBuilder.Clear();
                ExpressionBuilder.Append(result.ToString());
            }
        }
        private void Display_TextChanged(object sender, EventArgs e)
        {
            var textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), Display.Font);
            while (textLenght.Width > Display.Width)
            {
                Display.Font = new Font(Display.Font.FontFamily, Display.Font.Size - 1f, FontStyle.Bold);
                textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), Display.Font);
            }
            this.Display.AutoSize = false;
        }
        private void ResultDisplay_TextChanged(object sender, EventArgs e)
        {
            var textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultDisplay.Font);
            while (textLenght.Width > ResultDisplay.Width)
            {
                ResultDisplay.Font = new Font(ResultDisplay.Font.FontFamily, ResultDisplay.Font.Size - 1f, FontStyle.Bold);
                textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultDisplay.Font);
            }
            this.ResultDisplay.AutoSize = false;
        }
        private void ClearOne_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ExpressionBuilder.ToString()))
            {
                ExpressionBuilder.Length--;
            }
            if (String.IsNullOrEmpty(ExpressionBuilder.ToString()))
            {
                ResultDisplay.Clear();
            }
            if (ExpressionService.CheckIfNumberIsLast(ExpressionBuilder.ToString()))
            {
                var result = ExpressionService.ProcessExpresion(ExpressionBuilder.ToString());
                if (ResultDisplay.Font.Size < 22f)
                {
                    ResultDisplay.Font = new Font(ResultDisplay.Font.FontFamily, ResultDisplay.Font.Size + 1f, FontStyle.Bold);
                }
                ResultDisplay.Text = result.ToString();
            }
            if ( Display.Font.Size < 22f)
            {
                Display.Font = new Font(Display.Font.FontFamily, Display.Font.Size + 1f, FontStyle.Bold);
            }
            Display.Text = ExpressionBuilder.ToString();
        }
    }
}