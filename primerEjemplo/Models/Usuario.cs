using System.ComponentModel.DataAnnotations;

namespace primerEjemplo.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(3, ErrorMessage = "El nombre de usuario debe ser de al menos 3 letras.")]
        [MaxLength(10, ErrorMessage = "El nombre de usuario debe ser de a lo mucho de 10 letras.")]
        public string Nombre { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})",ErrorMessage = "La contraseña debe contar con al menos una mayúscula, una minúscula, ...")]
        public string Password { get; set; }
        [Required]
        [Range(18,35, ErrorMessage = "El usuario debe ser mayor de edad y hasta los 35 años máximo")]
        public int Edad { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string Pagina { get; set; }
    }
}
