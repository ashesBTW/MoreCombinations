using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreCombinations.Projectiles
{
    public class FetidBlade : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.Size = new Vector2(8);
            projectile.aiStyle = 1;

            projectile.friendly = true;
            projectile.ranged = true;

            projectile.penetrate = 10;
            projectile.timeLeft = 600;
            projectile.usesLocalNPCImmunity = false;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;

            projectile.extraUpdates = 1;
            aiType = ProjectileID.ChlorophyteBullet;
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);

        }
    }
}