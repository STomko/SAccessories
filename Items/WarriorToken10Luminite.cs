using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class WarriorToken10Luminite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Warrior Token");
			Tooltip.SetDefault("5x Critical-hit chance. 25% increased melee speed and damage. Melee attacks have a 1/4 chance of granting the Shadowflame, On-Fire! and/or the Midas debuffs.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().warriorLuminiteEquipped = true;
			player.meleeSpeed += 0.25f;
			player.meleeDamage += 0.25f;
			player.meleeCrit *= 5;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(null, "WarriorToken7Hallowed", 1);
			recipe.AddIngredient(null, "WarriorToken8Adamantite", 1);
			recipe.AddIngredient(null, "WarriorToken9Chlorophyte", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
