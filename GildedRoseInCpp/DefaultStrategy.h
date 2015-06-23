#pragma once
#include "IUpdateArticleStrategy.h"

struct DefaultStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* const article) const override;
};
