using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class PulseShield : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pulse Shield");
			Tooltip.SetDefault("Release a pulse of energy that damages enemies when the player takes damage.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().pulseEquipped = true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltShield, 1);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.MechanicalLens, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
