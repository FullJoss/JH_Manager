using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class ManagerUserUC : UserControl
    {
        private Timer timer;
        public ManagerUserUC()
        {
            InitializeComponent();

            timer = new Timer()
            {
                Interval = 1000,
                Enabled = true
            };

            timer.Tick += Actualisation;

            name.Text = $"Nom : {Bigdata.user.Name}";

            timeBegin.Text = Bigdata.user.timeBegin.ToString("HH:mm:ss");
            time.Text = Bigdata.user.time.ToString("HH:mm:ss");
            modN.Text = Bigdata.user.NMod.ToString();

            timer.Start();

            BarProg.MaximumValue = 100;
        }

        private void Actualisation(object sender, EventArgs e)
        {
            //Evaluation
            DateTime d1 = Bigdata.user.time;
            DateTime d2 = DateTime.MaxValue;
            float x = (d1.Hour * 3600 + d1.Minute * 60 + d1.Second) / (d2.Hour * 3600 + d2.Minute * 60 + d2.Second);

            BarProg.ProgressValue = (int)(x * 100);
            time.Text = Bigdata.user.time.ToString("HH:mm:ss");

            panelContainerTime.Invalidate();
        }

        private void chgUser_Click(object sender, EventArgs e)
        {

        }

        private void chgMdp_Click(object sender, EventArgs e)
        {
            panelChange.Visible = true;
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            panelChange.Visible = false;
        }

        private void btnLetsChange_Click(object sender, EventArgs e)
        {
            Bigdata.user = new DataManager.User(inputName.Content, inputMdp.Content,
                Bigdata.user.timeBegin, Bigdata.user.NMod); panelChange.Visible = false;
        }
    }
}
