using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class VampiricBlessing : ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vampiric Blessing");
			Tooltip.SetDefault("Damage dealt to enemies has a chance of healing the player for 50% of damage dealt.");
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().vBlessingEquipped = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoonStone, 1);
			recipe.AddIngredient(ItemID.GreaterHealingPotion, 5);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();	
		}
	}
}
