using Microsoft.AspNetCore.Mvc;

namespace Web.Results
{
    public sealed class ApiResult<T> : IActionResult
    {
        private readonly Result<T> _result;

        public ApiResult(Result<T> result)
        {
            _result = result;
        }

        public Task ExecuteResultAsync(ActionContext context)
        {
            if (!_result.IsError)
            {
                return context.Ok(_result.Value);
            }

            return context.UnprocessableEntity(_result.Message);
        }
    }
}
