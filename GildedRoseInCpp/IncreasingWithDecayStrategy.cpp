#include "IncreasingWithDecayStrategy.h"
#include <stdexcept>

using std::invalid_argument;

void IncreasingWithDecayStrategy::UpdateArticle(IArticle* const article) const
{
	if (article == nullptr)
		throw invalid_argument("article cannot be null");

	article->SetDurability(article->GetDurability() - 1);

	auto newQualityValue = article->GetQuality();
	auto currentDurability = article->GetDurability();
	if (currentDurability <= 0)
		newQualityValue = 0;
	else if (currentDurability <= 5)
		newQualityValue += 3;
	else if (currentDurability <= 10)
		newQualityValue += 2;
	else
		newQualityValue++;

	article->SetQuality(newQualityValue);
	
}