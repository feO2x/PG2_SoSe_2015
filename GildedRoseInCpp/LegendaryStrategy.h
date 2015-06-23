#pragma once
#include "IUpdateArticleStrategy.h"

struct LegendaryStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) const override;
	
};

