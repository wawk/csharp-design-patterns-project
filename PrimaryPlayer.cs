using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_design_patterns_project
{
    // Example of a Singleton Pattern
    // * Class sealed against inheritance
    // * Private constructor
    // * Readonly instance variable
    // * Static instance variable
    // * instance initialized in static constructor
    public sealed class PrimaryPlayer
    {   private static readonly PrimaryPlayer _instance;

        private PrimaryPlayer() {}

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1
            };
        }
        public static PrimaryPlayer Instance
    {
        get
        {
            return _instance;
        }
    }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
