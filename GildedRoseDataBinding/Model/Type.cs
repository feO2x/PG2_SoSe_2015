namespace GildedRoseDataBinding.Model
{
    public static class Type
    {
        public static readonly IUpdateArticleStrategy Legendary = new LegendaryStrategy();
        public static readonly IUpdateArticleStrategy Standard = new StandardStrategy();
        public static readonly IUpdateArticleStrategy Increasing = new IncreasingStrategy();
        public static readonly IUpdateArticleStrategy Enchanted = new EnchantedStrategy();
        public static readonly IUpdateArticleStrategy IncreasingWithDecay = new IncreasingWithDecayStrategy();
    }
}