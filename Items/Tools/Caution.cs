using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Tools
{
	public class Caution : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Caution!"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("WATCH WHERE YOU'RE GOING!");
		}

		public override void SetDefaults() 
		{
			item.damage = 11;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 100000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.axe = 11;
			item.hammer = 55;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldAxe);
			recipe.AddIngredient(ItemID.GoldHammer);
			recipe.AddIngredient(ItemID.Wood, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}