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
	public class StardustSign : BaseShinySign<StardustSignItem>
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileLighted[Type] = true;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 35f / 255f / 2f;
			g = 200f / 255f / 2f;
			b = 254f / 255f / 2f;
		}
	}
}
