using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Placeables
{
    public class ManaInfuser : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fuses Mana items with regular items.");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 48;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 1500;
            item.createTile = mod.TileType("ManaInfuser");
            item.expert = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceMachine, 1);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}