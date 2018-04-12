using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class WarriorToken7Hallowed	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Warrior Token");
			Tooltip.SetDefault("4x Critical-hit chance. Melee attacks have a 1/5 chance of granting the Midas debuff.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().warriorHallowedEquipped = true;
			player.meleeCrit *= 4;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(null, "WarriorToken3Gold", 1);
			recipe.AddIngredient(null, "WarriorToken4Meteorite", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
