using MediatR;

public class GetProductQuery:IRequest<ProductDto>
{
    public int ProductId { get; set; }
}