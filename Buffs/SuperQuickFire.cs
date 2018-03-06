using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Buffs
{
	public class SuperQuickFire : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Super Quick Fire");
			Description.SetDefault("Fire rate massively increased");
			Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<ModPlayerEffects>().sQuickFireActive = true;
		}
	}
}
