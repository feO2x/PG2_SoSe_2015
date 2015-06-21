#pragma once
#include "IArticle.h"


struct IUpdateArticleStrategy
{
	virtual void UpdateArticle(IArticle* article) = 0;

	virtual ~IUpdateArticleStrategy() { }
};