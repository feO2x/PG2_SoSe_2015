#include "Clothes.h"
#include <sstream>
#include <stdexcept>

using std::string;
using std::invalid_argument;
using std::endl;
using std::stringstream;

void Clothes::AddAdditionalArticleInformation(stringstream& stringstream) const
{
	stringstream << "Clothing size: " << ClothingSizeToString(_clothingSize) << endl;
	stringstream << "Number of pockets: " << _numberOfPockets << endl;
}

Clothes::Clothes(string name, int quality, int durability, const IUpdateArticleStrategy& strategy, int numberOfPockets, ClothingSize clothingSize)
	: IArticle(name, quality, durability, strategy), _numberOfPockets(numberOfPockets), _clothingSize(clothingSize)
{
	if (numberOfPockets < 0)
		throw invalid_argument("numberOfPockets cannot be less than zero");
}

void Clothes::SetNumberOfPockets(int numberOfPockets)
{
	if (numberOfPockets < 0)
		throw invalid_argument("numberOfPockets cannot be less than zero");

	_numberOfPockets = numberOfPockets;
}

void Clothes::SetClothingSize(ClothingSize clothingSize)
{
	_clothingSize = clothingSize;
}