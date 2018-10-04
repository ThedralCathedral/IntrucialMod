using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items
{
    public class MaglyneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Maglyne Bar. Its green color looks very natural.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 99;
            item.value = 10000;
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddIngredient(null, "MaglyneOre", 4);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
