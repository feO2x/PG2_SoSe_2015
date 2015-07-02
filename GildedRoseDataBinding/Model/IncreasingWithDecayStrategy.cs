using System;

namespace GildedRoseDataBinding.Model
{
    public class IncreasingWithDecayStrategy : IUpdateArticleStrategy
    {
        public void UpdateArticle(Article article)
        {
            if (article == null) throw new ArgumentNullException("article");

            article.Durability--;

            if (article.Durability <= 0)
            {
                article.Quality = 0;
                return;
            }

            if (article.Durability <= 5)
            {
                article.Quality += 3;
                return;
            }
            if (article.Durability <= 10)
            {
                article.Quality += 2;
                return;
            }

            article.Quality--;
        }
    }
}