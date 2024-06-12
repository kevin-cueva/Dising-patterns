namespace EnvioFactory{
    class EnvioTerrestre : Envio
    {
        public override decimal CalcularCosto(double distancia)
        {
            return (decimal)(distancia*2.0);
        }
    }
}