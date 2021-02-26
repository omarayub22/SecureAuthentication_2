namespace API.Entities
{
    public class AppUser
    {
    public int Id { get; set; }
    public string UserName { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    
    }
}


// what is ORM(An Object Relational Mapper)
// Translate our code into SQL commands that update our tables in the database
// LING-dbContext.Users.Add(User{id=4,Name= "Omar"})
// Entity Framework Features
//-- Querying,Change tracking, Saving, concurancy, Transaction, Caching, Builtin convention,congiguration,Migrations