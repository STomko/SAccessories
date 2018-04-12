using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class RangerToken10Luminite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Ranger Token");
			Tooltip.SetDefault("5x Critical-hit chance. 25% increased ranged damage and fire-rate. Ranged attacks have a 1/4 chance of granting the Shadowflame, On-Fire! and/or the Midas debuffs.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().rangerLuminiteEquipped = true;
			player.rangedDamage += 0.25f;
			player.rangedCrit *= 5;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(null, "RangerToken7Hallowed", 1);
			recipe.AddIngredient(null, "RangerToken8Adamantite", 1);
			recipe.AddIngredient(null, "RangerToken9Chlorophyte", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
