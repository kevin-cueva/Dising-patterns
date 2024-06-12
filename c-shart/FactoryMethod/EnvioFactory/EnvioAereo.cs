namespace EnvioFactory
{
    class EnvioAereo : Envio
    {
        public override decimal CalcularCosto(double distancia)
        {
               return (decimal)(distancia*5.0);
        }
    }
}