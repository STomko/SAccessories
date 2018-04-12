using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SorcererToken7Hallowed	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Sorcerer Token");
			Tooltip.SetDefault("4x Critical-hit chance. Magic attacks have a 1/5 chance of granting the Midas debuff.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().sorcererHallowedEquipped = true;
			player.magicCrit *= 4;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(null, "SorcererToken3Gold", 1);
			recipe.AddIngredient(null, "SorcererToken4Meteorite", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
