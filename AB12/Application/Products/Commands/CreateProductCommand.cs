using AB12.Domain.Base.Schema;
using AB12.Services.Application;
using AutoMapper;

namespace AB12.Application.Products.Commands;

public class CreateProductCommand : IMapFrom<Product>
{
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }

  public void Mapping(Profile profile)
  {
    profile.CreateMap<CreateProductCommand, Product>()
      .ReverseMap();
  }
}