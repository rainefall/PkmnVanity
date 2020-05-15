using Terraria;
using Terraria.ModLoader;

namespace PokemonVanity.Buffs
{
    public class HypedForSunAndMoon : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Hyped for Sun and Moon";
            Main.buffTip[Type] = "You can't escape the hype.";
            Main.buffNoTimeDisplay[Type] = true;
        }
    }
}