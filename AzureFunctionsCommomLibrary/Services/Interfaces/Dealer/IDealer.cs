using AzureFunctionsCommomLibrary.DTOs;

namespace AzureFunctionsCommomLibrary.Services.Interfaces.Dealer;


public interface IDealer
{
    public TeamDTO[] SortTeams(IEnumerable<PlayerDTO> players, int numberOfTeams);
}