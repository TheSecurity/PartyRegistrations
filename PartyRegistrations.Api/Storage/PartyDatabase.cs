using System.IO;

namespace PartyRegistrations.Api.Storage;

public class PartyDatabase
{
    private readonly List<Party> _parties = [];

    public PartyDatabase()
    {
        _parties =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Birthday Party",
                Date = new DateTime(2021, 12, 24, 20, 0, 0),
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "New Year's Party",
                Date = new DateTime(2021, 12, 31, 22, 0, 0),
            }
        ];
    }

    public void AddParty(string name, DateTime date)
    {
        _parties.Add(new Party
        {
            Id = Guid.NewGuid(),
            Name = name,
            Date = date
        });
    }

    public IEnumerable<Party> GetParties()
    {
        return _parties;
    }

    public Party? GetParty(Guid id)
    {
        return _parties.Find(p => p.Id == id);
    }
}
