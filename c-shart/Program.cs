using Builder;
using EnvioFactory;
using Singleton;

namespace c_shart;

class Program
{
    static void Main(string[] args)
    {

        #region Factory Method
            //Factory Method
            Envio terrestre = EnvioFactoryMethod.CrearEnvio("T");
            Console.WriteLine("Envio Terrestre: " + terrestre.CalcularCosto(5.0));
    
            Envio aereo = EnvioFactoryMethod.CrearEnvio("A");
            Console.WriteLine("Envio Aereo: " + aereo.CalcularCosto(5.0));
        #endregion

        #region Singleton
            //Singleton
            SingletonBasico instance = SingletonBasico.GetInstance();
            instance.EscribirMensaje("hello world from a structure Singleton");
    
             // Obtener la instancia de la configuración
            SingletonConfApp config = SingletonConfApp.GetInstance;
    
            // Establecer algunas opciones de configuración
            config.SetSetting("DBConnection", "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            config.SetSetting("Theme", "Dark");
    
            // Obtener y mostrar una opción de configuración
            string theme = config.GetSetting("Theme");
            Console.WriteLine("Tema actual: " + theme);
        #endregion
    
        #region Builder
        Console.WriteLine("Patron Builder");
        ReporteDeVentas reporte = new ReporteDeVentas();
        reporte.AgregarTitulo("Reporte de Ventas");
        reporte.AgregarFecha(DateTime.Now);
        reporte.AgregarProducto("Cafe", 2, 10000);
        reporte.AgregarProducto("Leche", 1, 15000);
        reporte.AgregarProducto("Azucar", 1, 7000);
        Console.Write(reporte.GetReporte());
        #endregion
    }
}
