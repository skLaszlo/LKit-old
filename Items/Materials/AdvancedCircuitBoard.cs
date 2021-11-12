using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LKit.Items.Materials
{
	public class AdvancedCircuitBoard : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Precision milled! Beep boop.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.material = true;
			item.rare = ItemRarityID.LightRed;
			item.value = Item.sellPrice(0, 0, 60, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 4);
			recipe.AddIngredient(ModContent.GetInstance<Items.Materials.CircuitBoard>(), 2);
			recipe.AddIngredient(ModContent.GetInstance<Items.Materials.WireClump>());
			recipe.AddIngredient(ItemID.SoulofNight);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}