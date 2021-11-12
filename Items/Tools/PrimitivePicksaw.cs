using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Tools
{
	public class PrimitivePicksaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Primitive Picksaw"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It'll do for now");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			//item.crit = 1;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 21;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 2;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.axe = 8;
			item.pick = 37;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Rope, 5);
			recipe.AddIngredient(ModContent.GetInstance<Items.Tools.PrimitiveAxe>());
			recipe.AddIngredient(ModContent.GetInstance<Items.Tools.PrimitivePickaxe>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}