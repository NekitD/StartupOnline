namespace API.Models;
public class Lobby
{
    public int Id {get; set;}
    public char[255] Name {get; set;} = "";
    public int Size;
    public int Busy;
    public int Port;
    public bool Began;
    public int Creator;
}