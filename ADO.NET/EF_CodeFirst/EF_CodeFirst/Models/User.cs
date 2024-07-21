using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
  //  [Table("MyUsers")]
    internal class User
    {

        public int Id { get; set; }
        //[Column("FirstName")]
        public string Name { get; set; }
        //[NotMapped]
        public string Surname { get; set; }
       // [Key]
        //[Required]
        public string Login { get; set; }
        public string Password { get; set; }

        public IdCard idCard { get; set; }

        public ICollection<Note> notes { get; set; }
    }
}
