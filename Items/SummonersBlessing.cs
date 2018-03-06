using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SummonersBlessing : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summoner's Blessing");
			Tooltip.SetDefault("When the player is below 25% health, all minions have increased damage as the player takes damage. Increases minion capacity by 10.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxMinions += 10;
			player.GetModPlayer<ModPlayerEffects>().sBlessingEquipped = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BewitchedSummoningCharm", 1);
			recipe.AddIngredient(null, "MicroAdrenaline", 1);
			recipe.AddIngredient(ItemID.OpticStaff, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
