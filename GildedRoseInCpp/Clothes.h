#pragma once
#include "IArticle.h"
#include "ClothingSize.h"

class Clothes : public IArticle
{
	int _numberOfPockets;
	ClothingSize _clothingSize;

protected:
	void AddAdditionalArticleInformation(std::stringstream& stringstream) const override;

public:
	Clothes(std::string name, int quality, int durability, IUpdateArticleStrategy& strategy, int numberOfPockets, ClothingSize clothingSize);

	inline int GetNumberOfPockets() const
	{
		return _numberOfPockets;
	}

	void SetNumberOfPockets(int numberOfPockets);

	inline ClothingSize GetClothingSize() const
	{
		return _clothingSize;
	}

	void SetClothingSize(ClothingSize clothingSize);
		
};

