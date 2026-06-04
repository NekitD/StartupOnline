using API.Models;

namespace API.Repositories;

public interface ILobbyRepository
{
    IEnumerable<Lobby> GetAll();
    Lobby? GetById(int id);
    Lobby Add(Lobby lobby);
    Lobby? Update(int id, Lobby comment);
    bool Delete(int id);
}