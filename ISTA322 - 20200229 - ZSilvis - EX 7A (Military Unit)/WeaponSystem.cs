using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class WeaponSystem
    {
        private string weaponCaliber;
        private string weaponType;
        private string weaponName;
        public virtual void Load()
        {
            Console.WriteLine($"The {weaponName} is locked and loaded!");
        }

        public virtual void Fire()
        {
            Console.WriteLine($"The {weaponName} fires!");
        }

        public virtual void Clean()
        {
            Console.WriteLine($"This {weaponName} is filthy after completeing the mission, time to clean it!");
        }

        public WeaponSystem()
        {
            weaponCaliber = "Default Caliber Size";
            weaponType = "Default Weapon Type";
            weaponName = "Default Weapon Name";            
        }

        public WeaponSystem(string weaponCaliber, string weaponType , string weaponName)
        {
            this.weaponCaliber = weaponCaliber;
            this.weaponType = weaponType;
            this.weaponName = weaponName;
        }

    }
}
