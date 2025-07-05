using System.ComponentModel.DataAnnotations;

namespace AluguelDeCarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public bool Disponivel { get; set; }
    }
}
