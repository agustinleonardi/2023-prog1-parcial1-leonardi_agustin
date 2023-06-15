using System;
namespace BibliotecaDeClases
{
	public class PolizaVendida
	{
		public int CodigoAutoincremental { get; set; }
		public DateTime FechaContratacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
		public int CodigoSeguroContratado { get; set; }
		public List<Pago>? PagosAsociados { get; set; }

        public PolizaVendida(int codigoAutoincremental, DateTime fechaContratacion, int codigoSeguroContratado, List<Pago>? pagosAsociados)
        {
            CodigoAutoincremental = codigoAutoincremental;
            FechaContratacion = DateTime.Today;
            CodigoSeguroContratado = codigoSeguroContratado;
            PagosAsociados = pagosAsociados;
        }
    }
}

