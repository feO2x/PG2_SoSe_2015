#include "Food.h"
#include <stdexcept>
#include <sstream>

using std::string;
using std::vector;
using std::invalid_argument;
using std::stringstream;
using std::endl;

void Food::AddAdditionalArticleInformation(stringstream& stringstream) const
{
	stringstream << "Ingredients:" << endl;

	for (auto ingredient : _ingredients)
		stringstream << "  " << ingredient << endl;
}

Food::Food(string name, int quality, int durability, IUpdateArticleStrategy& strategy, vector<string>& ingredients)
	: IArticle(name, quality, durability, strategy), _ingredients(ingredients)
{
	if (ingredients.size() == 0)
		throw invalid_argument("ingredients cannot be an empty collection");
}