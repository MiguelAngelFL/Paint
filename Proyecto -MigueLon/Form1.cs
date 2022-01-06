using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto__Miguel
{
    public partial class Form1 : Form
    {

        Color Micolor;
        Bitmap Mibitmap;
        List<Point> Pixeles;
        List<Point> Aux;
        List<Point> Aux2;
        int Opcion;
        int TamPixel;
        int i, j;
        int Lados;
        int Radio;
        int Rx, Ry;
        int Px, Py;
        int CX, CY;
        Color CFondo;
        int Contador = 0;
        String Estilo;
        Stack<Point> Vecinos = new Stack<Point>();
        Random Aleatorios = new Random();
        int ContadorEstilos = 2;
       int CGuion = 1;
        int Pasada = 0;
        int Saltos = 0;
        int SaltosLargos = 0;




        public Form1()
        {
            InitializeComponent();

            Micolor = Color.Black;
            Mibitmap = new Bitmap(ptb.Width, ptb.Height);
            Pixeles = new List<Point>();
            Aux = new List<Point>();
            Aux2 = new List<Point>();
            TamPixel = 2;
            Opcion = 0;
            Lados = 0;
            Radio = 100;
            i = 0;
            Rx = Radio;
            Ry = Radio;
            Estilo = "--------";
            BtnColorActual.BackColor = Micolor;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Mibitmap = new Bitmap(ptb.Width, ptb.Height);
            BotonRellenar.Location = new Point(575, 28);
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = false;
            LabelRadio.Visible = false;
            LabelEstiloActual.Text = Estilo;
            LabelEstiloActual.Location = new Point(46, 20);

           
       }

        


        //Botones
        #region Botones

        private void Color_Rojo(object sender, EventArgs e)
        {
            Micolor = Color.Red;
            BtnColorActual.BackColor = Micolor;


        }

        private void Color_Azul(object sender, EventArgs e)
        {
            Micolor = Color.Blue;
            BtnColorActual.BackColor = Micolor;
        }

        private void Color_Verde(object sender, EventArgs e)
        {
            Micolor = Color.Green;
            BtnColorActual.BackColor = Micolor;

        }

        private void Color_Rosa(object sender, EventArgs e)
        {
            Micolor = Color.Pink;
            BtnColorActual.BackColor = Micolor;


        }

        private void Paleta_Colores(object sender, EventArgs e)
        {
            ColorDialog paleta = new ColorDialog();
            paleta.ShowDialog();
            Micolor = paleta.Color;
            BtnColorActual.BackColor = Micolor;
        }

        private void Tamaño_PixelChico(object sender, EventArgs e)
        {
            TamPixel = 2;
            LabelTamañoPixel.Text = "Chico 2px";
        }

        private void Tamaño_PixelMediano(object sender, EventArgs e)
        {
            TamPixel = 3;
            LabelTamañoPixel.Text = "Mediano 3px";
        }

        private void Tamaño_PixelGrande(object sender, EventArgs e)
        {

            TamPixel = 4;
            LabelTamañoPixel.Text = "Grande 4px";
        }

        private void Boton_Pixel(object sender, EventArgs e)
        {
            Opcion = 1;
            BotonRellenar.Location = new Point(575, 28);
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = false;
            LabelRadio.Visible = false;
        }

        private void Boton_Recta(object sender, EventArgs e)
        {
            Opcion = 2;
            BotonRellenar.Location = new Point(575, 28);
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = false;
            LabelRadio.Visible = false;
            Pixeles.Clear();
            Saltos = 5;
            SaltosLargos = 10;
            CGuion = 1;
            Pasada = 0;
        }
        private void Boton_Poligono_Irregular(object sender, EventArgs e)
        {

            Opcion = 3;
            LabelRadio.Location = new Point(708, 11); 
            ValorRadio.Location = new Point(704, 29);
            BotonRellenar.Location = new Point(756, 27);
            OpcionLadosPoligonos.Visible = true;
            ValorRadio.Visible = true;
            LabelRadio.Visible = true;
            Pixeles.Clear();
            Saltos = 5;
            SaltosLargos = 10;
            CGuion = 1;
            Pasada = 0;
        }

        private void Boton_Poligono_Regular(object sender, EventArgs e)
        {

            Opcion = 4;
            LabelRadio.Location = new Point(708, 11);
            ValorRadio.Location = new Point(704, 29);
            BotonRellenar.Location = new Point(756, 27);
            OpcionLadosPoligonos.Visible = true;
            ValorRadio.Visible = true;
            LabelRadio.Visible = true;
            Pixeles.Clear();
            Saltos = 5;
            SaltosLargos = 10;
            CGuion = 1;
            Pasada = 0;
        }
        private void ValorRadio_ValueChanged(object sender, EventArgs e)
        {
            Radio = Convert.ToInt32(ValorRadio.Value);
            Rx = Radio;
            Ry = Radio;
        }

        private void Boton_Circulo(object sender, EventArgs e)
        {
            Opcion = 6;
            Pixeles.Clear();
            BotonRellenar.Location = new Point(622, 27);
            ValorRadio.Location = new Point(575, 30);
            LabelRadio.Location = new Point(579, 12);
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = true;
            LabelRadio.Visible = true;
            Saltos = 15;
            SaltosLargos = 30;
        }

        private void UnirVerticesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcion = 8;
        }

        private void EstiloNormal_Click(object sender, EventArgs e)
        {
            Estilo = "--------";
            LabelEstiloActual.Text = Estilo;
            LabelEstiloActual.Location = new Point(46, 20);
        }

        private void EstiloGuion_Click(object sender, EventArgs e)
        {
            Estilo = "- - - - -";
            LabelEstiloActual.Text = Estilo;
            LabelEstiloActual.Location = new Point(46, 20);
        }

        private void EstiloPunto_Click(object sender, EventArgs e)
        {
            Estilo = ". . . . .";
            LabelEstiloActual.Text = Estilo;
            LabelEstiloActual.Location = new Point(46, 16);
        }

        private void BotonRellenar_Click(object sender, EventArgs e)
        {
            Opcion = 7;
        }


        private void Boton_Elipse(object sender, EventArgs e)
        {
            Opcion = 5;
            Pixeles.Clear();
            BotonRellenar.Location = new Point(622, 27);
            ValorRadio.Location = new Point(575, 30);
            LabelRadio.Location = new Point(579, 12);
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = true;
            LabelRadio.Visible = true;
            Saltos = 15;
            SaltosLargos = 30;
        }

        private void LadosPoligonos_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (OpcionLadosPoligonos.Text == "3-Triangulo")
            {
                Lados = 3;

            }


            if (OpcionLadosPoligonos.Text == "4-Cuadrado")
            {
                Lados = 4;
            }
            if (OpcionLadosPoligonos.Text == "4-Rectangulo")
            {
                Lados = 4;
               
                Contador = 0;
            }

            if (OpcionLadosPoligonos.Text == "5-Pentágono")
            {
                Lados = 5;
            }
            if (OpcionLadosPoligonos.Text == "6-Hexágono")
            {
                Lados = 6;
            }
            if (OpcionLadosPoligonos.Text == "7-Heptágono")
            {
                Lados = 7;
            }
            if (OpcionLadosPoligonos.Text == "8-Octágono")
            {
                Lados = 9;
            }
            if (OpcionLadosPoligonos.Text == "9-Eneágono")
            {
                Lados = 9;
            }
            if (OpcionLadosPoligonos.Text == "10-Decágono")
            {
                Lados = 10;
            }

        }

        private void MenuAyudaPixel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Dibujar Pixeles, Haga Click en el boton Pixel y Seleccione cualquier parte del area de dibujo.", "Pixel");
        }

        private void MenuAyudaRecta_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Para Dibujar una Recta Selecione el boton Recta y haga Click 2 veces en el area de Dibujo.", "Recta");
        }

      

        private void MenuAyudaIrregular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la Opción Polígono Irregular y Elija la cantidad de lados que tendrá. Después seleccione los puntos deseados en el área de dibujo.", "Dibujar Poligono Irregular");
        }

        private void MenuAyudaRegular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la Opción Polígono Regular y Elija la cantidad de lados que tendrá. Después seleccione Cualquier Parte del Area de Dibujo. " + " Nota: Con el Boton Radio se Pude Cambiar el Tamaño de las Figuras.", "Dibujar Poligono Regular");
        }

        private void MenuAyudaCirculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la Opción Circulo y Seleccione Cualquier Parte del area de dibujo. " + " Nota: Con el Boton Radio se Pude Cambiar el Tamaño del Circulo.", "Dibujar Circulo");
        }

        private void MenuAyudaElipse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la Opción Elipse y Seleccione Cualquier Parte del area de dibujo. " + " Nota: Con el Boton Radio se Pude Cambiar el Tamaño del Elipse.", "Dibujar Elipse");
        }

        private void MenuTamaño_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el Apartado Tamaño, Seleccione la Opcion Deseada Chico, Mediano y Grande", "Cambiar Tamaño del Pixel");
        }

        private void MenuAyudaColores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el Apartado colores seleccione  un Color o haga click en la paleta de colores y eliga el color deseado. El color que haya sido seleccionado aparecera en el recuadro de color actual", "Paleta de colores");

        }

        private void MenuAyudaRellenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el Boton rellenar y Despues haga click dentro de la Figura a rellenar. " + " Nota: Solo Funciona en Areas Cerradas.", "Rellenar");
        }

        private void MenuAyudaLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el boton Limpiar Para Limpiar el Area de dibujo", "Limpiar Area de Dibujo");
        }

        private void MenuAyudaEstilos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el Apartado estilos, Seleccione el Estilo de Pintado de Su preferencia y Seleccione Cualquier Figura o Recta Para Comensar a Pintar.", "Estilos");

        }
        private void BloquearTexto(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }


        private void Boton_Limpiar(object sender, EventArgs e)
        {
            BotonRellenar.Location = new Point(575, 28);
            ptb.MouseMove -= ptb_MouseClick;
            ptb.Image = null;
            TamPixel = 2;
            Mibitmap = new Bitmap(ptb.Width, ptb.Height);
            Opcion = 0;
            BtnColorActual.BackColor = Color.Black;
            Micolor = Color.Black;
            Lados = 0;
            OpcionLadosPoligonos.Visible = false;
            ValorRadio.Visible = false;
            LabelRadio.Visible = false;
            OpcionLadosPoligonos.Text = ("Elija una opcion");
            LabelTamañoPixel.Text = "Chico 2px";

        }

        #endregion

        //Evento MauseClick
        #region MauseClick

        public void ptb_MouseClick(object sender, MouseEventArgs e)
        {
            

              switch (Opcion)
            {
                case 1:
                    //Pixel
                    TPixel(e.X, e.Y, Micolor);
                    break;
                case 2:
                    // Recta

                    Pixeles.Add(new Point(e.X, e.Y));
                    TPixel(e.X, e.Y, Micolor);
                    if (Pixeles.Count == 2)
                    {
                        Recta(Pixeles, Micolor);

                        Pixeles.Clear();
                    }

                    break;
                case 3:
                    //poligono Irregular

                    if (Lados == 0)
                    {
                        MessageBox.Show("Elija una Opcion Primero", "Aviso");
                    }
                    else
                    {
                        Pixeles.Add(new Point(e.X, e.Y));
                        TPixel(e.X, e.Y, Micolor);

                        if (Pixeles.Count == Lados)
                        {
                            PoligonoIrregular(Pixeles, Micolor);
                            Pixeles.Clear();
                        }
                    }

                    break;

                case 4:
                    
                        //Poligono Regular

                        if (OpcionLadosPoligonos.Text == "4-Rectangulo")
                        {
                            
                            Ry = Radio / 2;
                            Px = e.X;
                            Py = e.Y;
                            Rectangulo(Px, Py);
                            
                        }
                        else
                        {

                        if (Lados == 0)
                        {
                            MessageBox.Show("Elija una Opcion Primero", "Aviso");
                        }
                        else
                        {
                            Pixeles.Clear();
                            Pixeles.Add(new Point(e.X, e.Y));
                            PoligonoRegular(Pixeles, Micolor);


                        }
                    }


                    
                    break;

                //Elipse
                case 5:
                    Ry = Radio / 2;

                    Pixeles.Add(new Point(e.X, e.Y));
                    Elipse(Pixeles, Rx, Ry);

                    Pixeles.Clear();
                    break;

                //Circulo
                case 6:
                    Ry = Radio;

                    Pixeles.Add(new Point(e.X, e.Y));
                    Elipse(Pixeles, Rx, Ry);

                    Pixeles.Clear();
                    break;

                //Rellenar
                case 7:
                   

                    Relleno(e.X, e.Y,Micolor);


                    break;
               
                
                   

            }

            ptb.Image = Mibitmap;



        }

        #endregion

        //Metodos
        #region Metodos

        public void Rectangulo(int Px, int Py)
        {

            try
            { 
          
                
                PintarEstilos(Px, Py, Micolor);
                Contador = 0;

            while (Contador < Rx*2)
            {
                  
                    PintarEstilos(Px + Contador, Py, Micolor);


                    Contador++;
            }
            Contador = 0;

            while (Contador <= Ry*2)
            {
                   
                    PintarEstilos(Px, Py + Contador, Micolor);



                    Contador++;
               
            }
             Contador = 0;
          
            Py = Py+ Ry * 2;
            while (Contador < Rx*2)
            {

                    
                    PintarEstilos(Px + Contador, Py, Micolor);


                    Contador++;
            }
            Contador = 0;
            Px = Px + Rx * 2;
            while (Contador <=Ry*2)
            {
                    PintarEstilos(Px, Py - Contador, Micolor);
                   


                Contador++;

            }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        
        public void Relleno(int x, int y, Color CRelleno)
        {
           
             CFondo = Mibitmap.GetPixel(x, y);

            
            if (CFondo.ToArgb() == Micolor.ToArgb())
            {

               
                MessageBox.Show("Ya esta rellenado de ese color","Aviso");
                
            }
            else {
                

                Vecinos.Push(new Point(x, y));
               

                while (Vecinos.Count != 0)
                {

                    Point Punto = Vecinos.Pop();


                    if (Punto.X >= 0 && Punto.X < ptb.Width && Punto.Y >= 0 && Punto.Y < ptb.Height)
                    {

                    if (Mibitmap.GetPixel(Punto.X, Punto.Y) != CRelleno && Mibitmap.GetPixel(Punto.X, Punto.Y) == CFondo)
                   

                    {
                         Mibitmap.SetPixel(Punto.X, Punto.Y, CRelleno);
                         Vecinos.Push(new Point(Punto.X + 1, Punto.Y));
                         Vecinos.Push(new Point(Punto.X - 1, Punto.Y));
                         Vecinos.Push(new Point(Punto.X, Punto.Y + 1));
                         Vecinos.Push(new Point(Punto.X, Punto.Y - 1));
                            


                        }



                    }
                    

                }
               
            }

        }

        public void Elipse(List<Point> Pixeles, int Rx, int Ry)
        {

            int x, y, e,X,Y;
            x = 0;
            y = Ry;
            ContadorEstilos = 2;
            CGuion = 1;
            Pasada = 0;


            e = 2 * Ry * Ry + (1 - 2 * Ry) * (Rx * Rx);
            while (Ry * Ry * x <= Rx * Rx * y)
            {
                X = Pixeles[0].X + x;
                Y= Pixeles[0].Y + y;
                PintarEstilos(X,Y, Micolor);
                X = Pixeles[0].X - x;
                Y = Pixeles[0].Y + y;
                PintarEstilos(X, Y, Micolor);
                X = Pixeles[0].X + x;
                Y = Pixeles[0].Y - y;
                PintarEstilos(X, Y, Micolor);
                X = Pixeles[0].X - x;
                Y = Pixeles[0].Y - y;
                PintarEstilos(X, Y, Micolor);
                x++;
                if (e >= 0)
                {
                    e = e + 4 * Rx * Rx * (1 - y);
                    y--;

                }
                e = e + Ry * Ry * (4 * x + 6);
            }

            y = 0;
            x = Rx;
            e = 2 * Rx * Rx + (1 - 2 * Rx) * (Ry * Ry);
            while (Rx * Rx * y <= Ry * Ry * x)
            {
                X = Pixeles[0].X + x;
                Y = Pixeles[0].Y + y;
                PintarEstilos(X, Y, Micolor);
                X = Pixeles[0].X - x;
                Y = Pixeles[0].Y + y;
                PintarEstilos(X, Y, Micolor);
                X = Pixeles[0].X + x;
                Y = Pixeles[0].Y - y;
                PintarEstilos(X, Y, Micolor);
                X = Pixeles[0].X - x;
                Y = Pixeles[0].Y - y;
                PintarEstilos(X, Y, Micolor);

                y++; 
                if (e >= 0)
                {
                    e = e + 4 * Ry * Ry * (1 - x);
                    x--; 

                }
                e = e + Rx * Rx * (4 * y + 6);

            }


        }


        public void PoligonoRegular(List<Point> Pixeles, Color Micolor)
        {
            double Angulo, X, Y, i;

            Aux2.Clear();
            Angulo = 360/ Lados;

            
            for (i = 0; i < 360; i += Angulo)
            {

                X = Pixeles[0].X + Radio * Math.Cos(i * Math.PI / 180);
                Y = Pixeles[0].Y + Radio * Math.Sin(i * Math.PI / 180);

                Aux2.Add(new Point(Convert.ToInt32(Math.Round(X)), Convert.ToInt32(Math.Round(Y))));


            }

            PoligonoIrregular(Aux2, Micolor);
           

        }



        public void PoligonoIrregular(List<Point> Pixeles, Color Micolor)
        {

            try
            {

                for (int i = 0; i < Pixeles.Count - 1; i++)
                {


                    Aux.Add(new Point(Pixeles[i].X, Pixeles[i].Y));
                    Aux.Add(new Point(Pixeles[i + 1].X, Pixeles[i + 1].Y));
                    Recta(Aux, Micolor);
                    Aux.Clear();



                }

                Aux.Add(new Point(Pixeles[0].X, Pixeles[0].Y));
                Aux.Add(new Point(Pixeles[Pixeles.Count - 1].X, Pixeles[Pixeles.Count - 1].Y));


                Recta(Aux, Micolor);
                Aux.Clear();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);


            }


        }


        public void TPixel(int CordX, int CordY, Color Micolor)
        {


            for (i = 0; i < TamPixel; i++)
            {

                for (j = 0; j < TamPixel; j++)
                {
                    
                    VPixel(CordX + i, CordY + j, Micolor);


                }
            }
        }
       public void VPixel(int CordX, int CordY, Color Micolor)
        {


            if (CordX >= 0 && CordX < ptb.Width && CordY >= 0 && CordY < ptb.Height)
            {
                Mibitmap.SetPixel(CordX, CordY, Micolor);

            }
        }
        

        public void Recta(List<Point> Pixeles, Color Micolor)
        {
            ContadorEstilos=2;
            
            int Dx, Dy, IncX, IncY, X, Y, E;
            Dx = Pixeles[1].X - Pixeles[0].X;
            Dy = Pixeles[1].Y - Pixeles[0].Y;

            if (Dx > 0)
            {
                IncX = 1;
            }
            else
            {
                IncX = -1;
                Dx = -Dx;
            }

            if (Dy > 0)
            {
                IncY = 1;
            }
            else
            {
                IncY = -1;
                Dy = -Dy;
            }

            X = Pixeles[0].X;
            Y = Pixeles[0].Y;

            if (Dx > Dy)
            {

                
                E = 2 * Dy - Dx;

                while (X != Pixeles[1].X)
                {
                    if (E < 0)
                    {

                        X = X + IncX;
                        E = E + 2 * Dy;
                       
                    }
                    else
                    {
                        
                        X = X + IncX;
                        Y = Y + IncY;
                        E = E + 2 * Dy - 2 * Dx;
                       
                    }
                  
                    PintarEstilos(X, Y, Micolor);
                    
                    

                }
            }
            else
            {
                E = 2 * Dx - Dy;

                
                while (Y != Pixeles[1].Y)
                {
                    if (E < 0)
                    {
                        Y = Y + IncY;
                        E = E + 2 * Dx;
                      

                    }
                    else
                    {
                        Y = Y + IncY;
                        X = X + IncX;
                        E = E + 2 * Dx - 2 * Dy;
                       
                        
                    }

                    PintarEstilos(X, Y, Micolor);
                    



                }
            }


        }

      

        public void PintarEstilos(int X, int Y, Color Micolor)
        { int Te =0;
         
            if(Estilo== "--------")
            {
                TPixel(X, Y, Micolor);
            }

            if (Estilo == ". . . . .")
            {


                if (TamPixel == 2)
                {
                    Te = 3;

                }
                if (TamPixel != 2)
                {
                    Te = 5;

                }

                if (ContadorEstilos % Te == 0)
                {
                    TPixel(X, Y, Micolor);

                }

                ContadorEstilos += 1;
            }
            if (Estilo == "- - - - -")
            {
                
                
                
               
                if (CGuion<=Saltos)
                {
                    TPixel(X, Y, Micolor);
                    CGuion++;
                    
                }
                else
                {
                    Pasada++;
                    if (Pasada == SaltosLargos)
                    {
                        CGuion = 1;
                        Pasada = 0;
                    }
                }
                
            }
        }

        
        
   
        
        #endregion

       



       


    }







}


