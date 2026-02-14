using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager
{
    public partial class FormDebug : Form
    {
        private UserControl uc;
        public FormDebug()
        {
            InitializeComponent();

            uc = new ComponentUC.SousComponents.GraphXY("Test graphique", Color.FromArgb(32, 32, 32), Color.White, Color.Yellow);
            uc.Dock = DockStyle.Fill;

            Controls.Add(uc);
        }
    }
}
