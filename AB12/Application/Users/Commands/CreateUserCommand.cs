using AB12.Domain.Base.Schema;
using AB12.Services.Application;
using AutoMapper;

namespace AB12.Application.Users.Commands;

public class CreateUserCommand : IMapFrom<User>
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  public string Password { get; set; }

  public void Mapping(Profile profile)
  {
    profile.CreateMap<CreateUserCommand, User>()
    .ReverseMap();
  }
}