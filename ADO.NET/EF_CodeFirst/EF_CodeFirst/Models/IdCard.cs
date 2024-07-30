using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public class IdCard
    {
        public string FIN { get; set; }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
