using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MoreCombinations.Items.HMWeapons
{
    public class TrueWoodenHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("op");

        }

        public override void SetDefaults()
        {
            item.thrown=false;
            item.magic=false;
            item.summon=false;
            item.melee = false;
            item.ranged=false;
            item.damage = 42069;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 1;
            item.useAnimation = 3;
            item.autoReuse = false;
            item.shootSpeed = 100000;
            item.shoot = ProjectileID.TerraBeam;
            item.rare = ItemRarityID.Expert;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenHammer);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }



    }
}
