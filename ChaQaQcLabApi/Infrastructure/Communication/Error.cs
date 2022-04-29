namespace ChaQaQcLabApi.Infrastructure.Communication;

public class Error
{
    public string ErrorCode { get; protected set; }
    public string Message { get; protected set; }
    public string Detail { get; protected set; }
    public Error(string errorCode, string message, string detail)
    {
        ErrorCode = errorCode;
        Message = message;
        Detail = detail;
    }
    public static Error BadRequest(string errorType, string detail)
    {
        return new Error($"BadRequest.{errorType}", "Request could not be process because of invalid request.", detail);
    }
    public static Error Unexpected(string detail)
    {
        return new Error("Unexpected", "An unexpected error has occurred.", detail);
    }
    public static Error NotFound(string resourceType, string id)
    {
        return new Error($"NotFound.{resourceType}", $"{resourceType} with ID {id} could not be found", "");
    }
}
