using System.ComponentModel.DataAnnotations;

namespace Osoby.Models
{
    public class Osoba
    {
        public int OsobaId { get; set; }
        [Required(ErrorMessage = "Wymagane podanie imienia")]
        public string? Imie { get; set; }
        [Required(ErrorMessage = "Wymagane podanie nazwiska")]
        public string? Nazwisko { get; set; }
        public int Wiek { get; set; }
        public double Waga { get; set; }

        public double Wzrost { get; set; }

        public double? BMI { get; set; }

        public string? WskaznikBMI { get; set; }
    }
}
