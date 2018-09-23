/*
 * DibujarCubo.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Obtiene todos los puntos para dibujar un cubo
 */


using System;
using System.Collections.Generic;
using Cubo.Tipos;
using Matemáticas.Tipos;
using Matemáticas.Tipos.Transformaciones;

namespace Cubo.Procesos
{
    public static class DibujarCubo
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades estáticas
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        static double f = 5;
        static double[,] constantes = {
                {f, 0, 0}, {0, f, 0}, {-f, 0, 0}, {0, 0, f},
                {0, -f, 0}, {f, 0, 0}, {0, 0, -f}, {0, f, 0},
                {0, 0, f}, {-f, 0, 0}, {0, -f, 0}, {0, 0, -f},
                {0, f, 0}, {0, 0, f}, {f, 0, 0 }, {0, -f, 0}
            };

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Método para dibujar
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        /// <summary>
        /// Obtiene los puntos necesarios para dibujar un cubo con determinadas
        /// características de transformación
        /// </summary>
        /// <param name="cubo">El cubo a dibujar</param>
        /// <returns>Un arreglo de puntos para dibujar el cubo</returns>
        public static Punto[] GetPuntos(FiguraCubo cubo)
        {
            //Punto de inicio
            MatrizTraslación original = new MatrizTraslación(cubo.X, cubo.Y, cubo.Z);

            //Todos los puntos
            List<Matriz<double>> puntos3D = new List<Matriz<double>>();
            Punto[] puntos2D = new Punto[17];

            //Matriz inicial
            puntos3D.Add(
                    original *
                    new MatrizProporción(cubo.Zoom) *
                    new MatrizRotación(Ejes.X, cubo.RotX * Math.PI / 180) *
                    new MatrizRotación(Ejes.Y, cubo.RotY * Math.PI / 180) *
                    new MatrizRotación(Ejes.Z, cubo.RotZ * Math.PI / 180)
                    );
            puntos2D[0] = new Punto(original, cubo.Ángulo);

           
            //Calcular el resto de los puntos
            for (int i = 1; i <= 16; i++)
            {
                Matriz<double> constante = new MatrizTraslación(
                    constantes[i - 1, 0],
                    constantes[i - 1, 1],
                    constantes[i - 1, 2]
                    );
                Matriz<double> matriz = (new Matriz<double>(puntos3D[i - 1]) * new Matriz<double>(constante));
                puntos3D.Add(matriz);
                puntos2D[i] = new Punto(new MatrizTraslación(puntos3D[i]), cubo.Ángulo);
            }

            return puntos2D;
        }

    }//class
}
