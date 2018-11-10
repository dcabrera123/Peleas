using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Peleas.Models
{
    public class Luchador
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese Nombres")]
		[StringLength(40)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Ingrese Usuario")]
        public string Usu { get; set; }
        [Required(ErrorMessage = "Ingrese Contraseña")]
        public string Contraseña { get; set; }
        [Compare(nameof(Contraseña),ErrorMessage = "Contraseña incorrecta")] 
        public string ConfirmarContraseña { get; set;}
        [Required(ErrorMessage = "Ingrese Correo")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalido")]
        public string Correo { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Email invalido")]
        [Compare(nameof(Correo),ErrorMessage = "Esta cuenta de correo no existe. Indica una cuenta diferente ")] 
        public string ConfirmarCorreo { get; set;}
        [Required(ErrorMessage = "Ingrese Celular")]
        public int Celular { get; set; }
        
        public string Nacimiento { get; set; }
    }
}