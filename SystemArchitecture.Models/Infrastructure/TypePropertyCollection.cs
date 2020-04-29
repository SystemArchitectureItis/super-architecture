using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SystemArchitecture.Models.Infrastructure
{
	public class TypePropertyCollection
	{
		public TypePropertyCollection(Type type,
			IEnumerable<PropertyInfo> publicProperties,
			IEnumerable<PropertyInfo> baseProperties = default)
		{
			Type = type;
			PublicProperties = publicProperties.ToArray();
			BaseProperties = baseProperties?.ToArray() ?? new PropertyInfo[0];
		}

		public Type Type { get; }
		public PropertyInfo[] PublicProperties { get; }
		public PropertyInfo[] BaseProperties { get; }

		public PropertyInfo[] AllProperties
			=> PublicProperties
				.Concat(BaseProperties)
				.ToArray();
	}
}