#pragma once
#include "IArticle.h"

class Tickets :	public IArticle
{
protected:
	void AddAdditionalArticleInformation(std::stringstream& stringStream) const override;

public:
	Tickets(std::string name, int quality, int durability, const IUpdateArticleStrategy& strategy);
	
};

