#pragma once
#include <string>
#include <stdexcept>

enum class DamageType
{
	Cut,
	Stab,
	LongRanged
};

inline std::string DamageTypeToString(DamageType damageType)
{
	switch (damageType)
	{
	case DamageType::Cut: return "Cut";
	case DamageType::Stab: return "Stab";
	case DamageType::LongRanged: return "Long Ranged";
	default:
		throw std::invalid_argument("Unknown damage type");
	}
}
