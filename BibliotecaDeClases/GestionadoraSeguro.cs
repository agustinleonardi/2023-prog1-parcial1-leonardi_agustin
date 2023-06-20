using System;
namespace BibliotecaDeClases
{
	public class GestionadoraSeguro
	{
		public int CodigoAutoincrementalPolizas { get; set; } //CORRECCION: ESTO NO FUNCIONA, AL SER UNA PROPIEDAD DE LA CLASE SI SE MODIFICA DE CUALQUIER LADO PODEMOS CALCULAR MAL ESOS VALORES
		public int CodigoAutoincrementalSeguro { get; set; } //CORRECCION: IDEM PUNTO ANTERIOR.
		private List<Seguro> Seguros { get; set; }
		private List<PolizaVendida> Polizas { get; set; }

		public GestionadoraSeguro()
		{
			Seguros = new();
			Polizas = new();
			CodigoAutoincrementalPolizas = 1;
			CodigoAutoincrementalSeguro = 1;
		}
		public int ObtenerCodigoAutoincrementalPoliza() //CORRECCION: NO SE DEBE EXPONER ESTE MÉTODO, SE DEBE CALCULAR SIEMPRE INTERNAMENTE
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
		//CORRECCIÓN: ESTO NO VA ACÁ, VA EN LA CLASE SEGURO.
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


