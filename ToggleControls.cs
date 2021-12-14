
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EducationCapstoneChecker
{
    class ToggleControls : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        /*    public Color OnBackColor
            {
                get => onBackColor;
                set
                {
                    onBackColor = value;
                    this.Invalidate();
                }
            }
            public Color OnToggleColor
            {
                get => onToggleColor;
                set
                {
                    onToggleColor = value;
                    this.Invalidate();
                }
            }
            public Color OffBackColor
            {
                get => offBackColor;
                set
                {
                    offBackColor = value;
                    this.Invalidate();
                }
            }
            public Color OffToggleColor
            {
                get => offToggleColor;
                set
                {
                    offToggleColor = value;
                    this.Invalidate();
                }
            }*/

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {

            }
        }

        public Color OnBackColor1
        {
            get => onBackColor;
            set => onBackColor = value;
        }
        public Color OnToggleColor1
        {
            get => onToggleColor;
            set => onToggleColor = value;
        }
        public Color OffBackColor1
        {
            get => offBackColor;
            set => offBackColor = value;
        }
        public Color OffToggleColor1
        {
            get => offToggleColor;
            set => offToggleColor = value;
        }

        public ToggleControls()
        {
            this.MinimumSize = new Size(45, 22);
            this.BackColor = Color.White;
        }

        private GraphicsPath GetFigurePath()
        {

            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);

            return path;
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            int toggleSize = this.Height - 5;
            paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //this.Parent.BackColor = Color.White;
            //paintEvent.Graphics.Clear(this.Parent.BackColor);
            //this.Parent.BackColor = Color.White; //TO CHANGE, SET THIS TO THE THEME COLOR 

            if (this.Checked) //ON
            {
                paintEvent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath()); //Draw Control Surface
                paintEvent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize)); //Draw Toggle
            }
            else //OFF
            {
                paintEvent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                paintEvent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
