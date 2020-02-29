using System;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISTA322 - 20200229 - ZSilvis - EX 7A (Working with Inheritance - Making a Military Unit)");
            Console.WriteLine("\n");
            ExecuteMission();
        }

        public static void ExecuteMission()
        {
            // Create Personnel
            Officer ltcZuniga = new Officer("Salvador Zuniga", "LTC", "Battalion Commander", "Lifting Heavy Objects");
            Officer majMiller = new Officer("Erik Miller", "MAJ", "Battalion XO", "Biting Sarcasm");
            NonCommissionedOfficer csmLowery = new NonCommissionedOfficer("Eric Lowery", "CSM", "Battalion Command Sergeant Major", "Maniacal Cackling");
            NonCommissionedOfficer fsgSmith = new NonCommissionedOfficer("Charles Smith", "1SG", "HHC First Sergeant", "Holding early formations");
            Officer cptPerlee = new Officer("Devon Perlee", "CPT", "Mortar Platoon Leader", "Incinerating Vehicles");
            Soldier stPete = new Soldier("St. Pierre", "SPC", "CSM's Driver", "Reading Books");
            Soldier grunt1 = new Soldier();
            Soldier grunt2 = new Soldier();
            Soldier grunt3 = new Soldier();
            Soldier grunt4 = new Soldier();
            Soldier grunt5 = new Soldier();
            Soldier grunt6 = new Soldier();

            // Create Weapons
            Rifle rifle1 = new Rifle();
            Rifle rifle2 = new Rifle();
            Rifle rifle3 = new Rifle();
            Rifle rifle4 = new Rifle();
            Rifle m16 = new Rifle("5.56", "Carbine", "M16");
            IndirectFireSystem crispyCritter = new IndirectFireSystem("120mm", "Mortar", "HHC-304", 7200);
            IndirectFireSystem paladin = new IndirectFireSystem("155mm", "Artillery", "Paladin #A-32", 18000);
            WeaponSystem m240B = new WeaponSystem("7.62mm", "Machine Gun", "M240B");

            // Create Vehicles
            Vehicle hq37 = new Vehicle("HMMWV", "Personnel Transport", "HQ-37");
            TrackedVehicle hq33 = new TrackedVehicle("Infantray Fighting Vehicle", "Infantry Transport / Support", "HQ-33", true, 6);
            TrackedVehicle hq66 = new TrackedVehicle("Tank", "Destroyer of Worlds", "HQ-66", false, 0);

            //Roll Call
            Console.WriteLine("Welcome to Ft. Bliss, TX where the 1-37 AR Bandits are preparing for a critical mission. The day starts early with a formation, lead by 1SG Smith\n");
            fsgSmith.Speak();
            Console.WriteLine("1SG Smith continues: 'Alright, since you now know who I am, everyone else in formation sound off! Start from the top!'");
            Console.WriteLine("\n");
            ltcZuniga.Speak();
            majMiller.Speak();
            csmLowery.Speak();
            cptPerlee.Speak();
            stPete.Speak();
            grunt1.Speak();
            grunt2.Speak();
            grunt3.Speak();
            grunt4.Speak();
            grunt5.Speak();
            grunt6.Speak();
            Console.WriteLine("\n");
            Console.WriteLine("1SG Smith: 'Wait a minute! Do you all really share the same name, PVT Joe Snuffy?!?'");
            Console.WriteLine("Grunts in unison: 'Yes we do!'");

            //Prep for mission
            Console.WriteLine("1SG Smith: 'Fine. Let's go do some PT before we do this mission'");
            grunt1.Complain();
            Console.WriteLine("CSM Lowery: 'Did you just call a 1SG a 'Seargeant?!?' Come over here and get your counseling!'");
            csmLowery.GiveCounselingStatement();
            Console.WriteLine("1SG Smith: 'Alright, anything else before we begin?'");
            grunt2.AttendAppointment();
            grunt3.UseSkill();
            Console.WriteLine("\n");
            Console.WriteLine("1SG Smith: 'At this point, let's just start getting ready for the mission. Go draw your weapons from the arms room and get them loaded'");
            Console.WriteLine("CSM Lowery: 'Hey, St. Pete! You go get my HMMWV ready to go!'");
            Console.WriteLine("St. Pete: 'Roger that, Sergeant Major!!!!!'");
            rifle1.Load();
            rifle2.Load();
            rifle3.Load();
            rifle4.Load();
            m240B.Load();
            Console.WriteLine("\n");

            //Continue prepping for the mission
            Console.WriteLine("--While the Soldiers are getting ready, some of the officers have to handle other business--");
            ltcZuniga.AttendMeeting();
            Console.WriteLine($"MAJ Miller has to attend a separate meeting, but he has a different opinion of meetings and the dimwitted people who attend them...");
            majMiller.UseSkill();
            Console.WriteLine("...meetings typically end soon after MAJ Miller gets sarcastic.\n");

            //Getting the heavy equipment ready
            Console.WriteLine("CPT Perlee, since he is the Mortar Platoon Leader, is put in charge of getting the indirect fire systems ready to go");
            crispyCritter.Load();
            crispyCritter.DisplayRange();
            paladin.Load();
            paladin.DisplayRange();
            Console.WriteLine("After the dismounts have secured their weapons and ammunition from the arms room, they head over to MAJ Miller's Bradley (HQ-33) to load up");
            hq33.LoadPersonnel();
            Console.WriteLine("Some stragglers attempt to get in the commander's tank, HQ-66");
            hq66.LoadPersonnel();
            Console.WriteLine("\n");

            //Begin the mission
            Console.WriteLine("LTC Zuniga, after confirming that preparations are complete, gives the order to begin the mission");
            Console.WriteLine("MAJ Miller specifies that the order of march for the vehicles will be HQ-66, HQ-33, HQ-37, HHC-304, and finally Paladin #A-32.");
            Console.WriteLine("Just before leaving the motorpool, however, CPT Perlee uses his special skill!");
            cptPerlee.UseSkill();
            Console.WriteLine("Oh no! The mortar vehicle burst into flames! It won't be able to participate in the mission anymore!");
            crispyCritter.Clean();
            Console.WriteLine("LTC Zuniga: 'Start the mission anyways! Get LT Stoll to figure out what happened!'");
            Console.WriteLine("The rest of the vehicles beging to move out of the motor pool");
            ltcZuniga.DriveVehicle("HQ-66");
            hq66.Accelerate();
            majMiller.DriveVehicle("HQ-33");
            hq33.Accelerate();
            stPete.DriveVehicle("HQ-37");
            hq37.Accelerate();
            hq66.Drive();
            hq33.Drive();
            hq37.Drive();
            Console.WriteLine("\n");

            //Reaching the objective
            Console.WriteLine("Shortly before reaching the objective, disaster strike again: HQ-37 runs out of fuel and HQ-66 breaks down!");
            hq37.Refuel();
            Console.WriteLine("CSM Lowery: 'Dang it St. Pete! I thought you said this HMMWV was ready to go?!?'");
            stPete.UseSkill();
            Console.WriteLine("St. Pete: 'Sorry CSM! I got caught up reading Twighlight and forgot to put fuel in the vehicle!'");
            hq66.BreakDown();
            Console.WriteLine("Fortunately, MAJ Miller and his team make it to the objective. The immediately begin attacking the enemy.");
            hq33.UnloadPersonnel();
            rifle1.Fire();
            rifle2.Fire();
            rifle3.Fire();
            rifle4.Fire();
            m240B.Fire();
            Console.WriteLine("Despite being stuck away from the fight, LTC Zuniga encourages the Soldiers over the radio:");
            ltcZuniga.ExhortTheTroops();
            Console.WriteLine("MAJ Miller suggests that LTC Zuniga and his team dismount from HQ-66 and come help them on the objective, but LTC Zuniga declines:");
            hq66.UnloadPersonnel();
            Console.WriteLine("Despite the reduced manpower and equipment, MAJ Miller is soon ready to call in the final blow. He calls back to the rear and requests artillery fire from the Paladins");
            paladin.Fire();
            Console.WriteLine("MAJ Miller: 'Great shot! Fire for effect!'");
            paladin.Fire();
            Console.WriteLine("What's the sound of artillery?!?!");
            paladin.Fire();
            Console.WriteLine("BOOM BOOM!!");
            paladin.Fire();
            Console.WriteLine("Raining down on the enemy!!!");
            paladin.Fire();
            Console.WriteLine("BOOM BOOM!!");
            Console.WriteLine("MAJ Miller: 'That does it, the enemy is in full retreat. Let's head back to Ft. Bliss!'");
            Console.WriteLine("\n");

            //Return to Ft. Bliss and cleaning of equipment
            Console.WriteLine("One by one the vehicles return to the motor pool and park in their spots");
            hq66.Stop();
            hq33.Stop();
            hq37.Stop();
            Console.WriteLine("CSM Lowery: 'Great Job everyone! Make sure to clean your equipment!'");
            rifle1.Clean();
            m240B.Clean();
            paladin.Clean();
            Console.WriteLine("\n");

            //The end
            Console.WriteLine("All of the Bandits returned safely. They were proud of accomplishing the mission, but LT Stoll hadn't yet figured out what had happened to the mortar track....some say he never will");
            Console.WriteLine("THAT'S ALL, FOLKS!");


        }
        



    }
}
