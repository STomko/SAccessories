using Terraria.ModLoader;

namespace SAccessories
{
	class SAccessories : Mod
	{
		public SAccessories()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
