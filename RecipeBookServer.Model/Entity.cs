using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookServer.Model
{
   public class Entity
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        [MaxLength(100)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime Modified { get; set; }
        [Required]
        [MaxLength(100)]
        public string ModifiedBy { get; set; }

    }
}
