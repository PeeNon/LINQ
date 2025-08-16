using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> AscendingId()
        {
            return Source.OrderBy(s => s.Id).ToList();
        }

        public List<Sample> DescendingId()
        {
            return Source.OrderByDescending(s => s.Id).ToList();
        }

        public List<Sample> AscendingPriceAndThenAscendingId()
        {
            return Source.OrderBy(s => s.Price).ThenBy(s => s.Id).ToList();
        }
    }
}