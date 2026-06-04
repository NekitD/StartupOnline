namespace Backend.Services;

using Backend.Models;
using Backend.Repositories;
public class LobbyService
{
    private readonly ILobbyRepository _repository;

    public LobbyService(ILobbyRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Lobby> GetAll() => _repository.GetAll();
    public Lobby? GetById(int id) => _repository.GetById(id);
    public Lobby Add(Lobby Lobby) => _repository.Add(Lobby);
    public Lobby? Update(int id, Lobby Lobby) => _repository.Update(id, Lobby);
    public bool Delete(int id) => _repository.Delete(id);
}