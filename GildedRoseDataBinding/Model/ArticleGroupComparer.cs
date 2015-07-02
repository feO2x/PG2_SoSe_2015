using System.Collections.Generic;

namespace GildedRoseDataBinding.Model
{
    public class ArticleGroupComparer : IComparer<string>
    {
        private readonly List<string> _groupNames = new List<string>
                                                      {
                                                          "Weapons",
                                                          "Clothes",
                                                          "Elixirs",
                                                          "Food",
                                                          "Other Stuff"
                                                      };

        public int Compare(string x, string y)
        {
            var indexOfX = _groupNames.IndexOf(x);
            var indexOfY = _groupNames.IndexOf(y);
            return indexOfX - indexOfY;
        }
    }
}