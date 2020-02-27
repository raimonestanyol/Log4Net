using System;
using System.Windows.Forms;
using log4net;
using System.Configuration;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog logger = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This class is empty
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info("whatever");
            log4net.Config.XmlConfigurator.Configure();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var sAttr = ConfigurationManager.AppSettings["FileName"].ToString();
            MessageBox.Show(sAttr);
        }
    }
}
