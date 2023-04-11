using Microsoft.Azure.Cosmos.Table;

namespace AzureFunctionsCommomLibrary.Data.Interfaces.TableStorage;

public interface ITableStorage<T>
{
    IEnumerable<T> GetAll();

    Task<TableResult?> InsertOrMerge(T entity);
}
