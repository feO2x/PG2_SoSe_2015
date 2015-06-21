#include <stdexcept>
#include "DefaultStrategy.h"

using std::invalid_argument;

void DefaultStrategy::UpdateArticle(IArticle* article)
{
	if (article == nullptr)
		throw invalid_argument("article cannot be null");

	
	article->SetDurability(article->GetDurability() - 1);

	auto newQualityValue = article->GetQuality();
	if (article->GetDurability() > 0)
		newQualityValue--;
	else
		newQualityValue -= 2;
	
	article->SetQuality(newQualityValue);
}