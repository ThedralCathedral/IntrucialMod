using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Intrucial.Projectiles
{
    public class ManaSickleProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 52;               //The width of projectile hitbox
            projectile.height = 52;              //The height of projectile hitbox
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = false;           //Is the projectile shoot by a ranged weapon?
            projectile.penetrate = 5;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            projectile.timeLeft = 200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.alpha = 0;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
            projectile.light = 0.5f;            //How much light emit around the projectile
            projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = false;          //Can the projectile collide with tiles?
            projectile.extraUpdates = 4;            //Set to above 0 if you want the projectile to update multiple time in a frame
        }

    }
}