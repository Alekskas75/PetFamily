using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Shared
{
    public class Result
    {
        public string? Error { get; set; }
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

        public Result(bool isSuccess, string error)
        {
            if (IsSuccess && error is not null)
            {
                throw new InvalidOperationException();
            }
            if (IsSuccess == false && error == null)
            {
                throw new InvalidOperationException("Ошибка в Result");
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success() => new Result(true, null);
        public static Result Failure(string error) => new Result(true, error);
    }

    public class Result<TValue> : Result
    {
        private readonly TValue _value;

        public Result(TValue value, bool isSuccess, string error) : base(isSuccess, error)
        {
            _value = value;
        }

        public TValue Value => IsSuccess ?
            _value :
            throw new InvalidOperationException("Ошибка в Result<TValue>");
        public static Result<TValue> Success(TValue value) => new Result<TValue>(value, true, null);

    }
}
