using Microsoft.AspNetCore.Mvc;

namespace Web.Results;

public sealed class ApiResult : IActionResult
{
    private readonly Result _result;

    public ApiResult(Result result)
    {
        _result = result;
    }

    public Task ExecuteResultAsync(ActionContext context)
    {
        if (!_result.IsError)
        {
            return context.Ok(_result.Message);
        }

        return context.UnprocessableEntity(_result.Message);
    }
}
