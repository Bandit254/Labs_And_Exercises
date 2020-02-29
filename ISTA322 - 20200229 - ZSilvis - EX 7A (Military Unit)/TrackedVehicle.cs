using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA322___20200229___ZSilvis___EX_7A__Military_Unit_
{
    class TrackedVehicle : Vehicle
    {
        private string trackedVicType;
        private string trackedVicName;
        private string trackedVicFunction;
        private bool personnelCarrier;
        private int personnelCapacity;
        public override void Refuel()
        {
            Console.WriteLine($"Time to refuel the {trackedVicName}. This will take a while...tracked vehicles use a ton of fuel!");
        }

        public override void BreakDown()
        {
            Console.WriteLine($"Oh no! The {trackedVicName} threw track again! This will take hours to put back on");
        }

        public void LoadPersonnel()
        {
            if (personnelCarrier == true)
            {
                Console.WriteLine($"The ramp is down, we got room for {personnelCapacity} personnel in here. Let us know when everyone is inside");
            }else
            {
                Console.WriteLine($" This {trackedVicName} is only has room for the drivers and gunners! Guess you'll have to walk!");
            }

        }

        public void UnloadPersonnel()
        {
            if (personnelCarrier == true)
            {
                Console.WriteLine($"Alright, we've reached the objective! Time for all {personnelCapacity} of you to get out there and do your mission!");
            }
            else
            {
                Console.WriteLine("Death before dismount!");
            }
        }

        public TrackedVehicle() : base()
        {
            
        }

        public TrackedVehicle(string trackedVicType, string trackedVicFunction, string trackedVicName, bool personnelCarrier, int personnelCapacity) : base(trackedVicType, trackedVicFunction, trackedVicName)
        {
            this.trackedVicType = trackedVicType;
            this.trackedVicName = trackedVicName;
            this.trackedVicFunction = trackedVicFunction;
            this.personnelCarrier = personnelCarrier;
            this.personnelCapacity = personnelCapacity;
        }
    }
}
