using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Mining
{
    public class MaglyneAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Maglyne Axe... What else should i say?");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.width = 32;
            item.height = 28;
            item.useTime = 20;
            item.useAnimation = 20;
            item.axe = 70;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 100000;
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 25);
            recipe.AddIngredient(ItemID.Amethyst);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        
    }
}
