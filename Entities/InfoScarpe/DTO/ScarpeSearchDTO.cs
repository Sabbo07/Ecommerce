

namespace Ecommerce.Entities.InfoScarpe.DTO
{
    public class ScarpaSearchDto
{
    public int? ModelloId { get; set; } // Nullable to allow optional searching
    public int? BrandId { get; set; }
    public int? CategoriaId { get; set; }
    public int? ColoreId { get; set; }
}
}