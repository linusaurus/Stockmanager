


using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ILocationService
    {
        IEnumerable<Entities.Models.Location> GetLocations(bool trackChanges);
        IEnumerable<Shared.DataTransferObjects.PartSearchList> GetLocationParts(int locationID, bool trackChanges);
        RackLabelDto? GetRackLabel(int locationID,bool trackChanges);

        IEnumerable<RackLabelDto> GetLocationsList(bool trackChanges);
    }
}