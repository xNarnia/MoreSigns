using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MoreSigns.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using ReLogic.Content;
using Terraria.GameContent;

namespace MoreSigns.Tiles
{
	public class MartianHoloSign : BaseShinySign<MartianHoloSignItem>
	{
		private Asset<Texture2D> glowTexture;

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			glowTexture = ModContent.Request<Texture2D>(Texture + "_GlowMask");
			Main.tileLighted[Type] = true;
		}

		public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
		{
			Tile tile = Main.tile[i, j];
			Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);

			int frameX = tile.TileFrameX % 36;
			int frameY = tile.TileFrameY % 54;

			frameX += (tile.TileFrameX / 36) * 36;

			spriteBatch.Draw(
				TextureAssets.Tile[Type].Value,
				new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
				new Rectangle(frameX, frameY, 16, 16),
				Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);

			// Draw glowmask
			spriteBatch.Draw(
				glowTexture.Value,
				new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
				new Rectangle(frameX, frameY, 16, 16),
				Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

			return false;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 203f / 255f / 2f;
			g = 245f / 255f / 2f;
			b = 247f / 255f / 2f;
		}
	}
}
