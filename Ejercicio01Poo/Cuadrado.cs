using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01Poo
{
    class Cuadrado
    {
        //private int lado;

        //public void SetLado(int value)
        //{
        //    if (value>0)
        //    {
        //        lado = value;
        //    }
        //    else
        //    {
        //        throw new Exception("El valor del lado debe ser positivo");
        //    }
        //}

        //public int GetLado()
        //{
        //    return lado;
        //}
        //private int lado;

        //public int Lado
        //{
        //    get { return lado; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            lado = value;
        //        }
        //        else
        //        {
        //            throw new Exception("El valor del lado debe ser positivo");
        //        }
        //    }
        //}
        public Cuadrado()
        {

        }

        public Cuadrado(int valorDelLado)
        {
            Lado = valorDelLado;
        }
        public int Lado { get; set; }

        public bool Validar()
        {
            return Lado > 0;
        }

        public double GetPerimetro()
        {
            return Lado * 4;
        }

        public double GetSuperficie()
        {
            return Math.Pow(Lado, 2);
        }
    }
}
