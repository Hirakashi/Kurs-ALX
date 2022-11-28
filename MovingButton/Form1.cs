namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var left = rnd.NextInt64(100, 700);
            var top = rnd.NextInt64(50, 400);
            button1.Location = new Point((int)left, (int)top);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}