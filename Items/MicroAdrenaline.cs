using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class MicroAdrenaline : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Micro Adrenaline");
			Tooltip.SetDefault("When the player is below 25% health, all minions have increased damage as the player takes damage.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().mAdrenalineEquipped = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vitamins, 1);
			recipe.AddIngredient(ItemID.BottledHoney, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
