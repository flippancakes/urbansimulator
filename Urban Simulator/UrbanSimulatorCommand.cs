using System;
using System.Collections.Generic;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;

namespace Urban_Simulator
{
    [System.Runtime.InteropServices.Guid("777ad6e6-81c3-406d-9ba0-746fbb18b737")]
    public class UrbanSimulatorCommand : Command
    {
        public UrbanSimulatorCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static UrbanSimulatorCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "UrbanSimulator"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {

            RhinoApp.WriteLine("The Urban Simulator has begun.");

            //getPrecint()                  //Ask user to select a surface representing the Precinct
            //generateRoadNetwork()         //Using the precinct, Generate a Road Network
            //createBlocks()                //Using the road network, create blocks
            //subdivideBlocks()             //Subdivide the blocks in Plots
            //initiateBuildings()           //Place buildings on each plot

            RhinoApp.WriteLine("The Urban Simulator in complete.");

            return Result.Success;
        }
    }
}
