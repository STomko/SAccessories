using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class WarriorToken3Gold	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Warrior Token");
			Tooltip.SetDefault("3x Critical-hit chance.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeCrit *= 3;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
