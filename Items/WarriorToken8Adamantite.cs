using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class WarriorToken8Adamantite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Warrior Token");
			Tooltip.SetDefault("20% increased melee speed and damage.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeSpeed += 0.2f;
			player.meleeDamage += 0.2f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 25);
			recipe.AddIngredient(null, "WarriorToken1Copper", 1);
			recipe.AddIngredient(null, "WarriorToken2Silver", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
