using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class Personnel
    {
        private string personnelName;
        private string personnelRank;
        private string personnelPosition;
        private string personnelSkill;
        

        public void Speak()
        {
            Console.WriteLine($"Hello there! My name is {personnelRank} {personnelName}. My job is {personnelPosition}");
        }

        public void UseWeapon(string weaponName)
        {
            Console.WriteLine($"{personnelName} uses the {weaponName}!");                
        }

        public void UseSkill()
        {
            Console.WriteLine($"{personnelRank} {personnelName} used {personnelSkill}!");
        }

        public void DriveVehicle(string vehicleName)
        {
            Console.WriteLine($"{personnelRank} {personnelName} hopped in the {vehicleName} and took off!");
        }

        public Personnel()
        {
            personnelName = "Joe Snuffy";
            personnelRank = "PVT";
            personnelPosition = "Infantryman";
            personnelSkill = "Sham Out";
        }

        public Personnel(string personnelName, string personnelRank, string personnelPosition, string personnelSkill)
        {
            this.personnelName = personnelName;
            this.personnelRank = personnelRank;
            this.personnelPosition = personnelPosition;
            this.personnelSkill = personnelSkill;
        }

    }
}
