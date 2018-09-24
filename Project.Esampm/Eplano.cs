using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Esampm
{
    public partial class Eplano : Form
    {
        List<Triangulo> Tcoleccion;
        List<Rombo> Rcoleccion;
        List<Rectangulo> Reccoleccion;
        Triangulo Tselec, objtri;
        Rombo Rselec, objrom;
        Rectangulo recselect, objromrec;
        Point pos;
        Graphics g;
        ToolSelec toolselec;
        bool clic, otra;
        public enum ToolSelec
        {
            puntero, triangulo, rombo,  cuadrado
        }
        public Eplano()
        {
            InitializeComponent();
        }

        private void Eplano_Load(object sender, EventArgs e)
        {
            clic = false;

            Tselec = null;
            Rselec = null;
            recselect=null;
            objtri = new Triangulo();
            objrom = new Rombo();
            objromrec =new Rectangulo();

            Tcoleccion = new List<Triangulo>();
            Rcoleccion = new List<Rombo>();
            Reccoleccion = new List<Rectangulo>();
            toolselec = ToolSelec.puntero;
            toolPuntero.Checked = true;
            toolTriangulo.Checked = false;
            toolRombo.Checked = false;
            toolStripRectangulo.Checked = false;
            g = AreaDraw.CreateGraphics();    

        }

        private void AreaDraw_Paint(object sender, PaintEventArgs e)
        {
            foreach (Triangulo item in Tcoleccion)
            {
                item.Dibujar(e.Graphics);
            }
            foreach (Rombo item in Rcoleccion)
            {
                item.Dibujar(e.Graphics);
            }
            foreach (Rectangulo item in Reccoleccion)
            {
                item.Dibujar(e.Graphics);
            }
        }

        private void AreaDraw_MouseDown(object sender, MouseEventArgs e)
        {
            switch (toolselec)
            {
                case ToolSelec.puntero:
                    #region Seleccion Figura
                    foreach (Triangulo item in Tcoleccion)
                    {
                        Point p = AreaDraw.PointToClient(Cursor.Position);
                        if (item.Dentro(p))
                        {
                            Tselec = item;
                            pos = p;
                            break;
                        }
                    }
                    foreach (Rombo item in Rcoleccion)
                    {
                        Point p = AreaDraw.PointToClient(Cursor.Position);
                        if (item.Dentro(p))
                        {
                            Rselec = item;
                            pos = p;
                            break;
                        }
                    }
                    #endregion
                    break;

                case ToolSelec.triangulo:
                    //Punto Inicial   
                    #region Guardar punto inicial
                    foreach (Triangulo item in Tcoleccion)
                    {
                        Point p = AreaDraw.PointToClient(Cursor.Position);
                        if (Tcoleccion.Count != 0 & item.Dentro(p))
                        {
                            MessageBox.Show("No puede dibujar dentro de una figura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            toolTriangulo.Checked = false;
                            toolPuntero.Checked = true;
                            toolselec = ToolSelec.puntero;
                            clic = false;
                            goto salida;
                        }
                        clic = true;
                        objtri.PI = e.Location;
                        objtri.PF = e.Location;
                    }
                    clic = true;
                    objtri.PI = e.Location;

                salida: break;

                    #endregion Guardar punto inicial
                case ToolSelec.rombo:
                    //Punto Inicial
                    #region Guarda punto inicial
                    foreach (Rombo item in Rcoleccion)
                    {
                        Point p = AreaDraw.PointToClient(Cursor.Position);
                        if (Rcoleccion.Count != 0 & item.Dentro(p))
                        {
                            MessageBox.Show("No puede dibujar dentro de una figura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            toolRombo.Checked = false;
                            toolPuntero.Checked = true;
                            toolselec = ToolSelec.puntero;
                            clic = false;
                            goto salir;
                        }
                        clic = true;
                        objrom.puntoInicial = e.Location;
                        objrom.puntoFinal = e.Location;
                    }
                    clic = true;
                    objrom.puntoInicial = e.Location;
                salir: break;
                    #endregion Guarda punto inicial

                case ToolSelec.cuadrado:
                    //Punto Inicial
                    #region Guarda punto inicial
                    foreach (Rectangulo item in Reccoleccion)
                    {
                        Point p = AreaDraw.PointToClient(Cursor.Position);
                        if (Rcoleccion.Count != 0 & item.Dentro(p))
                        {
                            MessageBox.Show("No puede dibujar dentro de una figura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            toolStripRectangulo.Checked = false;
                            toolPuntero.Checked = true;
                            toolselec = ToolSelec.puntero;
                            clic = false;
                            goto sali;
                        }
                        clic = true;
                        objromrec.puntoInicial = e.Location;
                        objromrec.puntoFinal = e.Location;
                    }
                    clic = true;
                    objrom.puntoInicial = e.Location;
                sali: break;
                    #endregion Guarda punto inicial
               
            }


        }

        private void AreaDraw_MouseUp(object sender, MouseEventArgs e)
        {
            //Debes fijarte donde desactivar rseleccion y tseleccion
            switch (toolselec)
            {
                case ToolSelec.triangulo:
                    #region
                    if (objtri.PI != new Point(0, 0) & objtri.PF != new Point(0, 0) & (objtri.PI != objtri.PF))
                    {
                        Point ptMedio = new Point(objtri.PI.X - (objtri.PF.X - objtri.PI.X), objtri.PF.Y);
                        Tcoleccion.Add(new Triangulo(objtri.PI, ptMedio, objtri.PF));
                        AreaDraw.Invalidate();

                    }
                    #endregion
                    break;
                case ToolSelec.rombo:
                    #region
                    if (objrom.puntoInicial != new Point(0, 0) && objrom.puntoFinal != new Point(0, 0))
                    {
                        Point pt2 = new Point(objrom.puntoInicial.X - (objrom.puntoFinal.X - objrom.puntoInicial.X), objrom.puntoFinal.Y);
                        Point pt3 = new Point(objrom.puntoInicial.X, (objrom.puntoFinal.Y - objrom.puntoInicial.Y) + objrom.puntoFinal.Y);
                        Rcoleccion.Add(new Rombo(objrom.puntoInicial, pt2, pt3, objrom.puntoFinal));
                        AreaDraw.Invalidate();
                    }
                    #endregion
                    break;
                case ToolSelec.cuadrado:
                    #region
                    if (objrom.puntoInicial != new Point(0, 0) && objrom.puntoFinal != new Point(0, 0))
                    {
                        Point pt2 = new Point(objromrec.puntoInicial.X - (objromrec.puntoFinal.X - objromrec.puntoInicial.X), objromrec.puntoFinal.Y);
                        Point pt3 = new Point(objromrec.puntoInicial.X, (objromrec.puntoFinal.Y - objromrec.puntoInicial.Y) + objromrec.puntoFinal.Y);
                        Reccoleccion.Add(new Rectangulo(objromrec.puntoInicial, pt2, pt3, objromrec.puntoFinal));
                        AreaDraw.Invalidate();
                    }
                    #endregion
                    break;
            }
            //reestrableciendo valores
            Tselec = null;
            Rselec = null;
            recselect = null;
            clic = false;
            toolselec = ToolSelec.puntero;
            toolPuntero.Checked = true;
            toolTriangulo.Checked = false;
            toolRombo.Checked = false;
            toolStripRectangulo.Checked = false;
        }

        private void toolPuntero_Click(object sender, EventArgs e)
        {
            toolTriangulo.Checked = false;
            toolRombo.Checked = false;
            toolselec = ToolSelec.puntero;
        }

        private void toolTriangulo_Click(object sender, EventArgs e)
        {
            toolPuntero.Checked = false;
            toolRombo.Checked = false;
            toolselec = ToolSelec.triangulo;
        }

        private void toolRombo_Click(object sender, EventArgs e)
        {
            toolPuntero.Checked = false;
            toolTriangulo.Checked = false;
            toolselec = ToolSelec.rombo;
        }

        private void AreaDraw_MouseMove(object sender, MouseEventArgs e)
        {
            lbLocation.Text = ("X " + e.X + " , Y " + e.Y + " píxeles");
            switch (toolselec)
            {
                case ToolSelec.puntero:
                    #region Selección Figura
                    lbEstado.Text = "Estado: Puntero";
                    if (Tselec != null)
                    {
                        Tselec.Mover(e.Location.X - pos.X, e.Location.Y - pos.Y);
                        AreaDraw.Invalidate();
                        pos = e.Location;
                    }
                    else
                    {
                        if (Rselec != null)
                        {
                            Rselec.Mover(e.Location.X - pos.X, e.Location.Y - pos.Y);
                            AreaDraw.Invalidate();
                            pos = e.Location;
                        }
                    }
                    #endregion
                    break;
                case ToolSelec.triangulo:
                    #region Dibuja Triangulo
                    lbEstado.Text = "Estado: Dibujando Triángulo";
                    if (clic)
                    {
                        //if el segundo punto esta dentro de, entonces que mande mensaje
                        //y deje de dibujar                        
                        foreach (Triangulo item in Tcoleccion)
                        {
                            if (item.Dentro(e.Location) | item.Dentro(objtri.PF))
                            {
                                MessageBox.Show("No puede dibujar dentro de una figura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clic = false;
                                objtri.PI = new Point(0, 0);
                                objtri.PF = new Point(0, 0);
                                toolselec = ToolSelec.puntero;
                                toolTriangulo.Checked = false;
                                toolPuntero.Checked = true;
                                goto exit;
                            }
                        }
                        g = AreaDraw.CreateGraphics();
                        objtri.PF = e.Location;
                        g.Clear(Color.White);
                        objtri.DrawTriangulo(g, objtri.PI, objtri.PF);
                    }
                    #endregion
                exit: break;
                case ToolSelec.rombo:
                    #region Dibuja Rombo
                    lbEstado.Text = "Estado: Dibujando Rombo";
                    if (clic)
                    {

                        g = AreaDraw.CreateGraphics();
                        objrom.puntoFinal = e.Location;
                        g.Clear(Color.White);
                        objrom.DrawRombo(g, objrom.puntoInicial, objrom.puntoFinal);
                    }
                    #endregion
                    break;
            }            
        }

        private void toolStripRectangulo_Click(object sender, EventArgs e)
        {

        }

        private void ToolHerramientas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      
    }
}
