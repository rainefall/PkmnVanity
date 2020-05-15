using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity
{
    public class PokemonPlayer : ModPlayer
    {
        public bool fennekinPet = false;

        public override void ResetEffects()
        {
            fennekinPet = false;
        }
    }
}