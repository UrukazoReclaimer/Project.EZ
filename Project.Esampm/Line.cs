
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Esampm
{
  public  class Line
    {

        private Point m_point1 = new Point(0,0);
        private Point m_point2 = new Point(0,0);
       
        public Point Point1
        {
            get { return m_point1; }
            set { m_point1 = value; }
        }

        public Point Point2
        {
            get { return m_point2; }
            set { m_point2 = value; }
        }


        public void Draw(Graphics grfx)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

            Pen pen = new Pen(Color.Black);    
            grfx.DrawLine(pen,Point1,Point2);
       

        }
        public void DrawWhite(Graphics grfx)
        {
            if ((grfx == null))
                throw new ArgumentNullException("grfx");

            Pen pen = new Pen(Color.White);
    
            grfx.DrawLine(pen, Point1, Point2);

        }
    }
}
