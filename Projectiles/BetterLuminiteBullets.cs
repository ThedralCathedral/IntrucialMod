using Terraria.ModLoader;
using Terraria.ID;

namespace Intrucial.Projectiles
{
    class BetterLuminiteBullets : ModProjectile
    {
        public override void SetDefaults()
        {            
            aiType = ProjectileID.ChlorophyteBullet;
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.alpha = 255;
            projectile.extraUpdates = 5;
            projectile.timeLeft = 600;
            projectile.ranged = true;
            projectile.ignoreWater = true;
            projectile.usesLocalNPCImmunity = true;
            projectile.penetrate = 1;
        }

        public override string Texture
        {
            get
            {
                return "Terraria/Projectile_638";
            }
        }

    }
}