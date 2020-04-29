using System;
using System.Collections.Concurrent;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Infrastructure
{
	public static class MappingExtensions
	{
		private static readonly ConcurrentDictionary<Type, TypePropertyCollection> PropertyInfoContainers
			= new ConcurrentDictionary<Type, TypePropertyCollection>();

		public static TEntity AsNewEntity<TEntity>(this TEntity entityToMapFrom,
			bool ignoreBase = false,
			TEntity entityToMapTo = null)
			where TEntity : HaveId, new()
		{
			var requiredContainer = PropertyInfoContainers.GetOrAdd(typeof(TEntity), type =>
			{
				var declaredProperties = TypeHelper.GetDeclaredPropertiesOf<TEntity>();
				var baseProperties = TypeHelper.GetBasePropertiesOf<TEntity>();
				return new TypePropertyCollection(typeof(TEntity), declaredProperties, baseProperties);
			});

			var newEntity = entityToMapTo ?? new TEntity();

			var properties = ignoreBase
				? requiredContainer.PublicProperties
				: requiredContainer.AllProperties;

			foreach (var property in properties)
			{
				var value = property.GetValue(entityToMapFrom);
				if (value != default)
					property.SetValue(newEntity, value);
			}

			return newEntity;
		}
	}
}