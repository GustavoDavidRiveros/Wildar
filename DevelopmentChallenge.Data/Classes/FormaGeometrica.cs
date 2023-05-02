/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DevelopmentChallenge.Data.Classes
{

    public enum codforma
    {
        cuadrado = 1, trianguloEquilarero = 2, circulo = 3, trapecio = 4, rectangulo = 5
    }

    public class FormaGeometrica
    {
        private Castellano castellano = new Castellano();
        private Ingles ingles = new Ingles();
        private Italiano italiano = new Italiano();

        public string Imprimir(List<FormaGeometricaR> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (formas.Count > 0)
            {
                switch (idioma)
                {
                    case (int)Idioma.codIdioma.castellano: sb.Append(castellano.MsjHeader); break;
                    case (int)Idioma.codIdioma.italiano: sb.Append(italiano.MsjHeader); break;
                    default: sb.Append(ingles.MsjHeader); break;
                }

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;
                var numeroRectangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;
                var areaRectangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecios = 0m;
                var perimetroRectangulos = 0m;

                foreach (var forma in formas)
                {
                    if (forma.Codigo == (int)codforma.cuadrado)
                    {
                        numeroCuadrados++;
                        Cuadrado cuadrado = (Cuadrado)forma;
                        areaCuadrados += cuadrado.CalcularArea();
                        perimetroCuadrados += cuadrado.CalcularPerimetro();
                    }
                    else if (forma.Codigo == (int)codforma.trianguloEquilarero)
                    {
                        numeroTriangulos++;
                        TrianguloEquilatero trianguloEquilatero = (TrianguloEquilatero)forma;
                        areaTriangulos += trianguloEquilatero.CalcularArea();
                        perimetroTriangulos += trianguloEquilatero.CalcularPerimetro();
                    }
                    else if (forma.Codigo == (int)codforma.circulo)
                    {
                        numeroCirculos++;
                        Circulo circulo = (Circulo)forma;
                        areaCirculos += circulo.CalcularArea();
                        perimetroCirculos += circulo.CalcularPerimetro();
                    }
                    else if (forma.Codigo == (int)codforma.trapecio)
                    {
                        numeroTrapecios++;
                        Trapecio trapecio = (Trapecio)forma;
                        areaTrapecios += trapecio.CalcularArea();
                        perimetroTrapecios += trapecio.CalcularPerimetro();
                    }
                    else if (forma.Codigo == (int)codforma.rectangulo)
                    {
                        numeroRectangulos++;
                        Rectangulo rectangulo = (Rectangulo)forma;
                        areaRectangulos += rectangulo.CalcularArea();
                        perimetroRectangulos += rectangulo.CalcularPerimetro();
                    }
                }

                switch (idioma)
                {
                    case (int)Idioma.codIdioma.castellano:
                        if (numeroCuadrados > 0)
                        {
                            sb.Append(castellano.ObtenerLinea((int)codforma.cuadrado, numeroCuadrados, areaCuadrados, perimetroCuadrados));

                        }
                        else if (numeroTriangulos > 0)
                        {
                            sb.Append(castellano.ObtenerLinea((int)codforma.trianguloEquilarero, numeroTriangulos, areaTriangulos, perimetroTriangulos));
                        }
                        else if (numeroCirculos > 0)
                        {
                            sb.Append(castellano.ObtenerLinea((int)codforma.circulo, numeroCirculos, areaCirculos, perimetroCirculos));
                        }
                        else if (numeroTrapecios > 0)
                        {
                            sb.Append(castellano.ObtenerLinea((int)codforma.trapecio, numeroTrapecios, areaTrapecios, perimetroTrapecios));
                        }
                        else if (numeroRectangulos > 0)
                        {
                            sb.Append(castellano.ObtenerLinea((int)codforma.rectangulo, numeroRectangulos, areaRectangulos, perimetroRectangulos));
                        }
                        break;
                    case (int)Idioma.codIdioma.italiano:
                        if (numeroCuadrados > 0)
                        {
                            sb.Append(italiano.ObtenerLinea((int)codforma.cuadrado, numeroCuadrados, areaCuadrados, perimetroCuadrados));

                        }
                        else if (numeroTriangulos > 0)
                        {
                            sb.Append(italiano.ObtenerLinea((int)codforma.trianguloEquilarero, numeroTriangulos, areaTriangulos, perimetroTriangulos));
                        }
                        else if (numeroCirculos > 0)
                        {
                            sb.Append(italiano.ObtenerLinea((int)codforma.circulo, numeroCirculos, areaCirculos, perimetroCirculos));
                        }
                        else if (numeroTrapecios > 0)
                        {
                            sb.Append(italiano.ObtenerLinea((int)codforma.trapecio, numeroTrapecios, areaTrapecios, perimetroTrapecios));
                        }
                        else if (numeroRectangulos > 0)
                        {
                            sb.Append(italiano.ObtenerLinea((int)codforma.rectangulo, numeroRectangulos, areaRectangulos, perimetroRectangulos));
                        }; break;
                    default:
                        if (numeroCuadrados > 0)
                        {
                            sb.Append(ingles.ObtenerLinea((int)codforma.cuadrado, numeroCuadrados, areaCuadrados, perimetroCuadrados));

                        }
                        else if (numeroTriangulos > 0)
                        {
                            sb.Append(ingles.ObtenerLinea((int)codforma.trianguloEquilarero, numeroTriangulos, areaTriangulos, perimetroTriangulos));
                        }
                        else if (numeroCirculos > 0)
                        {
                            sb.Append(ingles.ObtenerLinea((int)codforma.circulo, numeroCirculos, areaCirculos, perimetroCirculos));
                        }
                        else if (numeroTrapecios > 0)
                        {
                            sb.Append(ingles.ObtenerLinea((int)codforma.trapecio, numeroTrapecios, areaTrapecios, perimetroTrapecios));
                        }
                        else if (numeroRectangulos > 0)
                        {
                            sb.Append(ingles.ObtenerLinea((int)codforma.rectangulo, numeroRectangulos, areaRectangulos, perimetroRectangulos));
                        }; break;
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + numeroRectangulos + " " + (idioma == (int)Idioma.codIdioma.castellano ? "formas" : (idioma == (int)Idioma.codIdioma.italiano ? "forme" : "shapes")) + " ");
                sb.Append((idioma == (int)Idioma.codIdioma.castellano ? "Perimetro " : (idioma == (int)Idioma.codIdioma.italiano ? "Perimetro " : "Perimeter ")) + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios + perimetroRectangulos).ToString("#,##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios + areaRectangulos).ToString("#,##"));


            }
            else
                switch (idioma)
                {
                    case (int)Idioma.codIdioma.castellano: sb.Append(castellano.MsjVacio); break;
                    case (int)Idioma.codIdioma.italiano: sb.Append(italiano.MsjVacio); break;
                    default: sb.Append(ingles.MsjVacio); break;
                }
            return sb.ToString();
        }

    }





    #region Idiomas
    public abstract class Idioma
    {
        public enum codIdioma
        {
            castellano = 1, ingles = 2, italiano = 3
        }
        public Idioma()
        {
        }

        public string MsjVacio { set; get; }
        public string MsjHeader { set; get; }
        public abstract string TraducirForma(int codForma, int cantidad);
        public abstract string ObtenerLinea(int codforma, int cantidad, decimal area, decimal perimetro);

    }

    public class Castellano : Idioma
    {
        public Castellano()
        {
            base.MsjVacio = "<h1>Lista vacía de formas!</h1>";
            base.MsjHeader = "<h1>Reporte de Formas</h1>";

        }

        public override string ObtenerLinea(int codforma, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codforma, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

        }



        public override string TraducirForma(int CodigodForma, int cantidad)
        {
            switch (CodigodForma)
            {
                case (int)codforma.cuadrado:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case (int)codforma.trianguloEquilarero:
                    return cantidad == 1 ? "Circulo" : "Circulos";
                case (int)codforma.circulo:
                    return cantidad == 1 ? "Triangulo" : "Triangulos";
                case (int)codforma.trapecio:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case (int)codforma.rectangulo:
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";

            }
            return string.Empty;

        }
    }

    public class Ingles : Idioma
    {
        public Ingles()
        {
            base.MsjVacio = "<h1>Empty list of shapes!</h1>";
            base.MsjHeader = "<h1>Shapes report</h1>";
        }

        public override string ObtenerLinea(int codforma, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codforma, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

        }



        public override string TraducirForma(int CodigodForma, int cantidad)
        {
            switch (CodigodForma)
            {
                case (int)codforma.cuadrado:
                    return cantidad == 1 ? "Square" : "Squares";
                case (int)codforma.trianguloEquilarero:
                    return cantidad == 1 ? "Circle" : "Circles";
                case (int)codforma.circulo:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case (int)codforma.trapecio:
                    return cantidad == 1 ? "Trapeze" : "Trapezoids";
                case (int)codforma.rectangulo:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                default:
                    return string.Empty;
            }

        }
    }

    public class Italiano : Idioma
    {
        public Italiano()
        {
            base.MsjVacio = "<h1>Elenco vuoto di forme!</h1>";
            base.MsjHeader = "<h1>Relazione sulle forme</h1>";
        }

        public override string ObtenerLinea(int codforma, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {TraducirForma(codforma, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

        }



        public override string TraducirForma(int CodigodForma, int cantidad)
        {
            switch (CodigodForma)
            {
                case (int)codforma.cuadrado:
                    return cantidad == 1 ? "Piazza" : "Piazze";
                case (int)codforma.trianguloEquilarero:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case (int)codforma.circulo:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case (int)codforma.trapecio:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case (int)codforma.rectangulo:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                default:
                    return string.Empty;
            }

        }
    }

    #endregion

    #region Formas 
    public abstract class FormaGeometricaR
    {
        public int Codigo { get; set; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();


    }
    public class Cuadrado : FormaGeometricaR
    {
        public Cuadrado(decimal lado)
        {
            base.Codigo = (int)codforma.cuadrado;
            this._Lado = lado;
        }
        public decimal _Lado { get; set; }

        public override decimal CalcularArea()
        {
            return _Lado * _Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _Lado * 4;
        }

    }

    public class TrianguloEquilatero : FormaGeometricaR
    {
        private decimal _Lado;

        public TrianguloEquilatero(decimal lado)
        {
            base.Codigo = (int)codforma.trianguloEquilarero;
            _Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (_Lado * _Lado * (decimal)Math.Sqrt(3)) / 4;
        }

        public override decimal CalcularPerimetro()
        {
            return 3 * _Lado;
        }
    }

    public class Circulo : FormaGeometricaR
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            base.Codigo = (int)codforma.circulo;
            _radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * _radio;
        }
    }

    public class Trapecio : FormaGeometricaR
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _lado;


        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado)
        {
            base.Codigo = (int)codforma.trapecio;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado = lado;

        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + (_lado * 2);
        }
    }

    public class Rectangulo : FormaGeometricaR
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;
        public Rectangulo(decimal lado1, decimal lado2)
        {
            base.Codigo = (int)codforma.rectangulo;
            _lado1 = lado1;
            _lado2 = lado2;
        }
        public override decimal CalcularArea()
        {
            return (decimal)_lado1 * _lado2;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)2 * _lado1 + 2 * _lado2;
        }
    }
    #endregion
}
