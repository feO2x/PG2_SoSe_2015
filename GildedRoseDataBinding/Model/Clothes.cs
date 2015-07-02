using System;
using System.Text;

namespace GildedRoseDataBinding.Model
{
    public class Clothes : Article
    {
        private int _numberOfPockets;
        public int NumberOfPockets
        {
            get { return _numberOfPockets; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _numberOfPockets = value;
            }
        }

        public ClothingSize Size { get; set; }

        public Clothes(IUpdateArticleStrategy strategie)
            : base(strategie)
        {
            ArticleGroup = "Clothes";
        }

        protected override void AddSpecificArticleInfo(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("Size: " + Size);
            stringBuilder.AppendLine("Number of pockets: " + _numberOfPockets);
        }
    }
}