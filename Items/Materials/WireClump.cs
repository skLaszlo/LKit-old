using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LKit.Items.Materials
{
	public class WireClump : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.material = true;
			item.rare = ItemRarityID.White;
			item.value = Item.sellPrice(0, 0, 0, 34);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}