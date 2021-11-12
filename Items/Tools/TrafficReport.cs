using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Tools
{
	public class TrafficReport : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Traffic Report"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("'Expect minor delays today. Someone has ripped a traffic sign out of the ground and is flailing it around wildly.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 98;
			item.melee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 100000;
			//item.shoot = 430;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.axe = 22;
			item.hammer = 90;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.GetInstance<Items.Tools.Caution>());
			recipe.AddIngredient(ItemID.Pwnhammer);
			recipe.AddIngredient(ItemID.HallowedBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}