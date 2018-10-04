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
    class SwordBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SwordBeam);
            aiType = ProjectileID.SwordBeam;
            projectile.timeLeft = 200;
        }

    }
}