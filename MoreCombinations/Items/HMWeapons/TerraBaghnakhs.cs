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
    public class TerraBaghnakhs : ModItem

    {
     

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 150;
            item.knockBack = 1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 5;
            item.useAnimation = 5;
            item.autoReuse = true;
            item.shootSpeed = 25;
            item.shoot = ProjectileID.TerraBeam;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item101;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TerraBlade);
            recipe.AddIngredient(ItemID.FetidBaghnakhs);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
