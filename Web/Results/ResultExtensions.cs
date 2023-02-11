using Microsoft.AspNetCore.Mvc;

namespace Web.Results;

public static class ResultExtensions
{
    public static IActionResult ApiResult<T>(this Result<T> result)
    {
        return new ApiResult<T>(result);
    }

    public static IActionResult ApiResult<T>(this Task<Result<T>> result)
    {
        return new ApiResult<T>(result.Result);
    }

    public static IActionResult ApiResult(this Result result)
    {
        return new ApiResult(result);
    }

    public static IActionResult ApiResult(this Task<Result> result)
    {
        return new ApiResult(result.Result);
    }

    public static IActionResult ApiResult<T>(this T result)
    {
        return Result<T>.Success(result).ApiResult();
    }

    public static IActionResult ApiResult<T>(this Task<T> result)
    {
        return result.Result.ApiResult();
    }
}
