using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JH_Manager.JUtility
{
    public partial class CustomTextBox : UserControl
    {
        private TextBox textBox;

        public int MarginT { get; set; } = 10;
        public bool IsRounded { get; set; } = true;
        public Color FillColor { get; set; } = Color.White;
        public Color BorderColor { get; set; } = Color.Black;

        private string _placeholder;
        public string Placeholder { get => _placeholder; set { _placeholder = textBox.Text = value; textBox.ForeColor = Color.Gray; this.Invalidate(); } }
        public string Content
        {
            get
            {
                if (textBox.ForeColor != Color.Black)
                    return "";
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
                textBox.ForeColor = Color.Black;
            }
        }

        public CustomTextBox()
        {
            InitializeComponents();

            this.Resize += TToResize;

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void TToResize(object sender, EventArgs e)
        {
            textBox.Width = Width - MarginT * 2;

            int y = (Height - textBox.Height) / 2;
            textBox.Location = new Point(MarginT, y);

        }

        private void InitializeComponents()
        {

            // Initialiser le TextBox avec des paddings et une bordure arrondie
            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Location = new Point(0, 0),
                Width = this.Width - 20,
                Multiline = false,
                Text = _placeholder,
                ForeColor = Color.Gray,
                Font = new Font("Arial", 9f),
                Height = Font.Height,
            };
            textBox.GotFocus += GotFocusTxt;
            textBox.LostFocus += LostFocusTxt;

            this.Padding = new Padding(10);
            this.Size = new Size(200, 35);
            this.Controls.Add(textBox);
            this.BackColor = Color.Transparent;

            // Assurer que le contrôle redimensionne correctement
            this.Resize += (s, e) => textBox.Size = new Size(this.Width - 20, this.Height - 20);

            textBox.BackColor = FillColor;

            // Evenement
            textBox.TextChanged += OnTextChanged;
            textBox.KeyDown += OnEnterTouch;

            TToResize(textBox, new EventArgs());
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, e);
        }

        public event EventHandler EnterTouch;
        public event EventHandler ContentChanged;

        private void OnEnterTouch(object sender, KeyEventArgs e)
        {
            EnterTouch?.Invoke(this, e);
        }

        private void LostFocusTxt(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = _placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void GotFocusTxt(object sender, EventArgs e)
        {
            if (textBox.Text == _placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        // Dessiner les bordures arrondies
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderRadius = IsRounded ? 8 : 3;
            using (GraphicsPath path = new GraphicsPath())
            {
                if (IsRounded)
                {
                    path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                    path.AddArc(this.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                    path.AddArc(this.Width - borderRadius - 1, this.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                    path.AddArc(0, this.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                }
                else
                {
                    path.AddLine(0, this.Height - 1, this.Width - 1, this.Height - 1);
                }
                path.CloseFigure();

                SolidBrush brush = new SolidBrush(FillColor);

                e.Graphics.FillPath(brush, path);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(new Pen(BorderColor, (IsRounded ? 1 : .7f)), path);
            }
        }
    }
}
