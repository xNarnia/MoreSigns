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
	public class VortexSign : BaseShinySign<VortexSignItem>
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileLighted[Type] = true;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 34f / 255f / 2f;
			g = 221f / 255f / 2f;
			b = 151f / 255f / 2f;
		}
	}
}
