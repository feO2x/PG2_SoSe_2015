#include "IArticle.h"
#include <sstream>

using std::string;
using std::stringstream;
using std::endl;

IArticle::IArticle(string name, int quality, int durability, IUpdateArticleStrategy& strategy)
	: _name(name), _quality(quality), _durability(durability), _strategy(&strategy)
{

}

string IArticle::GetArticleInfo() const
{
	stringstream stringstream;

	stringstream << _name << endl;
	stringstream << "Durability: " << _durability << endl;
	stringstream << "Quality: " << _quality << endl;
	
	AddAdditionalArticleInformation(stringstream);
	return stringstream.str();
}

void IArticle::Update()
{
	_strategy->UpdateArticle(this);
}