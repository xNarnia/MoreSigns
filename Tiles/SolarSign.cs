using Microsoft.Xna.Framework;
using MoreSigns.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace MoreSigns.Tiles
{
	public class SolarSign : BaseShinySign<SolarSignItem>
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileLighted[Type] = true;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 249f / 255f / 2f;
			g = 109f / 255f / 2f;
			b = 7f / 255f / 2f;
		}
	}
}
