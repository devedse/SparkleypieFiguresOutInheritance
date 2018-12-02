namespace KettyGaatDingenDoenV2.Logerinos
{
    public class SchermLogger : ILogger
    {
        private readonly Form1 form;

        public SchermLogger(Form1 form)
        {
            this.form = form;
        }

        public override void WriteLog(string txt)
        {
            form.listBox1.Items.Insert(0, txt.ToString());
        }
    }
}
