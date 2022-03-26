using System.ComponentModel.DataAnnotations;

namespace EcommerceWeb.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligaotorio")]
        public string Name { get; set; }
    }
}
