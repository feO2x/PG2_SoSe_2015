#pragma once
#include "IUpdateArticleStrategy.h"

struct DefaultStrategy : IUpdateArticleStrategy
{
	void UpdateArticle(IArticle* article) override;
};
