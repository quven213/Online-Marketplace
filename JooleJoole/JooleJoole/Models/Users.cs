using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JooleJoole.Models
{
    [Table("UserRole")]
    public class Users
    {
        [Key]
        public int UserRoleId { get; set; }
        public string RoleDescription { get; set; }
    }
}