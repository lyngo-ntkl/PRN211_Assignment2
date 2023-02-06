using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class MemberRepo : IMemberRepo
    {
        private readonly FstoreContext _db;

        public MemberRepo()
        {
            _db = new();
        }

        public void CreateMember(Member member)
        {
            if(member != null)
            {
                _db.Members.Add(member);
                _db.SaveChanges();
            }
        }

        public void DeleteMember(Member member)
        {
            _db.Members.Remove(member);
            _db.SaveChanges();
        }

        public IEnumerable<Member> GetMembers() => _db.Members.ToList();

        public void UpdateMember(Member member)
        {
            if (member != null)
            {
                _db.Members.Update(member);
                _db.SaveChanges();
            }
        }
    }
}
