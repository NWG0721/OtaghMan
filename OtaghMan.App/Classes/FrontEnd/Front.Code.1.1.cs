using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace OtaghMan.App
{
    public class NewButton1 : Button
    {

        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color boardercolor = Color.PaleVioletRed;
        //Fields

        //Constructor
        public NewButton1()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;

        }
        //Constructor

        //methods
        private GraphicsPath GetFigurePath(RectangleF rect, float raidus)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, raidus, raidus, 180, 90);
            path.AddArc(rect.Width - raidus, rect.Y, raidus, raidus, 270, 90);
            path.AddArc(rect.Width - raidus, rect.Height - raidus, raidus, raidus, 0, 90);
            path.AddArc(rect.X, rect.Height - raidus, raidus, raidus, 90, 90);
            path.CloseFigure();

            return path;
        }
        //methods

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            //Roudned button
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectSurface, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(boardercolor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    //Draw surface  boarder for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Draw surface  boarder for HD result

                    //Button border
                    if (borderSize >= 1)
                    {
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                        //Draw control border
                    }
                    //Button border

                }
            }//Roudned button
            else//Normal button
            {
                //Button surface
                this.Region = new Region(rectSurface);
                //Button surface

                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(boardercolor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
                //Button border
            }

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }


    }
}
