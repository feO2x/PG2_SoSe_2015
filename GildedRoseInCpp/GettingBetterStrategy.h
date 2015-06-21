#pragma once
#include "IUpdateArticleStrategy.h"

struct GettingBetterStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) override;
};

