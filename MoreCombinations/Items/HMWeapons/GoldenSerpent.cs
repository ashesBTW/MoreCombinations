using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MoreCombinations.Items.HMWeapons
{
    public class GoldenSerpent : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.staff[item.type] = true;
        }


        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 10;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.autoReuse = true;
            item.shootSpeed = 20;
            item.mana = 10;
            item.noMelee = true;
            item.shoot = ProjectileID.IchorDart;
            item.rare = ItemRarityID.LightRed;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ichor, 5);
            recipe.AddIngredient(ItemID.CrystalSerpent);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }



    }
}
