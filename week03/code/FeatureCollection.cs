public class FeatureCollection
{
    // The JSON has a list of earthquake features.
    public Feature[] Features { get; set; } = [];
}

public class Feature
{
    // Each feature stores its earthquake details in properties.
    public Properties Properties { get; set; } = new();
}

public class Properties
{
    // These names match the place and magnitude fields in the JSON.
    public string Place { get; set; } = "";
    public double Mag { get; set; }
}