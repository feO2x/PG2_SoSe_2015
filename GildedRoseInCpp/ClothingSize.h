#pragma once
#include <string>
#include <stdexcept>

enum class ClothingSize
{
	XS,
	S,
	M,
	L,
	XL,
	XXL
};

inline std::string ClothingSizeToString(ClothingSize clothingSize)
{
	switch (clothingSize)
	{
	case ClothingSize::XS: return "XS";
	case ClothingSize::S: return "S";
	case ClothingSize::M: return "M";
	case ClothingSize::L: return "L";
	case ClothingSize::XL: return "XL";
	case ClothingSize::XXL: return "XXL";
	default:
		throw std::invalid_argument("Unknown ClothingSize specified");
	}
}