#pragma once
#include "IUpdateArticleStrategy.h"

struct IncreasingWithDecayStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* const article) const override;
};

