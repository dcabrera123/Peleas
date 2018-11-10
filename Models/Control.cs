using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Peleas.Models
{
    public class Control
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; set; }
 }
}