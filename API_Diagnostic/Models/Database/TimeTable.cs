using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.DataBase
{
    public class TimeTable
    {
        [Required]
        [Key]
        public int Id { get; set; }
        //-----------------------------------

        [Required]
        public int SectionId { get; set; }// внешний ключ (можно опустить)
        //-----------------------------------
                
        [Required]
        public int AlgoritmId { get; set; }// внешний ключ (можно опустить)
        //-----------------------------------

        public virtual Section Section { get; set; }// навигационное свойство
        public virtual Algoritm Algoritm { get; set; }// навигационное свойство
    }
}
