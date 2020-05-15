using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity
{
	public class PokemonVanity : Mod
	{

        public PokemonVanity()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public void SetModInfo(out string name, ref ModProperties properties)
        {
            name = "Pokémon Vanity Mod";
        }
    }
}