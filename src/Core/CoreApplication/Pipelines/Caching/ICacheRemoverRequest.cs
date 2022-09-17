namespace CoreApplication.Pipelines.Caching;

public interface ICacheRemoverRequest
{
    bool BypassCache { get; }
    string CacheKey { get; }
}