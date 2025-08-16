using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            return Source.Where(s => s.Id > 8).ToList();
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            return Source.Where(s => s.Price == 200).ToList();
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            return Source.Where(s => s.UserName.StartsWith("d")).ToList();
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            return Source.Where(s => s.UserName.Contains("e")).ToList();
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            return Source.Where(s => s.UserName.EndsWith("o")).ToList();
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            return Source.Where(s => whereStr.Contains(s.UserName)).ToList();
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            return Source.Any(s => s.Id == 99);
        }
    }
}