using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SummoningCharm : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summoning Charm");
			Tooltip.SetDefault("Increases minion capacity by 2.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.maxMinions += 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();		
		}
	}
}
