#pragma once
#include "IUpdateArticleStrategy.h"

struct IncreasingWithDecayStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) const override;
};

