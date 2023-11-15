using AB12.Application.Users.Commands;
using AB12.Application.Users.Results;
using AB12.Domain.Base.Schema;
using AB12.Infrastructure.Components;
using AutoMapper;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace AB12.Services.Components;

[ScopedService]
public class UserService
{
  private readonly IMapper _mapper;
  private readonly UserRepo _repo;

  public UserService(
    IMapper mapper,
    UserRepo repo
    )
  {
    _mapper = mapper;
    _repo = repo;
  }

  public async Task<UserResult> CreateAsync(CreateUserCommand command)
  {
    var user = _mapper.Map<User>(command);
    await _repo.CreateAsync(user);
    return _mapper.Map<UserResult>(user);
  }
}