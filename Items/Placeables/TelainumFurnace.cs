using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Intrucial.Recipes;

namespace Intrucial.Items.Placeables
{
    public class TelainumFurnace : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Allows alloying of different Bars.");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 32;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 1500000;
            item.createTile = mod.TileType("TelainumFurnaceTile");
            item.expert = true;
        }

        public override void AddRecipes()
        {
            IntrucialRecipe recipe = new IntrucialRecipe(mod, () => Main.LocalPlayer.GetModPlayer<IntrucialPlayer>().HiddenRecipesAvailable);
            recipe.AddIngredient(ItemID.Furnace);
            recipe.AddIngredient(null, "TelainumBar", 30);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}