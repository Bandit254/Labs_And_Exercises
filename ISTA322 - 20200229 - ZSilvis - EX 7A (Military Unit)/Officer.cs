using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class Officer : Personnel
    {
        private string officerName;
        private string officerRank;
        private string officerPosition;
        private string officerSkill;

        public void AttendMeeting()
        {
            Console.WriteLine($"{officerRank} {officerName} attended a 3-hr meeting. Nothing got accomplished, but at least all of {officerRank} {officerName}'s 'friends' were there....");
        }

        public void ExhortTheTroops()
        {
            Console.WriteLine("We've got the enemy right where we want them, let's go!!!!");
        }

        public Officer() : base()
        {
            
        }

        public Officer(string officerName, string officerRank, string officerPosition, string officerSkill) : base (officerName, officerRank, officerPosition, officerSkill)
        {
            this.officerName = officerName;
            this.officerRank = officerRank;
            this.officerPosition = officerPosition;
            this.officerSkill = officerSkill;
        }
    }
}
