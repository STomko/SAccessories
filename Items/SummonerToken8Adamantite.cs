using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SummonerToken8Adamantite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Summoner Token");
			Tooltip.SetDefault("20% increased summon damage. 2 additional minion slots.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxMinions += 2;
			player.minionDamage += 0.2f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 25);
			recipe.AddIngredient(null, "SummonerToken1Copper", 1);
			recipe.AddIngredient(null, "SummonerToken2Silver", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
