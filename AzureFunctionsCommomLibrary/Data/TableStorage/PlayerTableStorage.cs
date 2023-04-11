using AzureFunctionsCommomLibrary.Data.Interfaces.TableStorage;
using AzureFunctionsCommomLibrary.Models;
using AzureFunctionsCommomLibrary.Options;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Options;

namespace AzureFunctionsCommomLibrary.Data.TableStorage;

public class PlayerTableStorage : IPlayerTableStorage
{
    private readonly CloudTable _table;

    public PlayerTableStorage(IOptions<TableStorageOptions> tableStorageOptions)
    {
        var connectionStrings = tableStorageOptions?.Value?.ConnectionString ?? throw new ArgumentNullException(nameof(TableStorageOptions));
        var tableName = tableStorageOptions?.Value?.TableName ?? throw new ArgumentNullException(nameof(TableStorageOptions));

        var cloudStorageAccount = CloudStorageAccount.Parse(connectionStrings);
        var tableClient = cloudStorageAccount.CreateCloudTableClient(new TableClientConfiguration());
        _table = tableClient.GetTableReference(tableName);
    }

    public IEnumerable<PlayerTableStorageEntity> GetAll()
    {
        TableQuery<PlayerTableStorageEntity> query = new();

        var tableResult = _table.ExecuteQuery(query);

        return tableResult;
    }

    public async Task<TableResult?> InsertOrMerge(PlayerTableStorageEntity entity)
    {
        var insertOrMergeOperation = TableOperation.InsertOrMerge(entity);

        var tableResult = await _table.ExecuteAsync(insertOrMergeOperation);

        return tableResult;
    }
}