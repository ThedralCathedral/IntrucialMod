using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items
{
    public class TelainumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Telainum Bar");
            Tooltip.SetDefault("Telainum Bar. There is something wrong with it..."
                            + "\nIt seems that the it doesnt want to be used for everything..."
                            + "\nVery Dense... What could this mean?");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 99;
            item.value = 100000;
            item.rare = 12;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddIngredient(null, "TelainumOre", 20);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
