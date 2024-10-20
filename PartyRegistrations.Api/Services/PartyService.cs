using PartyRegistrations.Api.Storage;

namespace PartyRegistrations.Api.Services;

public class PartyService
{
    private readonly PartyDatabase _partyDatabase;

    public PartyService(PartyDatabase partyDatabase)
    {
        _partyDatabase = partyDatabase;
    }

    public IEnumerable<Party> GetParties(DateTime? dateTimeFrom)
    {
        if (dateTimeFrom.HasValue)
        {
            return _partyDatabase.GetParties().Where(p => p.Date >= dateTimeFrom);
        }

        return _partyDatabase.GetParties();
    }

    public void AddParty(string name, DateTime date)
    {
        _partyDatabase.AddParty(name, date);
    }

    public Party? GetParty(Guid id)
    {
        return _partyDatabase.GetParty(id);
    }
}
