using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class UpgradedPulseShield : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Upgraded Pulse Shield");
			Tooltip.SetDefault("Releases three pulses of energy that damages enemies when the player takes damage.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().upgradedPulseEquipped = true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(null, "PulseShield", 3);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
