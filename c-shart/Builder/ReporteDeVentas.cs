using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder{
    class ReporteDeVentas{
        private string Titulo;
        private DateTime Fecha;
        private List<string> Productos = new List<string>();
        private List<int> Cantidades = new List<int>();
        private decimal TotalVentas;
        
        public void AgregarTitulo(string titulo){
            Titulo = titulo;
        }
        public void AgregarFecha(DateTime fecha){
            Fecha = fecha;
        }
        public void AgregarProducto(string producto, int cantidad, decimal precio){
                Productos.Add(producto);
                Cantidades.Add(cantidad);
                TotalVentas += precio * cantidad;
        }
        public string GetReporte(){
            var detalle = "";
            for(int i =0; i<Productos.Count; i++){
                detalle += $"{Productos[i]} - {Cantidades[i]}   ";
            }
            return $"""
            Titulo: {Titulo}
            Fecha   {Fecha}
            Detalle {detalle}

            Total   {TotalVentas}

            """;
        }

    }
}