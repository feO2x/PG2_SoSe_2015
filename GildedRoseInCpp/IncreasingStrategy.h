#pragma once
#include "IUpdateArticleStrategy.h"

struct IncreasingStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* const article) const override;
};

