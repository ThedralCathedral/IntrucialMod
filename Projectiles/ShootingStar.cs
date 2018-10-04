using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Intrucial.Projectiles
{
    class ShootingStar : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.FallingStar);
            aiType = ProjectileID.Bullet;
        }

        public override string Texture
        {
            get
            {
                return "Terraria/Projectile_12";
            }
        }

    }
}