using System;
using System.Collections.Generic;
using System.Text;
using Samuel_OperacionesBasicas.Services;

namespace Samuel_OperacionesBasicas
{
    public class TransaccionAritmeticaModel: ITransaccionAritmeticaModel
    {
        public double PrimerNumero { get; set; }
        public double SegundoNumero { get; set; }
        public double Resultado_Operacion { get; set; }
        public string Respuesta_Operacion { get; set; }

        public void Dividir()
        {
            Resultado_Operacion = PrimerNumero / SegundoNumero;
            Respuesta_Operacion = MostrarResultado("Division");
        }

        public string MostrarResultado(string Parametro)
        {
            return "El resultado de la " + Parametro + " es igual a " + Resultado_Operacion.ToString();
        }

        public void Multiplicar()
        {

            Resultado_Operacion = PrimerNumero * SegundoNumero;
            Respuesta_Operacion = MostrarResultado("Multiplicacion");
        }

        public void Restar()
        {

            Resultado_Operacion = PrimerNumero - SegundoNumero;
            Respuesta_Operacion = MostrarResultado("Resta");
        }

        public void Sumar()
        {

            Resultado_Operacion = PrimerNumero + SegundoNumero;
            Respuesta_Operacion = MostrarResultado("Suma");
        }


    }
}
