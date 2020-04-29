namespace SystemArchitecture.Models.Infrastructure
{
	public class Result
	{
		public static Result Successful()
		{
			return new Result()
			{
				Success = true
			};
		}

		public static Result Failure(string errorMsg)
		{
			return new Result()
			{
				Success = false,
				Message = errorMsg
			};
		}

		public bool Success { get; private set; }
		public string Message { get; private set; }
	}
}