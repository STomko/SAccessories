using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Buffs
{
	public class QuickFire : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Quick Fire");
			Description.SetDefault("Fire rate increased");
			Main.debuff[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<ModPlayerEffects>().quickFireActive = true;
		}
	}
}
