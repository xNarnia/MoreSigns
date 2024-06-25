using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreSigns.Tiles
{
	public abstract class BaseShinySign<T> : BaseSign<T> where T : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Main.tileShine[Type] = 575;
			DustType = 84;
			HitSound = SoundID.Tink;
		}
	}
}
