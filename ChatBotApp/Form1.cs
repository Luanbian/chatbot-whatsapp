namespace ChatBotApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendMessage send = new();
            send.Perform("Essa é uma mensagem enviada por um bot", "Maria");

        }
    }
}
