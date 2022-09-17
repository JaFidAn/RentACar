namespace CoreApplication.Pipelines.Authorization;

public interface ISecuredRequest
{
    public string[] Roles { get; }
}