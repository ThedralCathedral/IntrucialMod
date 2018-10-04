using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Mining
{
    public class MaglynePickaxe_Axe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Maglyne Pickaxe Axe");
            Tooltip.SetDefault("Maglyne Pickaxe Axe... to not waste any space...");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 32;
            item.height = 38;
            item.useTime = 15;
            item.useAnimation = 15;
            item.axe = 70;
            item.pick = 110;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 1000000;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglynePickaxe", 1);
            recipe.AddIngredient(null, "MaglyneAxe", 1);
            recipe.AddIngredient(null, "MaglyneBar", 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
