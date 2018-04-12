using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SummonerToken7Hallowed	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Summoner Token");
			Tooltip.SetDefault("20% increased minion knockback. Summon attacks have a 1/5 chance of granting the Midas debuff.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().summonerHallowedEquipped = true;
			player.minionKB += 0.2f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(null, "SummonerToken3Gold", 1);
			recipe.AddIngredient(null, "SummonerToken4Meteorite", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
