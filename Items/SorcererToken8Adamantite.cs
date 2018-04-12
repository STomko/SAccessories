using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SorcererToken8Adamantite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Sorcerer Token");
			Tooltip.SetDefault("20% increased magic damage. 20% reduced mana cost.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.manaCost -= 0.2f;
			player.magicDamage += 0.2f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 25);
			recipe.AddIngredient(null, "SorcererToken1Copper", 1);
			recipe.AddIngredient(null, "SorcererToken2Silver", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
