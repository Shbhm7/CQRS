using MediatR;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto>
{
    public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        
        var product = new ProductDto { Id = request.ProductId, Name = "Sample Product", Price = 10.99m };
        return product;
    }
}