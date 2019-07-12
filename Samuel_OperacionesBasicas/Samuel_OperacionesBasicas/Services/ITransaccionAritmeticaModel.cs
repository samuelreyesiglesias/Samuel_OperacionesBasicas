using System;
using System.Collections.Generic;
using System.Text;

namespace Samuel_OperacionesBasicas.Services
{
    public interface ITransaccionAritmeticaModel
    {
        void Sumar();
        void Restar();
        void Multiplicar();
        void Dividir();
        string MostrarResultado(string Parametro);
    }
}
