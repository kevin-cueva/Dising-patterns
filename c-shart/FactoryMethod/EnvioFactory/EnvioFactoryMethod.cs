namespace EnvioFactory
{
    public class EnvioFactoryMethod{
        public static Envio CrearEnvio(string tipoEnvio){
            switch (tipoEnvio)
            {
                case "T":
                return new EnvioTerrestre();
                case "A":
                return new EnvioAereo();

                default:
                return new EnvioTerrestre();
            }
        }
    } 
}