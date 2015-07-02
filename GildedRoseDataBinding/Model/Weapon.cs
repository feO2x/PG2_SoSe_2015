using System.Text;

namespace GildedRoseDataBinding.Model
{
    public class Weapon : Article
    {
        public DamageType DamageType { get; set; }
        public HiltType HiltType { get; set; }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(IUpdateArticleStrategy strategie)
            : base(strategie)
        {
            ArticleGroup = "Weapons";
        }

        protected override void AddSpecificArticleInfo(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Damage type: " + DamageType);
            stringBuilder.AppendLine(string.Format("Damage: {0} - {1}", MinimumDamage, MaximumDamage));
            stringBuilder.AppendLine("Hilt type: " + HiltType);
        }
    }
}