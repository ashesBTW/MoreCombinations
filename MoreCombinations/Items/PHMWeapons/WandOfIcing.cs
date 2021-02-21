using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MoreCombinations.Items.PHMWeapons
{
    public class WandOfIcing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wand of Icing");
            Tooltip.SetDefault("'Frosty'");

        }

        public override void SetDefaults()
        {
            item.magic = true;
            item.damage = 20;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 20;
            item.useAnimation = 20;
            item.autoReuse = false;
            item.shootSpeed = 15f;
            item.mana = 5;
            item.noMelee = true;
            item.shoot = ProjectileID.IceBolt;
            item.rare = ItemRarityID.Green;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.IceBlock, 20);
            recipe.AddIngredient(ItemID.BorealWood, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }



    }
}
