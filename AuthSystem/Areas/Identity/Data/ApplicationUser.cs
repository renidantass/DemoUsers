using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace AuthSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string Sobrenome { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string Cpf { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DataNascimento { get; set; }
        [Column(TypeName = "int")]
        public int Nivel { get; set; }
    }
}
