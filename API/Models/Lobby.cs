namespace API.Models;
class Lobby
{
    public int Id {get; set;}
    public char[255] Name {get; set;} = "";
    public int size;
    public int busy;
    public int port;
    public bool began;
    public int creator;
};