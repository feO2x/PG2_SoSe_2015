using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GildedRoseDataBinding.Model
{
    public abstract class Article : INotifyPropertyChanged
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
                    OnPropertyChanged();
                    return;
                }

                _quality = value;
                OnPropertyChanged();
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
                    OnPropertyChanged();
                    return;
                }

                _durability = 0;
                OnPropertyChanged();
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}