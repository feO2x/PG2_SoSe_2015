#include "Tickets.h"

void Tickets::AddAdditionalArticleInformation(std::stringstream& stringStream) const
{
	// Nothing happens here because there is no additional information on Tickets
}

Tickets::Tickets(std::string name, int quality, int durability, const IUpdateArticleStrategy& strategy)
	: IArticle(name, quality, durability, strategy)
{
}