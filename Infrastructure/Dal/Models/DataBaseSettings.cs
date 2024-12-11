namespace Infrastructure.Dal.Models;

public class DataBaseSettings
{ 
    public string ConnectionString { get; set; }
    public int CommandTimeout { get; set; }
}