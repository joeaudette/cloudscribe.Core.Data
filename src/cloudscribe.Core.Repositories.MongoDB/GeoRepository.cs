﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using cloudscribe.Core.Models.Geography;

namespace cloudscribe.Core.Repositories.MongoDB
{
    // Help Wanted!
    //TODO: implement by uncommenting methods one by one and replace the example EF implementation 
    // with Mongo implementation, then uncomment IGeoRepository
    // I left the EF code in here to show the intent and logic of the methods

    public class GeoRepository //: IGeoRepository
    {
        public GeoRepository()
        {
        }

        //public async Task<bool> Add(IGeoCountry geoCountry, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (geoCountry == null) { return false; }

        //    GeoCountry country = GeoCountry.FromIGeoCountry(geoCountry); 
        //    if (country.Guid == Guid.Empty)
        //    {
        //        country.Guid = Guid.NewGuid();
        //    }

        //    dbContext.Countries.Add(country);

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;
        //}

        //public async Task<bool> Update(IGeoCountry geoCountry, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (geoCountry == null) { return false; }

        //    GeoCountry country = GeoCountry.FromIGeoCountry(geoCountry); // convert from IGeoCountry

        //    bool tracking = dbContext.ChangeTracker.Entries<GeoCountry>().Any(x => x.Entity.Guid == country.Guid);
        //    if (!tracking)
        //    {
        //        dbContext.Countries.Update(country);
        //    }

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;
        //}

        //public async Task<IGeoCountry> FetchCountry(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    GeoCountry item
        //        = await dbContext.Countries.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);

        //    return item;
        //}

        //public async Task<IGeoCountry> FetchCountry(string isoCode2, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await dbContext.Countries.SingleOrDefaultAsync(x => x.ISOCode2 == isoCode2, cancellationToken);
        //}

        //public async Task<bool> DeleteCountry(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result = false;
        //    var itemToRemove = await dbContext.Countries.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);
        //    if (itemToRemove != null)
        //    {
        //        dbContext.Countries.Remove(itemToRemove);
        //        int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);
        //        result = rowsAffected > 0;
        //    }

        //    return result;

        //}

        //public async Task<int> GetCountryCount(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await dbContext.Countries.CountAsync<GeoCountry>(cancellationToken);
        //}

        //public async Task<List<IGeoCountry>> GetAllCountries(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var query = from c in dbContext.Countries
        //                orderby c.Name ascending
        //                select c;

        //    var items = await query.AsNoTracking().ToListAsync<IGeoCountry>(cancellationToken);

        //    return items;

        //}

        //public async Task<List<IGeoCountry>> GetCountriesPage(int pageNumber, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    int offset = (pageSize * pageNumber) - pageSize;

        //    var query = dbContext.Countries.OrderBy(x => x.Name)
        //        .Select(p => p)
        //        .Skip(offset)
        //        .Take(pageSize)
        //        ;


        //    return await query.AsNoTracking().ToListAsync<IGeoCountry>(cancellationToken);

        //}

        //public async Task<bool> Add(IGeoZone geoZone, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (geoZone == null) { return false; }

        //    GeoZone state = GeoZone.FromIGeoZone(geoZone); // convert from IGeoZone

        //    if (geoZone.Guid == Guid.Empty)
        //    {
        //        state.Guid = Guid.NewGuid();
        //    }
        //    dbContext.States.Add(state);

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}

        //public async Task<bool> Update(
        //    IGeoZone geoZone,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (geoZone == null) { return false; }

        //    GeoZone state = GeoZone.FromIGeoZone(geoZone); // convert from IGeoZone

        //    bool tracking = dbContext.ChangeTracker.Entries<GeoZone>().Any(x => x.Entity.Guid == state.Guid);
        //    if (!tracking)
        //    {
        //        dbContext.States.Update(state);
        //    }

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}

        //public async Task<IGeoZone> FetchGeoZone(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    GeoZone item
        //        = await dbContext.States.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);

        //    return item;
        //}

        //public async Task<bool> DeleteGeoZone(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result = false;
        //    var itemToRemove = await dbContext.States.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);
        //    if (itemToRemove != null)
        //    {
        //        dbContext.States.Remove(itemToRemove);
        //        int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);
        //        result = rowsAffected > 0;
        //    }

        //    return result;
        //}

        //public async Task<bool> DeleteGeoZonesByCountry(Guid countryGuid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var query = from l in dbContext.States
        //                where l.CountryGuid == countryGuid
        //                select l;

        //    dbContext.States.RemoveRange(query);
        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);
        //    return rowsAffected > 0;
        //}

        //public async Task<int> GetGeoZoneCount(Guid countryGuid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await dbContext.States.CountAsync<GeoZone>(
        //        g => g.CountryGuid == countryGuid, cancellationToken);
        //}

        //public async Task<List<IGeoZone>> GetGeoZonesByCountry(Guid countryGuid, CancellationToken cancellationToken = default(CancellationToken))
        //{
            
        //    var query = dbContext.States
        //                .Where(x => x.CountryGuid == countryGuid)
        //                .OrderByDescending(x => x.Name)
        //                .Select(x => x);

        //    var items = await query.AsNoTracking().ToListAsync<IGeoZone>(cancellationToken);
        //    return items;


        //}

        //public async Task<List<IGeoCountry>> CountryAutoComplete(string query, int maxRows, CancellationToken cancellationToken = default(CancellationToken))
        //{
            
        //    var listQuery = dbContext.Countries
        //                    .Where(x => x.Name.Contains(query) || x.ISOCode2.Contains(query))
        //                    .OrderBy(x => x.Name)
        //                    .Take(maxRows)
        //                    .Select(x => x);

        //    var items = await listQuery.AsNoTracking().ToListAsync<IGeoCountry>(cancellationToken);
        //    return items;

        //}

        //public async Task<List<IGeoZone>> StateAutoComplete(Guid countryGuid, string query, int maxRows, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var listQuery = dbContext.States
        //                    .Where(x =>
        //                   x.CountryGuid == countryGuid &&
        //                   (x.Name.Contains(query) || x.Code.Contains(query))
        //                    )
        //                    .OrderBy(x => x.Code)
        //                    .Take(maxRows)
        //                    .Select(x => x);

        //    return await listQuery.AsNoTracking().ToListAsync<IGeoZone>(cancellationToken);

        //}

        //public async Task<List<IGeoZone>> GetGeoZonePage(
        //    Guid countryGuid,
        //    int pageNumber,
        //    int pageSize,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    int offset = (pageSize * pageNumber) - pageSize;

        //    var query = dbContext.States
        //       .Where(x => x.CountryGuid == countryGuid)
        //       .OrderBy(x => x.Name)
        //       .Skip(offset)
        //       .Take(pageSize)
        //       .Select(p => p)
        //       ;

        //    return await query.AsNoTracking().ToListAsync<IGeoZone>(cancellationToken);

        //}

        //public async Task<bool> Add(ILanguage language, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (language == null) { return false; }

        //    Language lang = Language.FromILanguage(language);

        //    if (lang.Guid == Guid.Empty)
        //    {
        //        lang.Guid = Guid.NewGuid();
        //    }

        //    dbContext.Languages.Add(lang);

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}

        //public async Task<bool> Update(ILanguage language, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (language == null) { return false; }

        //    Language lang = Language.FromILanguage(language);

        //    bool tracking = dbContext.ChangeTracker.Entries<Language>().Any(x => x.Entity.Guid == lang.Guid);
        //    if (!tracking)
        //    {
        //        dbContext.Languages.Update(lang);
        //    }

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}

        //public async Task<ILanguage> FetchLanguage(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    Language item
        //        = await dbContext.Languages.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);

        //    return item;
        //}

        //public async Task<bool> DeleteLanguage(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result = false;
        //    var itemToRemove = await dbContext.Languages.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);
        //    if (itemToRemove != null)
        //    {
        //        dbContext.Languages.Remove(itemToRemove);
        //        int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);
        //        result = rowsAffected > 0;
        //    }

        //    return result;
        //}

        //public async Task<int> GetLanguageCount(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return await dbContext.Languages.CountAsync<Language>(cancellationToken);

        //}

        //public async Task<List<ILanguage>> GetAllLanguages(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var query = dbContext.Languages
        //                .OrderBy(x => x.Name)
        //                .Select(x => x);

        //    var items = await query.AsNoTracking().ToListAsync<ILanguage>(cancellationToken);
        //    return items;

        //}

        //public async Task<List<ILanguage>> GetLanguagePage(int pageNumber, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    int offset = (pageSize * pageNumber) - pageSize;

        //    var query = dbContext.Languages
        //                .OrderBy(x => x.Name)
        //                .Skip(offset)
        //                .Take(pageSize)
        //                .Select(x => x);

        //    return await query.AsNoTracking().ToListAsync<ILanguage>(cancellationToken);

        //}


        //public async Task<bool> Add(ICurrency currency, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (currency == null) { return false; }

        //    Currency c = Currency.FromICurrency(currency);
        //    if (c.Guid == Guid.Empty)
        //    {
        //        c.Guid = Guid.NewGuid();
        //    }
        //    dbContext.Currencies.Add(c);

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}

        //public async Task<bool> Update(ICurrency currency, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    if (currency == null) { return false; }

        //    Currency c = Currency.FromICurrency(currency);

        //    bool tracking = dbContext.ChangeTracker.Entries<Currency>().Any(x => x.Entity.Guid == c.Guid);
        //    if (!tracking)
        //    {
        //        dbContext.Currencies.Update(c);
        //    }

        //    int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

        //    return rowsAffected > 0;

        //}


        //public async Task<ICurrency> FetchCurrency(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    Currency item
        //        = await dbContext.Currencies.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);

        //    return item;
        //}

        //public async Task<bool> DeleteCurrency(Guid guid, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result = false;
        //    var itemToRemove = await dbContext.Currencies.SingleOrDefaultAsync(x => x.Guid == guid, cancellationToken);
        //    if (itemToRemove != null)
        //    {
        //        dbContext.Currencies.Remove(itemToRemove);
        //        int rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);
        //        result = rowsAffected > 0;
        //    }

        //    return result;

        //}

        //public async Task<List<ICurrency>> GetAllCurrencies(CancellationToken cancellationToken = default(CancellationToken))
        //{

        //    var query = dbContext.Currencies
        //                .OrderBy(x => x.Title)
        //                .Select(x => x);

        //    var items = await query.AsNoTracking().ToListAsync<ICurrency>(cancellationToken);
        //    return items;

        //}


    }
}
