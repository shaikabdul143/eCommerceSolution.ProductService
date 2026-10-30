namespace eCommerce.BusinessLogicLayer.DTO;

public record ProductUpdateRequest(Guid ProductID, string ProductName, CategoryOptions Category, double? UnitPrice, int? QuantityInStock)
{
    public ProductUpdateRequest() : this(Guid.Empty, string.Empty, default, null, null)
    {
    }
}
