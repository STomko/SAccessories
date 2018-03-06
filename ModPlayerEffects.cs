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
    class ModPlayerEffects : ModPlayer
    {
		
		public bool pulseEquipped = false;
		public bool upgradedPulseEquipped = false;
		public bool lcPulseEquipped = false;
		public bool qPulseEquipped = false;
		
		public bool sBlessingEquipped = false;
		public bool sBlessingActive = false;
		
		public bool mAdrenalineEquipped = false;
		public bool mAdrenalineActive = false;
		
		public bool vBlessingEquipped = false;
		
		public bool tFingerEquipped = false;
		public bool dHandEquipped = false;
		
		//Buffs
		public bool quickFireActive = false;
		public bool sQuickFireActive = false;
		
		public static int randGen(int max)
		{
			return Main.rand.Next(max);
		}
		
		public override void ResetEffects()
		{
			pulseEquipped = false;
			upgradedPulseEquipped = false;
			lcPulseEquipped = false;
			qPulseEquipped = false;
			mAdrenalineEquipped = false;
			mAdrenalineActive = false;
			sBlessingEquipped = false;
			sBlessingActive = false;
			vBlessingEquipped = false;
			tFingerEquipped = false;
			dHandEquipped = false;
			quickFireActive = false;
			sQuickFireActive = false;
		}
		
		public override void Hurt (bool pvp, bool quiet, double damage, int hitDirection, bool crit)
		{
			//Get the current player
			int currPlayer = player.whoAmI;
			
			//Pulse Shield
			if (pulseEquipped)
			{
				float projectilespeedX = 0f;
				float projectilespeedY = 0f;
				float projectileKnockback = 4f;
				int minDamage = 5;			
				int maxDamage = 15;			
				int projectileDamage = ModProjectileEffects.randDamage(minDamage, maxDamage);
				for (int i = 0; i <= 35; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("PulseP1"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 35) * i;
					Projectiles.PulseP1 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.PulseP1;
					tempProj.SetOrbit(angle);
				}
		
			}
			
			//Upgraded Pulse Shield
			if (upgradedPulseEquipped)
			{
				float projectilespeedX = 0f;
				float projectilespeedY = 0f;
				float projectileKnockback = 4f;
				int minDamage = 10;			
				int maxDamage = 25;			
				int projectileDamage = ModProjectileEffects.randDamage(minDamage, maxDamage);
				
				//First Ring (Centre)
				for (int i = 0; i <= 36; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("UPulseP1"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 36) * i;
					Projectiles.UPulseP1 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.UPulseP1;
					tempProj.SetOrbit(angle);
				}
				
				//Second Ring
				for (int i = 0; i <= 54; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("UPulseP2"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 54) * i;
					Projectiles.UPulseP2 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.UPulseP2;
					tempProj.SetOrbit(angle);
				}
				
				//Third Ring (Outer)
				for (int i = 0; i <= 72; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("UPulseP3"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 72) * i;
					Projectiles.UPulseP3 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.UPulseP3;
					tempProj.SetOrbit(angle);
				}
		
			}
		
			//Liquid Cooled Pulse Shield
			if (lcPulseEquipped)
			{
				float projectilespeedX = 0f;
				float projectilespeedY = 0f;
				float projectileKnockback = 4f;
				int minDamage = 20;			
				int maxDamage = 40;			
				int projectileDamage = ModProjectileEffects.randDamage(minDamage, maxDamage);
				
				//First Ring (Centre)
				for (int i = 0; i <= 36; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("LCPulseP1"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 36) * i;
					Projectiles.LCPulseP1 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.LCPulseP1;
					tempProj.SetOrbit(angle);
				}
				
				//Second Ring
				for (int i = 0; i <= 54; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("LCPulseP2"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 54) * i;
					Projectiles.LCPulseP2 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.LCPulseP2;
					tempProj.SetOrbit(angle);
				}
				
				//Third Ring (Outer)
				for (int i = 0; i <= 72; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("LCPulseP3"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 72) * i;
					Projectiles.LCPulseP3 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.LCPulseP3;
					tempProj.SetOrbit(angle);
				}
			}
			
			//Quantum Pulse Shield
			if (qPulseEquipped)
			{
				float projectilespeedX = 0f;
				float projectilespeedY = 0f;
				float projectileKnockback = 4f;
				int minDamage = 35;			
				int maxDamage = 55;			
				int projectileDamage = ModProjectileEffects.randDamage(minDamage, maxDamage);
				
				//First Ring (Centre)
				for (int i = 0; i <= 36; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("QPulseP1"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 36) * i;
					Projectiles.QPulseP1 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.QPulseP1;
					tempProj.SetOrbit(angle);
				}
				
				//Second Ring
				for (int i = 0; i <= 54; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("QPulseP2"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 54) * i;
					Projectiles.QPulseP2 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.QPulseP2;
					tempProj.SetOrbit(angle);
				}
				
				//Third Ring
				for (int i = 0; i <= 72; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("QPulseP3"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 72) * i;
					Projectiles.QPulseP3 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.QPulseP3;
					tempProj.SetOrbit(angle);
				}
				
				//Fourth Ring (Outer)
				for (int i = 0; i <= 90; i++)
				{			
					int projIndex = Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("QPulseP4"), projectileDamage, projectileKnockback, currPlayer, 0f, 0f);
					float angle = (360 / 90) * i;
					Projectiles.QPulseP4 tempProj = Main.projectile[projIndex].modProjectile as Projectiles.QPulseP4;
					tempProj.SetOrbit(angle);
				}
			}
		
			//Micro Adrenaline
			if (mAdrenalineEquipped)
			{
				int quarterLife = player.statLifeMax2 / 4;
				if (player.statLife <= quarterLife && !mAdrenalineActive)
				{
					mAdrenalineActive = true;
					player.minionDamage *= 2.0f;
				}
			}
			
			//Summoners Blessing
			if (sBlessingEquipped)
			{
				int quarterLife = player.statLifeMax2 / 4;
				if (player.statLife <= quarterLife)
				{
					sBlessingActive = true;
					player.minionDamage *= 2.0f;
				}
			}
			
			//Dead Hand
			if (dHandEquipped)
			{
				player.AddBuff(mod.BuffType("SuperQuickFire"), 400, false);
			}
			
		}

		public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
		{
			//Vampiric Blessing	- Melee		
			if (vBlessingEquipped)
			{
				int vampChance = 8;
				if (randGen(vampChance) == 5)
				{
					int healthGain = damage / 2;
					player.statLife+= healthGain;
				}
			}
		}	

		public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
		{
			//Vampiric Blessing	- Projectile	
			if (vBlessingEquipped)
			{
				int vampChance = 8;
				if (randGen(vampChance) == 5)
				{
					int healthGain = damage / 2;
					player.statLife+= healthGain;
				}
			}
		}		
		
		public override void PostUpdate()
		{
			int quarterLife = player.statLifeMax2 / 4;
			if (mAdrenalineActive && player.statLife > quarterLife)
			{
				mAdrenalineActive = false;
				player.minionDamage = 1.0f;
			}
			
			if (sBlessingActive && player.statLife > quarterLife)
			{
				sBlessingActive = false;
				player.minionDamage = 1.0f;
			}
			
		}
		
		//Fire rate
		public override float UseTimeMultiplier(Item item)
		{
			//Trigger Finger
			if (quickFireActive)
			{
				return 1.25f;
			}
			
			if (dHandEquipped)
			{
				if (sQuickFireActive)
				{
					return 1.75f;
				}
				return 1.25f;
			}
			return 1.0f;			
		}

    }
}