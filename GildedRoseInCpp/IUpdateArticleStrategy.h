#pragma once

class IArticle;

struct IUpdateArticleStrategy
{
	virtual void UpdateArticle(IArticle* article) = 0;

	virtual ~IUpdateArticleStrategy() { }
};