#pragma once
#include "IArticle.h"
#include "DamageType.h"
#include "HiltType.h"

class Weapon : public IArticle
{
	int _minimumDamage;
	int _maximumDamage;
	DamageType _damageType;
	HiltType _hiltType;

protected:
	void AddAdditionalArticleInformation(std::stringstream& stringstream) const override;

public:
	Weapon(std::string name, int quality, int durability, IUpdateArticleStrategy& strategy, int minimumDamage, int maximumDamage, DamageType damageType, HiltType hiltType);

	inline int GetMinimumDamage() const
	{
		return _minimumDamage;
	}

	inline int GetMaximumDamage() const
	{
		return _maximumDamage;
	}

	inline DamageType GetDamageType() const
	{
		return _damageType;
	}

	inline HiltType GetHiltType() const
	{
		return _hiltType;
	}
};
