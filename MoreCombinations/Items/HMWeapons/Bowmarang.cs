
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace MoreCombinations.Items.HMWeapons
{
    public class Bowmarang : ModItem

    {
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 20;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime =5;
            item.useAnimation = 5;
            item.autoReuse = true;
            item.shootSpeed = 25;
            item.noMelee = true;
            item.shoot = AmmoID.Arrow;
            item.useAmmo = AmmoID.Arrow;
            item.rare = ItemRarityID.LightPurple;
            item.UseSound = SoundID.Item92;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Flamarang);
            recipe.AddIngredient(null, "HeatEssence", 120);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
