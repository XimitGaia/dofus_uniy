using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000936")]
public enum ObjectError
{
	[Token(Token = "0x4001FDC")]
	[OriginalName("INVENTORY_FULL")]
	InventoryFull,
	[Token(Token = "0x4001FDD")]
	[OriginalName("CANNOT_EQUIP_TWICE")]
	CannotEquipTwice,
	[Token(Token = "0x4001FDE")]
	[OriginalName("NOT_TRADABLE")]
	NotTradable,
	[Token(Token = "0x4001FDF")]
	[OriginalName("CANNOT_DROP")]
	CannotDrop,
	[Token(Token = "0x4001FE0")]
	[OriginalName("CANNOT_DROP_NO_PLACE")]
	CannotDropNoPlace,
	[Token(Token = "0x4001FE1")]
	[OriginalName("CANNOT_DESTROY")]
	CannotDestroy,
	[Token(Token = "0x4001FE2")]
	[OriginalName("LEVEL_TOO_LOW")]
	LevelTooLow,
	[Token(Token = "0x4001FE3")]
	[OriginalName("LIVING_OBJECT_REFUSED_FOOD")]
	LivingObjectRefusedFood,
	[Token(Token = "0x4001FE4")]
	[OriginalName("CANNOT_UNEQUIP")]
	CannotUnequip,
	[Token(Token = "0x4001FE5")]
	[OriginalName("CANNOT_EQUIP_HERE")]
	CannotEquipHere,
	[Token(Token = "0x4001FE6")]
	[OriginalName("CRITERIONS")]
	Criterions,
	[Token(Token = "0x4001FE7")]
	[OriginalName("SYMBIOTIC_OBJECT_ERROR")]
	SymbioticObjectError,
	[Token(Token = "0x4001FE8")]
	[OriginalName("EVOLUTIVE_OBJECT_REFUSED_FOOD")]
	EvolutiveObjectRefusedFood
}
