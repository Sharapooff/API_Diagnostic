using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.DataBase
{
    public class TypeAlgorithm
    {
        [Required]
        [Key]
        public int Id { get; set; }
        //-----------------------------------

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        //-----------------------------------


        public virtual List<Algoritm> Algoritms { get; set; } = new List<Algoritm>(); // навигационное свойство
    }
}
