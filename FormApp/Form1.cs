namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardCodedButton = new Button();
            HardCodedButton.Parent = this;
            HardCodedButton.Top = 400;
            HardCodedButton.Left = 225;
            HardCodedButton.Text = "Hard Coded Button...";
            HardCodedButton.Click += new System.EventHandler(SayHello);

        }
        private void SayHello(object sender, EventArgs args)
        {
            MessageBox.Show("Hello, World!");
        }

        private void ExtendButton()
        {
            HardCodedButton.Width += 10;
        }
    }
}