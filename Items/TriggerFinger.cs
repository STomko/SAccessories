using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class TriggerFinger : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Trigger Finger");
			Tooltip.SetDefault("When the player takes damage, increase fire rate of bows and firearms for a short time.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().tFingerEquipped = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();	
		}
	}
}
