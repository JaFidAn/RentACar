namespace CoreElasticSearch.Models;

public interface IElasticSearchResult
{
    bool Success { get; }
    string Message { get; }
}