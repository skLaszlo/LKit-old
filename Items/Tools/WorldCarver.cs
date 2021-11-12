using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Tools
{
	public class WorldCarver : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("World Carver"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Looking back at it, the Eater of Worlds was a huge softie.");
		}

		public override void SetDefaults() 
		{
			item.damage = 77;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 200000;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.pick = 175;
			item.axe = 34;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 30);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 15);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.Ebonwood, 6);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}