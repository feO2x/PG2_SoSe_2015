#pragma once
#include <string>
#include "IUpdateArticleStrategy.h"

class IArticle
{
	std::string _name;
	int _quality;
	int _durability;
	IUpdateArticleStrategy* const _strategy;

protected:
	IArticle(std::string name, int quality, int durability, IUpdateArticleStrategy& strategy);

	virtual void AddAdditionalArticleInformation(std::stringstream& stringStream) const = 0;

public:

	inline int GetQuality() const
	{
		return _quality;
	}

	inline int GetDurability() const
	{
		return _durability;
	}

	inline std::string GetName() const
	{
		return _name;
	}

	std::string GetArticleInfo() const;

	void Update();

	virtual ~IArticle()
	{
	}
};
