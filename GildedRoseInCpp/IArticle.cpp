#include "IArticle.h"
#include "IUpdateArticleStrategy.h"
#include <sstream>

using std::string;
using std::stringstream;
using std::endl;

IArticle::IArticle(string name, int quality, int durability, const IUpdateArticleStrategy& strategy)
	: _name(name), _quality(quality), _durability(durability), _strategy(&strategy)
{

}

void IArticle::SetQuality(int quality)
{
	if (quality < 0)
	{
		_quality = 0;
		return;
	}
		
	_quality = quality;
}

void IArticle::SetDurability(int durability)
{
	if (durability < 0)
	{
		_durability = 0;
		return;
	}

	_durability = durability;
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