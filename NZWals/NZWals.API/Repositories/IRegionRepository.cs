﻿using NZWals.API.Model.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsyc();
    }
}