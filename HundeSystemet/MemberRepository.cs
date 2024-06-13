using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeSystemet
{
    internal class MemberRepository
    {
        private List<Member> members = new List<Member>();

        //tilføj et medlem til listen
        public void AddMember(Member member)
        {
            members.Add(member);
        }

        //Hent et medlem baseret på ID
        public Member GetMember(int id)
        {
            return members.FirstOrDefault(m => m.ID == id);
        }

        //Opdater et medlem
        public void UpdateMember(Member updatedMember)
        {
            var member = GetMember(updatedMember.ID);
            if (member != null)
            {
                member.Name = updatedMember.Name;
                member.Adresse = updatedMember.Adresse;
                member.BirthDate = updatedMember.BirthDate;
                member.Phone = updatedMember.Phone;
                member.Email = updatedMember.Email;
            }
        }

        //Slet et medlem baseret på ID
        public void DeleteMember(int id)
        {
            var member = GetMember(id);
            if (member != null)
            {
                members.Remove(member);
            }
        }
    }
}

