using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CakeMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Cake : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TutorialMod.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 50;
			//Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			//Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
			//Item.UseSound = SoundID.Item1;
			//Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Sunflower, 2);
            recipe.AddIngredient(ItemID.Lemon, 2);
            recipe.AddIngredient(ItemID.GravitationPotion, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
