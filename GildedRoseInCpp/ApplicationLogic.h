#pragma once

#include <vector>
#include "IArticle.h"

class ApplicationLogic
{
	std::vector<IArticle*>& _articles;

public:
	ApplicationLogic(std::vector<IArticle*>& articles);

	void Run();

private:
	void ShowArticles();
	void UpdateArticles();
};

