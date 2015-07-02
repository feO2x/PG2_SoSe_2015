namespace GildedRoseDataBinding.Model
{
    public class EnchantedStrategy : IUpdateArticleStrategy
    {
        public void UpdateArticle(Article article)
        {
            article.Durability--;

            var wertFürQualität = article.Durability <= 0 ? 4 : 2;
            article.Quality -= wertFürQualität;
        }
    }
}