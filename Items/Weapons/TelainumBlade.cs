using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Items.Weapons
{
    public class TelainumBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It seems that Telainum only accepted Breaker Blade as its host");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 450;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 70;            //Weapon's texture's width
            item.height = 80;           //Weapon's texture's height
            item.useTime = 10;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 10;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 11;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(platinum: 100);           //The value of the weapon
            item.rare = 11;
            item.expert = true;
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TelainumBar", 50);
            recipe.AddIngredient(ItemID.BreakerBlade);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Bleeding, 120);
            target.AddBuff(BuffID.Poisoned, 120);
            target.AddBuff(BuffID.Cursed, 120);
            target.AddBuff(BuffID.OnFire, 120);
        }


    }
}
