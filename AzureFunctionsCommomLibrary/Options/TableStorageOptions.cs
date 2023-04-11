namespace AzureFunctionsCommomLibrary.Options;

public class TableStorageOptions
{
    public string ConnectionString { get; init; } = string.Empty;
    public string TableName { get; init; } = string.Empty;

}