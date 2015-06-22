#pragma once
#include <string>
#include <stdexcept>

enum class HiltType
{
	Wood,
	Metal,
	Silver,
	Gold
};

inline std::string HiltTypeToString(HiltType hiltType)
{
	switch (hiltType)
	{
	case HiltType::Wood: return "Wood";
	case HiltType::Metal: return "Metal";
	case HiltType::Silver: return "Silver";
	case HiltType::Gold: return "Gold";
	default:
		throw std::invalid_argument("Unknown hilt type");
	}
}