using System;

namespace GildedRoseDataBinding.Model
{
    public class StandardStrategy : IUpdateArticleStrategy
    {
        public void UpdateArticle(Article article)
        {
            if (article == null) throw new ArgumentNullException("article");

            article.Durability--;
            if (article.Durability <= 0)
                article.Quality -= 2;
            else
                article.Quality--;
        }
    }
}