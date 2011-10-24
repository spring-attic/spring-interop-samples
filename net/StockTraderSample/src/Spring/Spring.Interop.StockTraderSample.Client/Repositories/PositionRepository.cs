using System;
using System.Collections.Generic;
using GemStone.GemFire.Cache;
using Spring.Interop.StockTraderSample.Common.Data;
using ICacheableKey = GemStone.GemFire.Cache.ICacheableKey;


namespace Spring.Interop.StockTraderSample.Client.Repositories
{
    public class PositionRepository
    {

        private Region _region;

        public PositionRepository(Region region)
        {
            _region = region;
        }

        public IEnumerable<Position> GetAllShares()
        {
            var positions = new List<Position>();           
            ICacheableKey[] keys = _region.GetServerKeys();
            foreach (var key in keys)
            {
                Console.WriteLine(key + ", " + _region.Get(key));
                positions.Add(new Position(key.ToString(), Convert.ToInt32(_region.Get(key).ToString())));

            }
            return positions;
        }
    }


}