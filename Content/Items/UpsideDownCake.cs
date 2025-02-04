using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CakeMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class UpsideDownCake : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TutorialMod.hjson' file.
		public override void SetDefaults()
		{
			//Item Animation and size
			Item.useAnimation = 20;
			Item.value = Item.buyPrice(silver: 10);
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.buffTime = 14400;
			Item.buffType = 2;
			Item.buffType = ModContent.BuffType<Buffs.UpsideDownCakeBuff>();
			//Item.potion = true;
			Item.value = 100;
			//Player.AddBuff(18,14400, true, true);
			//Item sound and type
			Item.UseSound = SoundID.Item3;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.maxStack = 10;
			
		}
		
		
		public override void AddRecipes()
		{
			Recipe craftRecipe = CreateRecipe();
			craftRecipe.AddIngredient(ItemID.Sunflower, 2);
            craftRecipe.AddIngredient(ItemID.Lemon, 2);
            craftRecipe.AddIngredient(ItemID.GravitationPotion, 1);
			craftRecipe.AddTile(TileID.WorkBenches);
			craftRecipe.Register();

			// Recipe shimmerResult = CreateRecipe();
			// shimmerResult.AddCustomShimmerResult(3750, 6);
			// shimmerResult.Register();

			// Recipe shimmerRecipe = CreateRecipe();
			// shimmerRecipe.AddCustomShimmerResult(UpsideDownCake, 1);
			// shimmerRecipe.Register();
		}
	}
}
