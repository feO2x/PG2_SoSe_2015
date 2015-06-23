#include "EnchantedStrategy.h"
#include <stdexcept>

using std::invalid_argument;

void EnchantedStrategy::UpdateArticle(IArticle* const article) const
{
	if (article == nullptr)
		throw invalid_argument("article cannot be null");

	article->SetDurability(article->GetDurability() - 1);
	
	auto newQualityValue = article->GetQuality();
	if (article->GetDurability() > 0)
		newQualityValue -= 2;
	else
		newQualityValue -= 4;

	article->SetQuality(newQualityValue);
}