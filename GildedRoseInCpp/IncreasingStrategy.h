#pragma once
#include "IUpdateArticleStrategy.h"

struct IncreasingStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) override;
};

