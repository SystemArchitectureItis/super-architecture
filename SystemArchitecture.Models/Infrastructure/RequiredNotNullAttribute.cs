using System;
using System.ComponentModel.DataAnnotations;

namespace SystemArchitecture.Models.Infrastructure
{
	public class RequiredNotNullAttribute : RequiredAttribute
	{
		public RequiredNotNullAttribute()
		{
			AllowEmptyStrings = false;
		}

		public override bool IsValid(object value)
		{
			if (value == null)
				// throw new ArgumentNullException(nameof(value));
				return false;
			return base.IsValid(value);
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
				// throw new ArgumentNullException(nameof(value));
				return new ValidationResult("Cannot be null");
			
			return base.IsValid(value, validationContext);
		}
	}
}