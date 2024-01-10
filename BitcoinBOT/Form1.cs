using BitcoinBOT.Driver;
using System.Reflection;

namespace BitcoinBOT
{
    public partial class Form1 : Form
    {
        private bool allowRobot;
        public Form1()
        {
            InitializeComponent();
            notify.Text = "Bitcoin";
            notify.Visible = true;
            notify.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            allowRobot = true;
            new Thread(new ThreadStart(NotifyBitcoin)).Start();
        }

        private void NotifyBitcoin()
        {
            BitcoinDriver bitcoin = new BitcoinDriver();

            while (allowRobot)
            {
                var cotacao = bitcoin.obterCotação();
                if (cotacao <= 98000)
                {
                    notify.ShowBalloonTip(5, "Opa!", "O valor do bitcoin está em " + cotacao.ToString(), ToolTipIcon.Warning);
                }
                Thread.Sleep(TimeSpan.FromSeconds(60));
            }
            bitcoin.CloseBrowser();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            allowRobot = false;
            BitcoinDriver bitcoin = new BitcoinDriver();
            bitcoin.ComprarBitcoin();

        }
    }
}