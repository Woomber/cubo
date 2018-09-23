/*
 * FormCubo.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Interfaz Gráfica para dibujar un cubo
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matemáticas.Tipos.Transformaciones;
using Cubo.Tipos;
using Cubo.Procesos;


namespace Cubo
{
    public partial class FormCubo : Form
    {
        // Cubo a dibujar
        FiguraCubo cubo, defecto;
        int moveValue = 25;
        int angleValue = 10;

        // Constructor
        public FormCubo()
        {

            InitializeComponent();

            //Valores iniciales
            cubo = new FiguraCubo(
                600,
                300,
                0,
                trackZoom.Value,
                trackÁngulo.Value,
                0,
                0,
                0
            );
            defecto = new FiguraCubo(cubo);
            SincronizarValores();
        }

        /// <summary>
        /// Actualiza todos los valores del form para que 
        /// estén sincronizados con las variables
        /// </summary>
        void SincronizarValores()
        {

            trackZoom.Value = cubo.Zoom;
            nudZoom.Value = cubo.Zoom;

            trackÁngulo.Value = cubo.Ángulo;
            nudÁngulo.Value = cubo.Ángulo;

            nudRotX.Value = cubo.RotX;
            nudRotY.Value = cubo.RotY;
            nudRotZ.Value = cubo.RotZ;

            this.Refresh();
        }

        #region Eventos para actualizar el cubo

        private void trackZoom_Scroll(object sender, EventArgs e)
        {
            cubo.Zoom = trackZoom.Value;
            SincronizarValores();
        }

        private void nudZoom_ValueChanged(object sender, EventArgs e)
        {
            cubo.Zoom = Convert.ToInt32(nudZoom.Value);
            SincronizarValores();
        }

        private void trackÁngulo_Scroll(object sender, EventArgs e)
        {
            cubo.Ángulo = trackÁngulo.Value;
            SincronizarValores();
        }

        private void nudÁngulo_ValueChanged(object sender, EventArgs e)
        {
            cubo.Ángulo = Convert.ToInt32(nudÁngulo.Value);
            SincronizarValores();
        }

        private void nudRotX_ValueChanged(object sender, EventArgs e)
        {
            cubo.RotX = Convert.ToInt32(nudRotX.Value);
            SincronizarValores();
        }

        private void nudRotY_ValueChanged(object sender, EventArgs e)
        {
            cubo.RotY = Convert.ToInt32(nudRotY.Value);
            SincronizarValores();
        }

        private void nudRotZ_ValueChanged(object sender, EventArgs e)
        {
            cubo.RotZ = Convert.ToInt32(nudRotZ.Value);
            SincronizarValores();
        }

        private void btnRotX_Click(object sender, EventArgs e)
        {
            cubo.RotX += angleValue;
            if (cubo.RotX >= 360) cubo.RotX = 0;
            SincronizarValores();
        }

        private void btnRotY_Click(object sender, EventArgs e)
        {
            cubo.RotY += angleValue;
            if (cubo.RotY >= 360) cubo.RotY = 0;
            SincronizarValores();
        }

        private void btnRotZ_Click(object sender, EventArgs e)
        {
            cubo.RotZ += angleValue;
            if (cubo.RotZ >= 360) cubo.RotZ = 0;
            SincronizarValores();
        }

        private void btnIncX_Click(object sender, EventArgs e)
        {
            cubo.X += moveValue;
            if (cubo.X > 1000) cubo.X = 1000;
            SincronizarValores();
        }

        private void btnDecX_Click(object sender, EventArgs e)
        {
            cubo.X -= moveValue;
            if (cubo.X < 0) cubo.X = 0;
            SincronizarValores();
        }

        private void btnIncY_Click(object sender, EventArgs e)
        {
            cubo.Y += moveValue;
            if (cubo.Y > 700) cubo.Y = 700;
            SincronizarValores();
        }

        private void btnDecY_Click(object sender, EventArgs e)
        {
            cubo.Y -= moveValue;
            if (cubo.Y < 0) cubo.Y = 0;
            SincronizarValores();
        }

        private void btnIncZ_Click(object sender, EventArgs e)
        {
            cubo.Z += moveValue;
            if (cubo.Z > 500) cubo.Z = 500;
            SincronizarValores();
        }

        private void btnDecZ_Click(object sender, EventArgs e)
        {
            cubo.Z -= moveValue;
            if (cubo.Z < -500) cubo.Z = -500;
            SincronizarValores();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            cubo = new FiguraCubo(defecto);
            SincronizarValores();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            cubo.Zoom += 5;
            if (cubo.Zoom > 50) cubo.Zoom = 50;
            SincronizarValores();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            cubo.Zoom -= 5;
            if (cubo.Zoom < 1) cubo.Zoom = 1;
            SincronizarValores();
        }

        #endregion

        // Se activa cada vez que es necesario dibujar el cubo
        private void FormCubo_Paint(object sender, PaintEventArgs e)
        {
            // Puntos a dibujar
            Punto[] puntos = DibujarCubo.GetPuntos(cubo);

            //Puntos dibujables por Graphics.DrawLines
            Point[] puntosForms = new Point[puntos.Length];

            //Copiar puntos
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosForms[i] = new Point(puntos[i].X, puntos[i].Y);
            }

            //Dibujar puntos
            e.Graphics.DrawLines(Pens.Black, puntosForms);
        }

    }//class

}
