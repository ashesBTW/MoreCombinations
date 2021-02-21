using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreCombinations.Items.Materials
{
    public class HeatEssence : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = -12;
            item.maxStack = 999;
            ItemID.Sets.ItemNoGravity[item.type] = true;  //this make that the item will float in air
            
        }

     
      

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.OrangeRed;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }
}