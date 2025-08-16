using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            return Source.First(s => s.UserName == "demo");
        }

        public Sample FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            return Source.FirstOrDefault(s => s.UserName == "skilltree");
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            return Source.First(s => s.UserName == "skilltree");
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            return Source.Single(s => s.UserName == "demo");
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            return Source.Single(s => s.UserName == "bill");
        }
        public Sample SingleOrDefaultToGetUserNameEuqalToBill()
        {
            return Source.SingleOrDefault(static s => s.UserName == "bill");
        }

        public Sample SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            return Source.SingleOrDefault(s => s.UserName == "skilltree");
        }
    }
}