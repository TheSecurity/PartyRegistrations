using PartyRegistrations.Api.Services;
using PartyRegistrations.Api.Storage;

namespace PartyRegistrations.Test;

public class PartyServiceTests
{
    [Fact]
    public void GetParties_ReturnsAllParties()
    {
        // Arrange
        var partyDatabase = new PartyDatabase();
        var partyService = new PartyService(partyDatabase);

        // Act
        var parties = partyService.GetParties(null);

        // Assert
        Assert.Equal(2, parties.Count());
    }
}
