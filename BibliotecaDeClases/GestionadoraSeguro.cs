using System;
namespace BibliotecaDeClases
{
	public class GestionadoraSeguro
	{
		public int CodigoAutoincrementalPolizas { get; set; }
		public int CodigoAutoincrementalSeguro { get; set; }
		private List<Seguro> Seguros { get; set; }
		private List<PolizaVendida> Polizas { get; set; }

		public GestionadoraSeguro()
		{
			Seguros = new();
			Polizas = new();
			CodigoAutoincrementalPolizas = 1;
			CodigoAutoincrementalSeguro = 1;
		}
		public int ObtenerCodigoAutoincrementalPoliza()
		{
			return CodigoAutoincrementalPolizas++;
		}
		public int ObtenerCodigoAutoincrementalSeguro()
		{
			return CodigoAutoincrementalSeguro++;
		}
		public void AgregarSeguro(Seguro seguro)
		{
			Seguros.Add(seguro);
		}
		public void AgregarPoliza(int dni, int codigo)
		{
			
		}
		public int IndiceDeRiesgo(int codigo)
		{
			foreach (Seguro? seguro in Seguros)
			{ 
				if (seguro is Robo)
				{
					if (true)
					{
					}
				}
			}
		}
	}
}


