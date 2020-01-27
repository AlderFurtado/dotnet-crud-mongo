namespace TicketsApi.Models
{
    public class TicketstoreDatabaseSettings : ITicketstoreDatabaseSettings
    {
        public string TicketsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITicketstoreDatabaseSettings
    {
        string TicketsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}