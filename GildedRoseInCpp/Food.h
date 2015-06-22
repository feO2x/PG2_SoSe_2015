#pragma once
#include "IArticle.h"
#include <vector>

class Food : public IArticle
{
	std::vector<std::string>& _ingredients;

protected:
	void AddAdditionalArticleInformation(std::stringstream& stringstream) const override;

public:
	Food(std::string name, int quality, int durability, IUpdateArticleStrategy& strategy, std::vector<std::string>& ingredients);

	inline std::vector<std::string>& GetIngredients() const
	{
		return _ingredients;
	}
};

