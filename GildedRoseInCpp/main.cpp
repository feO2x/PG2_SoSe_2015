#include <vector>
#include <string>
#include "Clothes.h"
#include "Elixir.h"
#include "Food.h"
#include "Weapon.h"
#include "DefaultStrategy.h"
#include "EnchantedStrategy.h"
#include "IncreasingStrategy.h"
#include "IncreasingWithDecayStrategy.h"
#include "LegendaryStrategy.h"

using namespace std;

void main()
{
	// Composition root
	// -------------------------------

	// Strategies
	DefaultStrategy standard;
	IncreasingStrategy increasing;
	LegendaryStrategy legendary;
	IncreasingWithDecayStrategy increasingWithDecay;
	EnchantedStrategy enchanted;

	// Articles
	vector<IArticle*> articles;
	articles.push_back(new Clothes("+5 Dexterity Vest", 20, 10, standard, 4, ClothingSize::XL));
	vector<string> brieIngredients = {"Pastorized lactose-free milk", "Penecelinum Camemberti"};
	articles.push_back(new Food("Ancient Brie Cheese", 2, 5, increasing, brieIngredients));
	articles.push_back(new Elixir("Elixir of the mongoose", 7, 5, standard, 800));
	articles.push_back(new Weapon("Sulfuras, Sword of Ragnaros", 80, 0, legendary, 111, 143, DamageType::Cut, HiltType::Gold));
	vector<string> cakeIngredients = {"Eggs", "Flour", "sugar", "Vanilla sugar", "pieces of apples", "Almonds", "Mana Elixir"};
	articles.push_back(new Food("Mana cake", 6, 3, enchanted, cakeIngredients));

	// Run program

	// Cleanup

	for (auto article : articles)
	{
		delete article;
	}
}
