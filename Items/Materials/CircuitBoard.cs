using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LKit.Items.Materials
{
	public class CircuitBoard : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.material = true;
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(0, 0, 16, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 5);
			recipe.AddIngredient(ItemID.CopperBar, 2);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}