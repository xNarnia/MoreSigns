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
	public class DemoniteSign : BaseShinySign<DemoniteSignItem>
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileLighted[Type] = true;
			DustType = DustID.Demonite;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f / 2;
			g = 0;
			b = 0.5f / 2;
		}
	}
}
