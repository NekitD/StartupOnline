namespace Backend.Services;

using Backend.Models;
using Backend.Repositories;
public class UserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<User> GetAll() => _repository.GetAll();
    public User? GetById(int id) => _repository.GetById(id);
    public User Add(User User) => _repository.Add(User);
    public User? Update(int id, User User) => _repository.Update(id, User);
    public bool Delete(int id) => _repository.Delete(id);
}