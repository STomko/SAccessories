using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace SAccessories
{
    class ModProjectileEffects : ModProjectile
    {
		float projectileAngleDegrees = 0.0f;
		
		static int[] debuffIDs = new int[] {20, 23, 24, 30, 31, 32, 33, 35, 37, 39, 44, 47, 63, 67, 69, 72};
		
		public static int randDamage(int min, int max)
		{
			return Main.rand.Next(min, max);
		}
		
		public static int randDebuff()
		{
			int returnVal = 0;
			int buffChance = Main.rand.Next(10);
			if (buffChance == 5)
			{
				returnVal = Main.rand.Next(debuffIDs.Length);
			}
			return returnVal;
		}
		
		public static int randDebuffQuantum()
		{
			int returnVal = 0;
			int buffChance = Main.rand.Next(10);
			if (buffChance%2 == 0)
			{
				returnVal = Main.rand.Next(debuffIDs.Length);
			}
			return returnVal;
		}
		
		public void SetOrbit(float degrees)
		{
			projectileAngleDegrees = degrees;
		}
		
		public float GetOrbit()
		{
			return projectileAngleDegrees;
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Player player = Main.player[projectile.owner];
			if (player.GetModPlayer<ModPlayerEffects>().lcPulseEquipped)
			{
				int debuff = ModProjectileEffects.randDebuff();
				if (debuff != 0)
				{
					target.AddBuff(debuff, 300);
				}
			}
			
			if (player.GetModPlayer<ModPlayerEffects>().qPulseEquipped)
			{
				int debuff = ModProjectileEffects.randDebuffQuantum();
				if (debuff != 0)
				{
					target.AddBuff(debuff, 300);
				}
			}
		}
		
	}

}