using System;
using System.Text;

namespace GildedRoseDataBinding.Model
{
    public abstract class Article
    {
        private int _quality;
        private int _durability;
        private readonly IUpdateArticleStrategy _updateStrategy;

        protected Article(IUpdateArticleStrategy updateStrategy)
        {
            if (updateStrategy == null) throw new ArgumentNullException("updateStrategy");

            _updateStrategy = updateStrategy;
        }

        public string Name { get; set; }

        public string ArticleGroup { get; set; }

        public int Quality
        {
            get { return _quality; }
            set
            {
                if (value < 0)
                {
                    _quality = 0;
                    return;
                }

                _quality = value;
            }
        }

        public int Durability
        {
            get { return _durability; }
            set
            {
                if (value >= 0)
                {
                    _durability = value;
                    return;
                }

                _durability = 0;
            }
        }

        public virtual string Info
        {
            get
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(Name);
                stringBuilder.AppendLine("Quality: " + Quality);
                stringBuilder.AppendLine("Durability: " + Durability + " Days");
                AddSpecificArticleInfo(stringBuilder);

                return stringBuilder.ToString();
            }
        }

        public IUpdateArticleStrategy Type
        {
            get { return _updateStrategy; }
        }

        protected virtual void AddSpecificArticleInfo(StringBuilder stringBuilder)
        {
            
        }

        public void Update()
        {
            _updateStrategy.UpdateArticle(this);
        }
    }
}