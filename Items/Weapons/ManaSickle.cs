using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Weapons
{
    public class ManaSickle : ModItem
    {
        public override void SetStaticDefaults()
        {

            Tooltip.SetDefault("Death Sickle infused with mana stars.");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {

            item.shoot = 503;
            item.shootSpeed = 10f;
            item.damage = 227;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 60;            //Weapon's texture's width
            item.height = 56;           //Weapon's texture's height
            item.useTime = 30;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 30;        //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 8;         //The force of knockback of the weapon. Maximum is 20
            item.rare = 9;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ManaSickleProj");

        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1327, 1);
            recipe.AddIngredient(ItemID.StarWrath, 10);
            recipe.AddIngredient(ItemID.Amethyst, 5);
            recipe.AddTile(null, "ManaInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 3; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-1, 1);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;


        }
    }

}
