using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Weapons
{
    public class MaglyneRevolver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Upgraded Revolver"
                + "\nChanges normal bullets to Chlorophyte Bullets");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 6;
            item.value = 1000000;
            item.rare = 8;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 20);
            recipe.AddIngredient(ItemID.Revolver);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.ChlorophyteBullet;
            }
            return true;

        }

    }
}