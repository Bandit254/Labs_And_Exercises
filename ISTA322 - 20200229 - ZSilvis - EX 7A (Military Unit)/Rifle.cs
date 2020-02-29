using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class Rifle : WeaponSystem
    {
        private string rifleCaliber;
        private string rifleType;
        private string rifleName;
        public override void Load()
        {
            Console.WriteLine($"New magazine is locked and loaded in the {rifleName}!");
        }

        public override void Fire()
        {
            Console.WriteLine("Pew Pew Pew! Got 'em center of mass, great shot!");
        }

        public override void Clean()
        {
            Console.WriteLine("Look at all the carbon in the starchamber! Better clean this out before returning it to the arms room!");
        }

        public Rifle() : base()
        {
            rifleCaliber = "5.56";
            rifleType = "Carbine";
            rifleName = "M4";

        }

        public Rifle(string rifleCaliber, string rifleType, string rifleName) : base(rifleCaliber, rifleType, rifleName)
        {
            this.rifleCaliber = rifleCaliber;
            this.rifleType = rifleType;
            this.rifleName = rifleName;
        }


    }
}
