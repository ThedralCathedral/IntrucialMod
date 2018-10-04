using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Mining
{
    public class FallenStarPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fallen Star Pickaxe");
            Tooltip.SetDefault("Pickaxe made from stars that have fallen from the sky...");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 30;
            item.pick = 55;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FallenStarIngot", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}