using API.Models;

namespace API.Repositories;

public interface ILobbyRepository
{
    IEnumerable<User> GetAll();
    User? GetById(int id);
    User Add(User user);
    User? Update(int id, User comment);
    bool Delete(int id);
}