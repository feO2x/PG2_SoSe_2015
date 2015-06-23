#pragma once
#include "IArticle.h"


struct IUpdateArticleStrategy
{
	virtual void UpdateArticle(IArticle* article) const = 0;

	virtual ~IUpdateArticleStrategy() { }
};