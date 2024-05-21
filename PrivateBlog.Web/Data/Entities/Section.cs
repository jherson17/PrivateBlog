﻿using System.ComponentModel.DataAnnotations;

namespace PrivateBlog.Web.Data.Entities
{
    public class Section
    {
        public int Id { get; set; }

        /// Utiliza el atributo [Display] para especificar el nombre de la propiedad cuando se muestra en una interfaz de usuario.
        // En este caso, 'Name' se mostrará como "Sección" en la interfaz de usuario.
        [Display(Name = "Sección")]
        [Required(ErrorMessage = "El campo '{0}' es requerido.")]
        [MaxLength(64, ErrorMessage = "El campo '{0}' debe terner máximo {1} caractéres")]
        public string Name { get; set; }


        [Display(Name = "¿Está oculta?")]
        public bool IsHidden { get; set; } = false;
    }
}
