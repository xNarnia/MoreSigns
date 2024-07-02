using MoreSigns.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace MoreSigns.Items
{
    public class WoodSignMultiStyleItem : ModItem
    {

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<WoodSignMultiStyle>(), 0);
            Item.width = 26;
            Item.height = 22;
            Item.value = 50;
            Item.placeStyle = 1;
        }
    }
}
