#pragma once
#include "IUpdateArticleStrategy.h"

struct EnchantedStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) const override;
};

