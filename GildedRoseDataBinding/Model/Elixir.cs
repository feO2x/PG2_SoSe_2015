using System;
using System.Text;

namespace GildedRoseDataBinding.Model
{
    public class Elixir : Article
    {
        public const int Small = 200;
        public const int Normal = 400;
        public const int Large = 800;

        private int _size;
        public int Size
        {
            get { return _size; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _size = value;
            }
        }

        public Elixir(IUpdateArticleStrategy strategie) : 
            base(strategie)
        {
            ArticleGroup = "Elixirs";
        }

        protected override void AddSpecificArticleInfo(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine(string.Format("Size: {0}ml", Size));
        }
    }
}