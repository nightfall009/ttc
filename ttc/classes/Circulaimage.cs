using System.Drawing.Drawing2D;
using System.Windows.Forms;




namespace ttc
{
    public class Circulaimage : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath G = new GraphicsPath();
            G.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(G);
            base.OnPaint(pevent);


        }
    }
}
