using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBookServer.Model
{
  public class Recipe:Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string ImagePath { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
