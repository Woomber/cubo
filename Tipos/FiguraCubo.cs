/*
 * FiguraCubo.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Define un cubo mediante sus propiedades de transformación
 */


namespace Cubo.Tipos
{
    public class FiguraCubo
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public int X { set; get; }
        public int Y { set; get; }
        public int Z { set; get; }
        public int Zoom { set; get; }
        public int Ángulo { set; get; }
        public int RotX { set; get; }
        public int RotY { set; get; }
        public int RotZ { set; get; }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        /// <summary>
        /// Construye un cubo mediante sus propiedades de transformación
        /// </summary>
        /// <param name="x">Posición inicial del origen en X</param>
        /// <param name="y">Posición inicial del origen en Y</param>
        /// <param name="zoom">Factor de ampliación del cubo</param>
        /// <param name="ángulo">Ángulo de proyección en grados</param>
        /// <param name="rotX">Ángulo de rotación en el eje X en grados</param>
        /// <param name="rotY">Ángulo de rotación en el eje Y en grados</param>
        /// <param name="rotZ">Ángulo de rotación en el eje Z en grados</param>
        public FiguraCubo(int x, int y, int z, int zoom, int ángulo, int rotX, int rotY, int rotZ)
        {
            X = x;
            Y = y;
            Z = z;
            Zoom = zoom;
            Ángulo = ángulo;
            RotX = rotX;
            RotY = rotY;
            RotZ = rotZ;
        }

        public FiguraCubo(FiguraCubo copia)
        {
            X = copia.X;
            Y = copia.Y;
            Z = copia.Z;
            Zoom = copia.Zoom;
            Ángulo = copia.Ángulo;
            RotX = copia.RotX;
            RotY = copia.RotY;
            RotZ = copia.RotZ;
        }

    }//class
}
