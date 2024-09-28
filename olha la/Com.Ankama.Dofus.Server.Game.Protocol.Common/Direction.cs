using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000935")]
public enum Direction
{
	[Token(Token = "0x4001FD3")]
	[OriginalName("DIRECTION_EAST")]
	East,
	[Token(Token = "0x4001FD4")]
	[OriginalName("DIRECTION_SOUTH_EAST")]
	SouthEast,
	[Token(Token = "0x4001FD5")]
	[OriginalName("DIRECTION_SOUTH")]
	South,
	[Token(Token = "0x4001FD6")]
	[OriginalName("DIRECTION_SOUTH_WEST")]
	SouthWest,
	[Token(Token = "0x4001FD7")]
	[OriginalName("DIRECTION_WEST")]
	West,
	[Token(Token = "0x4001FD8")]
	[OriginalName("DIRECTION_NORTH_WEST")]
	NorthWest,
	[Token(Token = "0x4001FD9")]
	[OriginalName("DIRECTION_NORTH")]
	North,
	[Token(Token = "0x4001FDA")]
	[OriginalName("DIRECTION_NORTH_EAST")]
	NorthEast
}
