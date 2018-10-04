using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Mining
{
    public class MaglyneHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Maglyne Hammer... duh.");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.hammer = 100;
            item.useStyle = 1;
            item.knockBack = 7;
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
