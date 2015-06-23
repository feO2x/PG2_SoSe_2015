#include "ApplicationLogic.h"
#include <iostream>

using std::vector;
using std::cout;
using std::endl;
using std::cin;

ApplicationLogic::ApplicationLogic(vector<IArticle*>& articles)
	: _articles(articles)
{
}

void ApplicationLogic::Run()
{
	cout << "Welcome to the Gilded Rose" << endl;
	cout << "--------------------------" << endl;
	cout << endl;

	while (true)
	{
		ShowArticles();
		char input = cin.get();
		if (input == 'q')
			return;
		UpdateArticles();
	}
}

void ApplicationLogic::ShowArticles()
{
	cout << "Our articles:" << endl;
	cout << "-------------" << endl;
	cout << endl;

	for (auto article : _articles)
	{
		cout << article->GetArticleInfo() << endl;
		cout << endl;
	}
}

void ApplicationLogic::UpdateArticles()
{
	for (auto article : _articles)
	{
		article->Update();
	}
}