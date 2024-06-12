namespace Singleton{
    public sealed class SingletonBasico{
        //1. Create private static instance
        private static SingletonBasico? Instance;
        //2. create private constructor
        private SingletonBasico(){}
        public static SingletonBasico GetInstance(){
            if(Instance == null){
                Instance = new SingletonBasico();
            }
            return Instance;
        }
        public void EscribirMensaje(string mensaje){
            Console.WriteLine(mensaje);
        }
    }
}