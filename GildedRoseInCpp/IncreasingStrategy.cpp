#include "IncreasingStrategy.h"
#include <stdexcept>

using std::invalid_argument;

void IncreasingStrategy::UpdateArticle(IArticle* const article) const
{
	if (article == nullptr)
		throw invalid_argument("article must not be null");

	article->SetDurability(article->GetDurability() - 1);

	auto newQualityValue = article->GetQuality();
	if (article->GetDurability() > 0)
		newQualityValue++;
	else
		newQualityValue += 2;

	article->SetQuality(newQualityValue);
}