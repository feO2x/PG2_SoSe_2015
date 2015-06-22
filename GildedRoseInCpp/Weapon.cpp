#include "Weapon.h"
#include <stdexcept>
#include <sstream>

using std::stringstream;
using std::logic_error;
using std::endl;

void Weapon::AddAdditionalArticleInformation(stringstream& stringstream) const
{
	stringstream << "Damage Type: " << DamageTypeToString(_damageType) << endl;
	stringstream << "Minimum damage: " << _minimumDamage << endl;
	stringstream << "Maximum damage: " << _maximumDamage << endl;
	stringstream << "Hilt Type: " << HiltTypeToString(_hiltType) << endl;
}

Weapon::Weapon(std::string name, int quality, int durability, IUpdateArticleStrategy& strategy, int minimumDamage, int maximumDamage, DamageType damageType, HiltType hiltType)
	: IArticle(name, quality, durability, strategy), _minimumDamage(minimumDamage), _maximumDamage(maximumDamage), _damageType(damageType), _hiltType(hiltType)
{
	if (minimumDamage > maximumDamage)
		throw logic_error("minimumDamage cannot be greater than maximum damage");
}
