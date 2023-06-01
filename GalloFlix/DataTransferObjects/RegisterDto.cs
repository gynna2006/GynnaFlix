using System.ComponentModel.DataAnnotations;

namespace GalloFlix.DataTransferObjects;

    public class RegisterDto
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por favor, informe seu Email")]
        [EmailAddress(ErrorMessage = "Por favor, infome um Email válido")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
        [StringLength(20, MinimumLength = 6, 
            ErrorMessage = "A Senha deve possuir no mínimo 6 caracteres e no máximo 20 caracteres")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "A Senhas não conferem.")]
        public string ConfirmPassword { get; set; }
    }
