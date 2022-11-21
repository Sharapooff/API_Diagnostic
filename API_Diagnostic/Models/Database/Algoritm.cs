using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBase
{
    public class Algoritm
    {
        [Required]
        [Key]
        public int Id { get; set; }
        //-----------------------------------
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        //-----------------------------------

        [Required]
        //[Column(TypeName = "varchar(100)")]
        public string Notation { get; set; }
        //-----------------------------------

        [Required]
        public int TypeAlgorithmId { get; set; } // внешний ключ        
        //-----------------------------------

        [Required]
        public int? Version { get; set; }
        //-----------------------------------
        
        [Required]
        public virtual TypeAlgorithm TypeAlgorithm { get; set; } // навигационное свойство
        
        [Required]
        public virtual List<Incident> Incidents { get; set; } = new List<Incident>(); // навигационное свойство
        
        [Required]
        public virtual List<TimeTable> TimeTables { get; set; } = new List<TimeTable>(); // навигационное свойство
    }
}
