using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Mining
{
    public class MaglynePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Maglyne Pickaxe, Very shiny also green.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.pick = 110;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000000;
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        
    }
}