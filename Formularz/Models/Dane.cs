using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć minimum 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć minimum 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Niepoprawny format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć minimum 8 znaków")]
        [RegularExpression("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}",
            ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną małą literę i jedną wielką literę")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła nie są takie same")]
        [DataType(DataType.Password)]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podać wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public string Miasto { get; set; }
    }
}
