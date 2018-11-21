using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SObject = StardewValley.Object;

namespace ToolGeodes
{
    public class Configuration
    {
        public SButton AdornKey = SButton.G;

        // Universal
        public int GEODE_MORE_SLOTS = SObject.prismaticShardIndex;
        //578; // Star shards - what to do with these?

        // Tools
        public int GEODE_LENGTH = 564; // Opal
        public int GEODE_WIDTH = 565; // Fire opal
        public int GEODE_INFINITE_WATER = 560; // Ocean stone
        public int GEODE_OBJ_TRUESIGHT = 562; // Tigerseye
        public int GEODE_LESS_STAMINA = 541; // Aerinite
        public int GEODE_INSTANT_CHARGE = 577; // Fairy stone

        // Weapons
        //public int GEODE_MOB_FREEZE = 561; // Ghost crystal
        public int GEODE_MORE_DAMAGE = 558; // Thunder egg
    }
}
