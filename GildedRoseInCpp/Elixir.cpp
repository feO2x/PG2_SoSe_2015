#include "Elixir.h"
#include <sstream>
#include <stdexcept>

using std::string;
using std::stringstream;
using std::endl;
using std::invalid_argument;

void Elixir::AddAdditionalArticleInformation(stringstream& stringStream) const
{
	stringStream << "Size: " << _size << endl;
}

Elixir::Elixir(std::string name, int quality, int durability, const IUpdateArticleStrategy& strategy, int size)
	: IArticle(name, quality, durability, strategy), _size(size)
{
	if (size < 0)
		throw invalid_argument("Elixir size cannot be less than zero");
}
