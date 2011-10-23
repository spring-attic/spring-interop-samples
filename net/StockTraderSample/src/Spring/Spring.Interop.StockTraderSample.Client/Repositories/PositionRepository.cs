using System;
using System.Collections.Generic;
using GemStone.GemFire.Cache;
using GemStone.GemFire.Cache.Generic;
using Spring.Interop.StockTraderSample.Common.Data;


namespace Spring.Interop.StockTraderSample.Client.Repositories
{
    public class PositionRepository
    {

        private Region _region;

        public PositionRepository(Spring.Data.GemFire.ClientRegionFactoryObject region)
        {
            _region = region.GetObject() as Region;
        }
        
        public IEnumerable<Position> GetAllShares()
        {
            var positions = new List<Position>();

            RegionEntry[] regionEntries = _region.GetEntries(false);

            foreach (RegionEntry regionEntry in regionEntries)
            {
                positions.Add(new Position(regionEntry.Key.ToString(), Convert.ToInt32(regionEntry.Value.ToString())));
            }

            return positions;
        }
    }


}