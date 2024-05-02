using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Models
{
    internal class Catigorie
    {
        public string CatigorieName { get; set; }
        public List<Test> Tests { get; set; } = new List<Test>();
    }
}
