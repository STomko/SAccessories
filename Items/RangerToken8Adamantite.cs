using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class RangerToken8Adamantite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Ranger Token");
			Tooltip.SetDefault("20% increased ranged damage and fire-rate.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.2f;
			player.GetModPlayer<ModPlayerEffects>().rangerAdamantiteEquipped = true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 25);
			recipe.AddIngredient(null, "RangerToken1Copper", 1);
			recipe.AddIngredient(null, "RangerToken2Silver", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
