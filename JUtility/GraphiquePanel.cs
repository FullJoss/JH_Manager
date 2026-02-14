using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.JUtility
{
    internal class GraphiquePanel : Panel
    {
        public GraphiquePanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
