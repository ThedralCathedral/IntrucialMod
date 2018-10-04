using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Weapons
{
    public class MaglyneSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Super Shiny, also very sharp.");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.shootSpeed = 10f;
            item.shoot = 503;
            item.damage = 65;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 46;            //Weapon's texture's width
            item.height = 48;           //Weapon's texture's height
            item.useTime = 30;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 30;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 8;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(gold: 10);           //The value of the weapon
            item.rare = 7;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.shoot = mod.ProjectileType("SwordBeam");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MaglyneBar", 10);
            recipe.AddIngredient(ItemID.Amethyst, 3);
            recipe.AddIngredient(ItemID.CobaltSword);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Bleeding, 120);
        }


    }
}
