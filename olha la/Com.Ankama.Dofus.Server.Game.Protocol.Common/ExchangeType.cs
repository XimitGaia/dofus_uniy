using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200092C")]
public enum ExchangeType
{
	[Token(Token = "0x4001F87")]
	[OriginalName("NPC_SHOP")]
	NpcShop,
	[Token(Token = "0x4001F88")]
	[OriginalName("PLAYER_TRADE")]
	PlayerTrade,
	[Token(Token = "0x4001F89")]
	[OriginalName("NPC_TRADE")]
	NpcTrade,
	[Token(Token = "0x4001F8A")]
	[OriginalName("CRAFT")]
	Craft,
	[Token(Token = "0x4001F8B")]
	[OriginalName("STORAGE")]
	Storage,
	[Token(Token = "0x4001F8C")]
	[OriginalName("SHOP_STOCK")]
	ShopStock,
	[Token(Token = "0x4001F8D")]
	[OriginalName("TAX_COLLECTOR")]
	TaxCollector,
	[Token(Token = "0x4001F8E")]
	[OriginalName("NPC_MODIFY_TRADE")]
	NpcModifyTrade,
	[Token(Token = "0x4001F8F")]
	[OriginalName("BIDHOUSE_SELL")]
	BidhouseSell,
	[Token(Token = "0x4001F90")]
	[OriginalName("BIDHOUSE_BUY")]
	BidhouseBuy,
	[Token(Token = "0x4001F91")]
	[OriginalName("MULTICRAFT_CRAFTER")]
	MulticraftCrafter,
	[Token(Token = "0x4001F92")]
	[OriginalName("MULTICRAFT_CUSTOMER")]
	MulticraftCustomer,
	[Token(Token = "0x4001F93")]
	[OriginalName("JOB_INDEX")]
	JobIndex,
	[Token(Token = "0x4001F94")]
	[OriginalName("MOUNT")]
	Mount,
	[Token(Token = "0x4001F95")]
	[OriginalName("MOUNT_STABLE")]
	MountStable,
	[Token(Token = "0x4001F96")]
	[OriginalName("NPC_RESURECT_PET")]
	NpcResurectPet,
	[Token(Token = "0x4001F97")]
	[OriginalName("NPC_TRADE_DRAGOTURKEY")]
	NpcTradeDragoturkey,
	[Token(Token = "0x4001F98")]
	[OriginalName("REALESTATE_HOUSE")]
	RealestateHouse,
	[Token(Token = "0x4001F99")]
	[OriginalName("REALESTATE_FARM")]
	RealestateFarm,
	[Token(Token = "0x4001F9A")]
	[OriginalName("RUNES_TRADE")]
	RunesTrade,
	[Token(Token = "0x4001F9B")]
	[OriginalName("RECYCLE_TRADE")]
	RecycleTrade,
	[Token(Token = "0x4001F9C")]
	[OriginalName("BANK")]
	Bank,
	[Token(Token = "0x4001F9D")]
	[OriginalName("TRASHBIN")]
	Trashbin,
	[Token(Token = "0x4001F9E")]
	[OriginalName("ALLIANCE_PRISM")]
	AlliancePrism,
	[Token(Token = "0x4001F9F")]
	[OriginalName("HAVENBAG")]
	Havenbag,
	[Token(Token = "0x4001FA0")]
	[OriginalName("NPC_TRADE_SEEMYOOL")]
	NpcTradeSeemyool,
	[Token(Token = "0x4001FA1")]
	[OriginalName("NPC_TRADE_RHINEETLE")]
	NpcTradeRhineetle,
	[Token(Token = "0x4001FA2")]
	[OriginalName("EVOLUTIVE_OBJECT_ELEMENTARY_RECYCLE")]
	EvolutiveObjectElementaryRecycle,
	[Token(Token = "0x4001FA3")]
	[OriginalName("NPC_RIDE_CAPABILITY_TRADE")]
	NpcRideCapabilityTrade,
	[Token(Token = "0x4001FA4")]
	[OriginalName("GUILD_CHEST")]
	GuildChest
}
