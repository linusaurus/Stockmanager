


namespace Service.Contracts
{
    public interface ILocationService
    {
        IEnumerable<Entities.Models.Location> GetLocations(bool trackChanges);
        IEnumerable<Entities.Models.Part> GetLocationParts(int locationID, bool trackChanges);
    }
}