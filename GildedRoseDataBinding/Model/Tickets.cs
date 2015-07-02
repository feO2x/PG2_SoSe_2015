
namespace GildedRoseDataBinding.Model
{
    public class Tickets : Article
    {
        public Tickets(IUpdateArticleStrategy updateArticleStrategy) 
            : base(updateArticleStrategy)
        {
            ArticleGroup = "Other Stuff";
        }
    }
}
