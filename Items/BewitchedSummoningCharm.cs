using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class BewitchedSummoningCharm : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bewitched Summoning Charm");
			Tooltip.SetDefault("Increases minion capacity by 10.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.maxMinions += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(null, "SummoningCharm", 5);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();	
		}
	}
}
