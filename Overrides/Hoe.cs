﻿using Microsoft.Xna.Framework;
using Netcode;
using StardewValley;
using StardewValley.Locations;
using StardewValley.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolGeodes.Overrides
{
    public class HoeAccessor
    {
        public static List<Vector2> tilesAffected(Hoe wcan, Vector2 loc, int power, Farmer who)
        {
            return Mod.instance.Helper.Reflection.GetMethod(wcan, "tilesAffected").Invoke<List<Vector2>>(loc, power, who);
        }
    }

    public static class HoeStaminaHook
    {
        public static void Prefix(Hoe __instance, GameLocation location, int x, int y, int power, Farmer who)
        {
            who.Stamina += Math.Min(who.HasAdornment(ToolType.Hoe, Mod.Config.GEODE_LESS_STAMINA), 4) * 0.25f;
        }
    }
}
