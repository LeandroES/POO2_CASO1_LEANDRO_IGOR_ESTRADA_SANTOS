using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Models
{
    public class Usuario
    {

        // Propiedades
        [Display(Name = "Usuario")]
        [Required]
        public String usuario { get; set; }

        [Display(Name = "Clave")]
        [Required]
        public string clave { get; set; }

    }
}