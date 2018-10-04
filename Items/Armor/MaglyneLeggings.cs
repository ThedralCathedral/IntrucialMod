using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Intrucial.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class MaglyneLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Green again? Also a free speed boost?"
                + "\n10% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 10000000;
            item.rare = 6;
            item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}