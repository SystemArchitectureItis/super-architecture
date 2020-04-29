using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Infrastructure
{
	public static class TypeHelper
	{
		public static IEnumerable<PropertyInfo> GetDeclaredPropertiesOf<TEntity>()
			where TEntity : HaveId
		{
			return typeof(TEntity)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(propertyInfo => !BasePropertyPredicate(propertyInfo) && propertyInfo.CanWrite);
		}

		public static IEnumerable<PropertyInfo> GetBasePropertiesOf<TEntity>()
			where TEntity : HaveId
		{
			return typeof(TEntity)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(BasePropertyPredicate);
		}

		private static bool BasePropertyPredicate(PropertyInfo propertyInfo)
		{
			return propertyInfo.DeclaringType == typeof(HaveId);
		}
	}
}