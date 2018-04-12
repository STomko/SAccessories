using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SummonerToken10Luminite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Summoner Token");
			Tooltip.SetDefault("3 additional minion slots. 25% increased summon damage and knockback. Summon attacks have a 1/4 chance of granting the Shadowflame, On-Fire! and/or the Midas debuffs.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().summonerLuminiteEquipped = true;
			player.maxMinions += 3;
			player.minionDamage += 0.25f;
			player.minionKB += 0.25f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(null, "SummonerToken7Hallowed", 1);
			recipe.AddIngredient(null, "SummonerToken8Adamantite", 1);
			recipe.AddIngredient(null, "SummonerToken9Chlorophyte", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
