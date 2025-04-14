using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_14_04_25
{
    //internal class Adaptadores
    //{
    //}

    // Interface alvo
    public interface Poligono
    {
        double getArea();
    }

    // Classe Quadrado
    public class Quadrado : Poligono
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double getArea()
        {
            return lado * lado;
        }
    }

    // Classe Triangulo
    public class Triangulo : Poligono
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double getArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }

    // Classe estrangeira que precisa ser adaptada
    public class HexagonoEstrangeiro
    {
        private double lado;

        public HexagonoEstrangeiro(double lado)
        {
            this.lado = lado;
        }

        public float calculaArea()
        {
            return (float)((3 * (lado * lado) * Math.Sqrt(3)) / 2);
        }
    }

    // Adaptador para HexagonoEstrangeiro
    public class AdaptadorHexagono : Poligono
    {
        private HexagonoEstrangeiro hexagono;
        public AdaptadorHexagono(HexagonoEstrangeiro hexagono)
        {
            this.hexagono = hexagono;
        }
        public double getArea()
        {
            // Converte o resultado de float para double
            return (double)hexagono.calculaArea();
        }
    }
}