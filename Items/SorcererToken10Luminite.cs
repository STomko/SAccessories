using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SAccessories.Items
{
	public class SorcererToken10Luminite	: ModItem
	{

        public override void SetDefaults()
		{
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Sorcerer Token");
			Tooltip.SetDefault("5x Critical-hit chance. 25% increased magic damage. 25% decreased mana cost. Magic attacks have a 1/4 chance of granting the Shadowflame, On-Fire! and/or the Midas debuffs.");
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ModPlayerEffects>().sorcererLuminiteEquipped = true;
			player.manaCost -= 0.25f;
			player.magicDamage += 0.25f;
			player.magicCrit *= 5;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(null, "SorcererToken7Hallowed", 1);
			recipe.AddIngredient(null, "SorcererToken8Adamantite", 1);
			recipe.AddIngredient(null, "SorcererToken9Chlorophyte", 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
