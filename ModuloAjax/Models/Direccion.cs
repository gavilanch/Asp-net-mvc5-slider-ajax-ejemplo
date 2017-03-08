namespace ModuloAjax
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Direccion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Calle { get; set; }

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; }

        public virtual Persona Personas { get; set; }
    }
}
