using System.ComponentModel.DataAnnotations;

namespace Osoby.Models
{
    public class Osoba
    {
        public int OsobaId { get; set; }
        [Required(ErrorMessage = "Wymagane podanie imienia")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wymagane podanie nazwiska")]
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public double Waga { get; set; }

        public double BMI
        {
            get
            {
                if (Waga > 0 && Wiek > 0)
                {
                    return Waga / (Wiek / 100) * (Wiek / 100);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value > 0)
                {
                    Waga = value * (Wiek / 100) * (Wiek / 100);
                }
                else
                {
                    Waga = 0;
                }
            }
        }

        public string WskaznikBMI
        {
            get
            {
                string wskaznik = "";

                if (BMI == 0)
                {
                    wskaznik = "Brak danych";
                }
                else if (BMI > 0 && BMI <= 16.9)
                {
                    wskaznik = "Ciężka niedowaga (III stopień szczupłości)";
                }
                else if (BMI > 16.9 && BMI <= 18.49)
                {
                    wskaznik = "Umiarkowana niedowaga (II stopień szczupłości)";
                }
                else if (BMI > 18.49 && BMI <= 24.9)
                {
                    wskaznik = "Prawidłowa waga u osób w wieku 18-65";
                }
                else if (BMI > 24.9 && BMI <= 27.0)
                {
                    wskaznik = "Średnia pożądana masa ciała u osób starszych (65+)";
                }
                else if (BMI > 27.0 && BMI <= 29.9)
                {
                    wskaznik = "Nadwaga u osób w wieku 18-65";
                }
                else if (BMI > 29.9 && BMI <= 34.9)
                {
                    wskaznik = "Otyłość I stopnia";
                }
                else if (BMI > 34.9 && BMI <= 39.9)
                {
                    wskaznik = "Otyłość II stopnia";
                }
                else
                {
                    wskaznik = "Otyłość III stopnia";
                }

                return wskaznik;
            }
        }
    }
}
