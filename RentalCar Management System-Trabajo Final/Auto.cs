using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Models
{
    internal class Auto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public bool Disponible { get; set; }

        public Auto(int id, string marca, string modelo, string placa, bool disponible)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Disponible = disponible;
        }

        public string ObtenerInfo() => $"{Marca} {Modelo} ({Placa})";
        public string ObtenerInfo(bool mostrarDisponibilidad) => $"{Marca} {Modelo} ({Placa}) - Disponible: {Disponible}";
    }
}
