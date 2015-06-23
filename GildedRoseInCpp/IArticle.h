#pragma once
#include <string>

struct IUpdateArticleStrategy;

class IArticle
{
	std::string _name;
	int _quality;
	int _durability;
	const IUpdateArticleStrategy* const _strategy;

protected:
	IArticle(std::string name, int quality, int durability, const IUpdateArticleStrategy& strategy);

	virtual void AddAdditionalArticleInformation(std::stringstream& stringStream) const = 0;

public:

	inline int GetQuality() const
	{
		return _quality;
	}

	void SetQuality(int quality);

	inline int GetDurability() const
	{
		return _durability;
	}

	void SetDurability(int durability);

	inline std::string GetName() const
	{
		return _name;
	}

	std::string GetArticleInfo() const;

	void Update();

	virtual ~IArticle()
	{
	}
};
