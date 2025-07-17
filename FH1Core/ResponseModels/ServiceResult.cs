namespace FH1Core.ResponseModels;

public class ServiceResult<T>
{
    public bool Success { get; private set; }
    public string Message { get; private set; } = "";
    public T? Data { get; private set; }

    public static ServiceResult<T> SuccessResult(T data) =>
    new() { Success = true, Data = data };

    public static ServiceResult<T> Failure(string message) =>
        new() { Success = false, Message = message };
}
