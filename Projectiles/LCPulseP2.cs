using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Projectiles
{

    public class UPulseP2 : ModProjectile
    {
		
		float projectileAngleDegrees = 0.0f;
		float orbitRadius = 100.0f;
		float orbitSpeed = 5.0f;
		
		public void SetOrbit(float degrees)
		{
			projectileAngleDegrees = degrees;
		}
		
		public float GetOrbit()
		{
			return projectileAngleDegrees;
		}
		
        public override void SetDefaults()
        {
            projectile.width = 5;     
            projectile.height = 5;
            projectile.friendly = true;    
            projectile.melee = true;        
            projectile.tileCollide = true; 
            projectile.penetrate = 30;    
            projectile.timeLeft = 500; 
            projectile.light = 0.75f;  
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true; 
        }
        public override void AI()         
        {                         
			Player player = Main.player[(int)projectile.localAI[0]];
			projectile.alpha = 128;
			//float projectileAngleDegrees = projectile.GetModProjectile<ModProjectileEffects>().GetOrbit();
			
			float angle = projectileAngleDegrees * (float)(Math.PI / 180); // We need to convert degrees to radians for this to work.
			Vector2 playerPosition = Main.player[projectile.owner].position;

			projectile.position.X = playerPosition.X + ((float)Math.Cos(angle) * orbitRadius) - projectile.width / 2;
			projectile.position.Y = playerPosition.Y + ((float)Math.Sin(angle) * orbitRadius)  - projectile.height / 2;

			projectileAngleDegrees += orbitSpeed; // Moves the projectile across its orbit.
			projectileAngleDegrees %= 360; // To prevent projectileAngleDegrees from eventually overflowing.
        }
    }
}