#pragma once
#include "IArticle.h"


struct IUpdateArticleStrategy
{
	virtual void UpdateArticle(IArticle* const article) const = 0;

	virtual ~IUpdateArticleStrategy() { }
};