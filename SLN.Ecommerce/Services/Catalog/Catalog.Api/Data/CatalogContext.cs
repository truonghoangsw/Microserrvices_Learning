﻿using Catalog.Api.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DataBaseSettings:ConnectionString"));
            var dataBase = client.GetDatabase(configuration.GetValue<string>("DataBaseSettings:DatabaseName"));
            Products = dataBase.GetCollection<Product>(configuration.GetValue<string>("DataBaseSettings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}