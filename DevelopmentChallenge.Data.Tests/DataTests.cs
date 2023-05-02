using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                formaGeometrica.Imprimir(new List<FormaGeometricaR>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                formaGeometrica.Imprimir(new List<FormaGeometricaR>(), 2));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                formaGeometrica.Imprimir(new List<FormaGeometricaR>(), 3));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometricaR> { new Cuadrado(5) };
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            var resumen = formaGeometrica.Imprimir(cuadrados, (int)Idioma.codIdioma.castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometricaR>();
            cuadrados.Add(new Cuadrado(5));
            cuadrados.Add(new Cuadrado(1));
            cuadrados.Add(new Cuadrado(3));

            FormaGeometrica formaGeometrica = new FormaGeometrica();
            var resumen = formaGeometrica.Imprimir(cuadrados, (int)Idioma.codIdioma.ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometricaR>();

            formas.Add(new Cuadrado(5));
            formas.Add(new Circulo(3));
            formas.Add(new TrianguloEquilatero(4));
            formas.Add(new Cuadrado(2));
            formas.Add(new TrianguloEquilatero(9));
            formas.Add(new Circulo(2.75m));
            formas.Add(new TrianguloEquilatero(4.2m));

            FormaGeometrica formaGeometrica = new FormaGeometrica();

            var resumen = formaGeometrica.Imprimir(formas, (int)Idioma.codIdioma.ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometricaR>();
            formas.Add(new Cuadrado(5));
            formas.Add(new Circulo(3));
            formas.Add(new TrianguloEquilatero(4));
            formas.Add(new Cuadrado(2));
            formas.Add(new TrianguloEquilatero(9));
            formas.Add(new Circulo(2.75m));
            formas.Add(new TrianguloEquilatero(4.2m));



            FormaGeometrica formaGeometrica = new FormaGeometrica();
            var resumen = formaGeometrica.Imprimir(formas, (int)Idioma.codIdioma.castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
