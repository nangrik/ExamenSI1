using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenSI1.Models
{
    public class Queja 
    {
        [Key]
        public int QuejaId { get; set; }
        [Required(ErrorMessage ="La fecha es obligatoria")]
        [Display(Name ="Fecha")]
        public string Quejafecha { get; set; }
        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(70, ErrorMessage ="no debe tener mas de 70 caracteres")]
        [MinLength(3, ErrorMessage="debe tener mas de 3 caracteres")]
        public string QuejaNombre { get; set; }
        [Required(ErrorMessage = "La identidad es Obligatoria")]
        [Display(Name = "N° Identidad")]
        public string QuejaIdentidad { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Con Copia a")]
        public string QuejaCc { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Numero")]
        public int QuejaNumero { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Dependencia")]
        public string QuejaDependencia { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Cargo")]
        public string QuejaCargo { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Correo Electronico")]
        public string QuejaEmail { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Queja")]
        public string QuejaQueja { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Relacion de los hechos constitutivos de la queja")]
        public string QuejaRelacion { get; set; }
        [Required(ErrorMessage = "El campo es Obligatorio")]
        [Display(Name = "Cuenta usted con alguna prueba, Cual(es)?")]
        public  string QuejaPrueba { get; set; }
    }
}
