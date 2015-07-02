using System.Collections.Generic;
using System.Text;

namespace GildedRoseDataBinding.Model
{
    public class Food : Article
    {
        public List<string> Ingredients { get; set; }

        public Food(IUpdateArticleStrategy updateArticleStrategy)
            : base(updateArticleStrategy)
        {
            
        }

        protected override void AddSpecificArticleInfo(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Ingredients:");
            foreach (var zutat in Ingredients)
            {
                stringBuilder.AppendLine(string.Format("  {0}", zutat));
            }
        }
    }
}
