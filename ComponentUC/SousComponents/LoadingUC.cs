using System;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    public partial class LoadingUC : UserControl
    {
        private Timer timer;
        public bool isRun = false;
        private Panel pan = null;
        private Panel parent = null;
        private int n = 1;

        public LoadingUC()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            timer = new Timer
            {
                Enabled = true,
                Interval = 5
            };
            timer.Tick += Clock;

            progressBox.Value = 0;

            // Optimisation
            this.DoubleBuffered = true;
            this.UpdateStyles();
        }

        public void SetTimeInterval(int i)
        {
            n = i;
        }

        public void ToResize()
        {
            Size = this.Parent.Size;
            Location = new System.Drawing.Point(0, 0);
        }

        public void ToResize(Size s, Point p)
        {
            Size = s;
            Location = p;
        }

        public void Play()
        {
            this.Visible = true;
            progressBox.Value = 0;
            this.BringToFront();
            isRun = true;
            timer.Start();
        }

        public void Play(Panel p, Panel parent)
        {
            this.Visible = true;
            pan = p;
            pan.Visible = false;
            progressBox.Value = 0;
            this.BringToFront();
            isRun = true;
            this.parent = parent;
            timer.Start();
        }

        private void Clock(object sender, EventArgs e)
        {
            if (progressBox.Value < progressBox.MaxValue)
            {
                progressBox.Value += n;
                progressBox.Invalidate();
                progressBox.Update();

                string[] liste = new string[12] {
                    "◙             ",
                    " ◙            ",
                    "  ◙           ",
                    "   ◙          ",
                    "    ◙         ",
                    "     ◙        ",
                    "      ◙       ",
                    "       ◙      ",
                    "        ◙     ",
                    "         ◙    ",
                    "          ◙   ",
                    "           ◙  ",
                };

                for (int i = 0; i < liste.Length; i++)
                {
                    if (labelLoading.Text == liste[i])
                    {
                        if (i < liste.Length - 1)
                        {
                            labelLoading.Text = liste[i + 1];
                            break;
                        }
                        else
                            labelLoading.Text = liste[0];
                    }
                }
            }

            else
            {
                isRun = false;
                this.Visible = false;
                if (pan != null) pan.Visible = true;
                if (parent != null)
                {
                    Parent.Controls.Remove(this);
                    parent.Controls.Add(this);
                    ToResize();
                }
                pan = null;
                timer.Stop();
            }
        }
    }
}
