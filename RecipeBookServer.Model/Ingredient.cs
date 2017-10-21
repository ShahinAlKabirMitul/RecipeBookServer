using System.ComponentModel.DataAnnotations;

namespace RecipeBookServer.Model
{
  public  class Ingredient:Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Amount { get; set; }

        public string RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

    }
}
