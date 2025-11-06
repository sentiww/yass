namespace Yass.Console;

[Contract]
public partial class Data
{
    public Data(int id, decimal total, DateTime createdUtc)
    {
        Id = id;
        Total = total;
        CreatedUtc = createdUtc;
    }

    [Member(1)] 
    public int Id { get; set; }

    [Member(2)] 
    public decimal Total { get; set; }
    
    [Member(3)] 
    public DateTime CreatedUtc { get; set; }
}