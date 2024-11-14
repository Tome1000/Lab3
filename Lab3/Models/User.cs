using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Required(ErrorMessage = "Imię jest wymagane")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła nie są zgodne")]
        public string ConfirmPassword { get; set; }

        [Phone(ErrorMessage = "Nieprawidłowy numer telefonu")]
        public string PhoneNumber { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        public City City { get; set; }
    }

    public enum City
    {
        [Display(Name = "Warszawa")]
        Warsaw,
        [Display(Name = "Kraków")]
        Krakow,
        [Display(Name = "Gdańsk")]
        Gdansk,
        [Display(Name = "Wrocław")]
        Wroclaw,
        [Display(Name = "Poznań")]
        Poznan
    }

}
