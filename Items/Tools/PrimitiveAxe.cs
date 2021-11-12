using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Tools
{
	public class PrimitiveAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Primitive Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			//Tooltip.SetDefault("It'll do for now");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			//item.crit = 1;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 21;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 2;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.axe = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddIngredient(ItemID.StoneBlock, 12);
			recipe.AddIngredient(ItemID.Rope, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}