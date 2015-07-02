using System;

namespace GildedRoseDataBinding.Model
{
    public class IncreasingStrategy : IUpdateArticleStrategy
    {
        public void UpdateArticle(Article article)
        {
            if (article == null) throw new ArgumentNullException("article");

            article.Durability--;

            if (article.Durability <= 0)
            {
                article.Quality -= 2;
                return;
            }

            if (article.Quality + 1 <= 50)
                article.Quality++;
        }
    }
}