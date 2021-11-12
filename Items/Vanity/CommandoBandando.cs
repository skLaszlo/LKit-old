using Terraria.ID;
using Terraria.ModLoader;

namespace LKit.Items.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class CommandoBandando : ModItem
    {
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
            item.width = 22;
            item.height = 18;
            item.maxStack = 1;
            item.value = 100000;
        }

        public override void AddRecipes()
        {
            //ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddRecipeGroup("Dirt", 1);
            //recipe.AddTile(TileID.WorkBenches);
            //recipe.SetResult(this);
            //recipe.AddRecipe();
        }
    }
}