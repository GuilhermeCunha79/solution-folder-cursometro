﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Shared;

namespace ConsoleApp1.Infraestructure.Shared;

public class EntityIdValueConverter<TTypedIdValue> : ValueConverter<TTypedIdValue, String>
    where TTypedIdValue : EntityId
{
    public EntityIdValueConverter(ConverterMappingHints mappingHints = null) 
        : base(id => id.StringValue, value => Create(value), mappingHints)
    {
    }
    
    

    private static TTypedIdValue Create(String id) => Activator.CreateInstance(typeof(TTypedIdValue), id) as TTypedIdValue;
}