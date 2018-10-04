using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Weapons
{
    //ported from my tAPI mod because I'm lazy
    public class FallenStarBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fallen Star Bow");
            Tooltip.SetDefault("Turns Wooden Arrows into stars.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;
            item.width = 22;
            item.height = 40;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5f;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ShootingStar");
            item.shootSpeed = 6f;
            item.useAmmo = AmmoID.Arrow;        //Restrict the type of ammo the weapon can use, so that the weapon cannot use other ammos
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FallenStarIngot", 10);
            recipe.AddIngredient(ItemID.WoodenBow);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("ShootingStar"); // or ProjectileID.FireArrow;
            }
            return true;

        }
    }
}
