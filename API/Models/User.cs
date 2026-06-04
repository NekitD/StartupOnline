namespace API.Models;
public class User
{
    public int Id {get; set;}
    public char[255] Login {get; set;} = "";
    public char[255] Password {get; set;} = "";
    public bool Online;
    public int Score;
    public char[255] Address {get; set;} = "";
    public int Port;
}