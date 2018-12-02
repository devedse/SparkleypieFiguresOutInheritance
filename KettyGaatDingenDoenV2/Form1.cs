using KettyGaatDingenDoenV2.Logerinos;
using System;
using System.Windows.Forms;

namespace KettyGaatDingenDoenV2
{
    public partial class Form1 : Form
    {
        private Berekenaar berekenaar;
        private ILogger _logger;

        public Form1()
        {
            InitializeComponent();

            _logger = new SchermLogger(this);
            berekenaar = new Berekenaar(_logger);

            _logger.WriteLog("De applicatie start");

            _logger.WriteLogMetDateTime("Test2");



        }

        private void plus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            var resultaat = berekenaar.Plus(a, b);
            textBox3.Text = resultaat.ToString();
        }

        private void vermenigvuldigen_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            var resultaat = berekenaar.Vermenigvuldigen(a, b);
            textBox3.Text = resultaat.ToString();
        }
    }
}
