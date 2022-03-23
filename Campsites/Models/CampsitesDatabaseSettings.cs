namespace Campsites.Models;

public class CampsitesDatabaseSettings
{
    public static string SectionName = "SitesDatabase";
    public string ConnectionString { get; set; } = "";
    public string DatabaseName { get; set; } = "";
    public string SitesCollectionName { get; set; } = "";
}