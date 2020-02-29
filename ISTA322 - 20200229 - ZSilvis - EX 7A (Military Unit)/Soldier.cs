using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class Soldier : Personnel
    {
        private string soldierName;
        private string soldierRank;
        private string soldierPosition;
        private string soldierSkill;

        public void AttendAppointment()
        {
            Console.WriteLine($"{soldierRank} {soldierName} went to yet ANOTHER appointment and 'missed out' on helping the rest of the squad.");
        }

        public void Complain()
        {
            Console.WriteLine("But Sergeant, we did PT yesterday! Do we have to do it again today?!?");
        }

        public Soldier() : base()
        {
            soldierName = "Joe Snuffy";
            soldierRank = "PVT";
            soldierPosition = "Infantryman";
            soldierSkill = "Shamming";
        }

        public Soldier(string soldierName, string soldierRank, string soldierPosition, string soldierSkill) : base(soldierName, soldierRank, soldierPosition, soldierSkill)
        {
            this.soldierName = soldierName;
            this.soldierRank = soldierRank;
            this.soldierPosition = soldierPosition;
            this.soldierSkill = soldierSkill;
        }
    }
}
