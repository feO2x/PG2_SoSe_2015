#pragma once
#include "IUpdateArticleStrategy.h"

struct LegendaryStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* const article) const override;
	
};

