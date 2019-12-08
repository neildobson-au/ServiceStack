﻿using System.Collections.Generic;
using System.Linq;
using Neo4j.Driver.V1;

namespace ServiceStack.Authentication.Neo4j
{
    internal static class RecordExtensions
    {
        public static IEnumerable<TReturn> Map<TReturn>(
            this IEnumerable<IRecord> records)
        {
            return records.Select(record => record.Map<TReturn>());
        }

        public static TReturn Map<TReturn>(this IRecord record)
        {
            return ((IEntity) record[0]).Properties.FromObjectDictionary<TReturn>();
        }
    }
}