namespace PartyRegistrations.Api;

public class Party
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required DateTime Date { get; set; }
}
