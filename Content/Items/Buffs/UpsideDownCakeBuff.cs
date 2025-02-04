using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CakeMod.Content.Items.Buffs
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class UpsideDownCakeBuff : ModBuff
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TutorialMod.hjson' file.
		public override void SetStaticDefaults()
		{
            
			//DisplayName.SetDefault("Gravity Buff")
			Main.buffNoTimeDisplay[Type]=false;
			Main.debuff[Type] = false;
            BuffID.Sets.IsWellFed[Type] = true;
		}

        public override void Update(Player player, ref int buffIndex)
        {
			player.AddBuff(18,14400);
			//player.AddBuff(2,14400);
        }
    }
}