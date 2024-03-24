﻿using KaibaSystem_Back_End.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaibaSystem_Back_End.Models.Usuario
{
    [Table("Usuarios")]
    public class Usuario : Entity
    {
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public Int32 IDCargo { get; set; }

        [ForeignKey(nameof(IDCargo))]
        public Cargo? Cargo { get; set; }

        public String Email { get; set; }

        [NotMapped]
        public String? Token { get; set; }
    }
}