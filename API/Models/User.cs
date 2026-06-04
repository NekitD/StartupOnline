
namespace API.Models;
class User
{
    public int Id {get; set;}
    public char[255] Login {get; set;} = "";
    public char[255] Password {get; set;} = "";
    public bool online;
    public int score;
    public char[255] Address {get; set;} = "";
    public int port;
};