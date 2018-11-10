using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Peleas.Models
{
    public class Lucha
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Falta Codigo")]
		[StringLength(40)]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Falta Lugar")]
        public string Lugar { get; set; }
        [Required(ErrorMessage = "Falta Fecha")]
        public string Fecha { get; set; }
        [Required(ErrorMessage = "Falta Categoria")]          
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Falta Diciplina")]   
        public string Diciplina { get; set; }
        public string Descripcion1 { get; set; } 
        public string Descripcion2 { get; set; }   
        public string Descripcion3 { get; set; }     
}
}