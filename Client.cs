using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacion_clientes
{
    internal class Client
    {
        public double IDCliente {get; set; }
        public double RLlEGADA { get; set; }
        public double TENTRELL { get; set; }
        public double Hllegada { get; set; }
        public double Hinicio { get; set; }
        public double RTipoCliente { get; set; }    
        public TipoCliente TCliente { get; set; }
        
        public double RAlimento { get; set; }
        public double TAlimento { get; set; }

        public double TSalida { get; set; }
        public double TEspera { get; set; }
        public double TSistema { get; set; }

        private double MinLlegada { get; set; }
        private double MaxLlegada { get; set; }

        public Client(int iIDCliente, double dMinLlegada, double dMaxLlegada)
        {
            Random rnd = new();

            IDCliente = iIDCliente;
            MinLlegada = dMinLlegada;
            MaxLlegada = dMaxLlegada;

            RLlEGADA = Math.Round(rnd.NextDouble(), 2);
            RTipoCliente = Math.Round(rnd.NextDouble(),2);
            RAlimento = Math.Round(rnd.NextDouble(), 2);
            RAlimento = Math.Round(rnd.NextDouble(), 2);

            TENTRELL = Math.Round(MinLlegada + (MaxLlegada - MinLlegada) * RLlEGADA, 2);
            Hllegada = Math.Round(TENTRELL, 2);
            Hinicio = Math.Round(Hllegada, 2);
            if ((RTipoCliente <= .65))
            {
                TCliente = TipoCliente.Profesor;
            }
            else
            {
                TCliente = TipoCliente.Estudiante;
            }

            TAlimento = Math.Round((TCliente == TipoCliente.Profesor) ? 2 + (6-2) * RAlimento : 7 +(7 - 3) * RAlimento, 2);
            TSalida = Math.Round(TAlimento + Hinicio, 2);
            TEspera = Math.Round(Hinicio - Hllegada, 2);
            TSistema = Math.Round(TSalida - Hllegada, 2);
        }

        internal enum TipoCliente 
        {
            Profesor,
            Estudiante
        }

    }
}
