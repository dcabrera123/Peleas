using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Peleas.Models
{
    public class Luchador
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Falta Nombre")]		
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Faltan Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Falta Categoria")]          
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Falta Diciplina")]   
        public string Diciplina { get; set; }
        public string Descripcion1 { get; set; } 
        public string Descripcion2 { get; set; }   
        public string Descripcion3 { get; set; }     
}
}