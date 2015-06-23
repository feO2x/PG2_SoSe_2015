#pragma once
#include "IArticle.h"

class Elixir : public IArticle
{
	int _size;

protected:
	void AddAdditionalArticleInformation(std::stringstream& stringStream) const override;

public:
	Elixir(std::string name, int quality, int durability, const IUpdateArticleStrategy& strategy, int size);

	inline int GetSize() const
	{
		return _size;
	}
};

