using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class LCPulseShield : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Liquid-Cooled Pulse Shield");
			Tooltip.SetDefault("Releases three pulses of energy that damages enemies when the player takes damage. Pulses have a chance to grant debuffs.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().lcPulseEquipped = true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottomlessBucket, 1);
			recipe.AddIngredient(ItemID.InfernoPotion, 5);
			recipe.AddIngredient(null, "UpgradedPulseShield", 3);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
