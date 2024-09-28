using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009E3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerSearch : IMessage<PlayerSearch>, IMessage, IEquatable<PlayerSearch>, IDeepCloneable<PlayerSearch>, IBufferMessage
{
	[Token(Token = "0x20009E4")]
	public enum PlayerSearchOneofCase
	{
		[Token(Token = "0x4002330")]
		None,
		[Token(Token = "0x4002331")]
		SearchByCharacterName,
		[Token(Token = "0x4002332")]
		SearchByAccount
	}

	[Token(Token = "0x20009E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20009E6")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SearchByCharacterName : IMessage<SearchByCharacterName>, IMessage, IEquatable<SearchByCharacterName>, IDeepCloneable<SearchByCharacterName>, IBufferMessage
		{
			[Token(Token = "0x4002333")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SearchByCharacterName> _parser;

			[Token(Token = "0x4002334")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002335")]
			public const int NameFieldNumber = 1;

			[Token(Token = "0x4002336")]
			[FieldOffset(Offset = "0x18")]
			private string name_;

			[Token(Token = "0x17001624")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SearchByCharacterName> Parser
			{
				[Token(Token = "0x6006727")]
				[Address(RVA = "0xBAFE20", Offset = "0xBAF220", VA = "0x180BAFE20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001625")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006728")]
				[Address(RVA = "0xBAFDA0", Offset = "0xBAF1A0", VA = "0x180BAFDA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001626")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006729")]
				[Address(RVA = "0xBAFF30", Offset = "0xBAF330", VA = "0x180BAFF30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001627")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string Name
			{
				[Token(Token = "0x600672D")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x600672E")]
				[Address(RVA = "0xBAFFE0", Offset = "0xBAF3E0", VA = "0x180BAFFE0")]
				set
				{
				}
			}

			[Token(Token = "0x600672A")]
			[Address(RVA = "0xBAFD50", Offset = "0xBAF150", VA = "0x180BAFD50")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SearchByCharacterName()
			{
			}

			[Token(Token = "0x600672B")]
			[Address(RVA = "0xBAFCB0", Offset = "0xBAF0B0", VA = "0x180BAFCB0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SearchByCharacterName(SearchByCharacterName other)
			{
			}

			[Token(Token = "0x600672C")]
			[Address(RVA = "0xBAF970", Offset = "0xBAED70", VA = "0x180BAF970", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SearchByCharacterName Clone()
			{
				return null;
			}

			[Token(Token = "0x600672F")]
			[Address(RVA = "0xBAFA40", Offset = "0xBAEE40", VA = "0x180BAFA40", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006730")]
			[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SearchByCharacterName other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006731")]
			[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006732")]
			[Address(RVA = "0xBAFB50", Offset = "0xBAEF50", VA = "0x180BAFB50", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006733")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006734")]
			[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006735")]
			[Address(RVA = "0xBAF8E0", Offset = "0xBAECE0", VA = "0x180BAF8E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006736")]
			[Address(RVA = "0xBAFAF0", Offset = "0xBAEEF0", VA = "0x180BAFAF0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SearchByCharacterName other)
			{
			}

			[Token(Token = "0x6006737")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006738")]
			[Address(RVA = "0xBAFE70", Offset = "0xBAF270", VA = "0x180BAFE70", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20009E8")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SearchByAccount : IMessage<SearchByAccount>, IMessage, IEquatable<SearchByAccount>, IDeepCloneable<SearchByAccount>, IBufferMessage
		{
			[Token(Token = "0x4002338")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SearchByAccount> _parser;

			[Token(Token = "0x4002339")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400233A")]
			public const int NameFieldNumber = 1;

			[Token(Token = "0x400233B")]
			[FieldOffset(Offset = "0x18")]
			private string name_;

			[Token(Token = "0x400233C")]
			public const int TagFieldNumber = 2;

			[Token(Token = "0x400233D")]
			[FieldOffset(Offset = "0x20")]
			private string tag_;

			[Token(Token = "0x17001628")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SearchByAccount> Parser
			{
				[Token(Token = "0x600673D")]
				[Address(RVA = "0xBAF610", Offset = "0xBAEA10", VA = "0x180BAF610")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001629")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600673E")]
				[Address(RVA = "0xBAF590", Offset = "0xBAE990", VA = "0x180BAF590")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700162A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600673F")]
				[Address(RVA = "0xBAF750", Offset = "0xBAEB50", VA = "0x180BAF750", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700162B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string Name
			{
				[Token(Token = "0x6006743")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006744")]
				[Address(RVA = "0xBAF800", Offset = "0xBAEC00", VA = "0x180BAF800")]
				set
				{
				}
			}

			[Token(Token = "0x1700162C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string Tag
			{
				[Token(Token = "0x6006745")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006746")]
				[Address(RVA = "0xBAF870", Offset = "0xBAEC70", VA = "0x180BAF870")]
				set
				{
				}
			}

			[Token(Token = "0x6006740")]
			[Address(RVA = "0xBAF440", Offset = "0xBAE840", VA = "0x180BAF440")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SearchByAccount()
			{
			}

			[Token(Token = "0x6006741")]
			[Address(RVA = "0xBAF4B0", Offset = "0xBAE8B0", VA = "0x180BAF4B0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SearchByAccount(SearchByAccount other)
			{
			}

			[Token(Token = "0x6006742")]
			[Address(RVA = "0xBAF0A0", Offset = "0xBAE4A0", VA = "0x180BAF0A0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SearchByAccount Clone()
			{
				return null;
			}

			[Token(Token = "0x6006747")]
			[Address(RVA = "0xBAF1A0", Offset = "0xBAE5A0", VA = "0x180BAF1A0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006748")]
			[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SearchByAccount other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006749")]
			[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600674A")]
			[Address(RVA = "0xBAF2E0", Offset = "0xBAE6E0", VA = "0x180BAF2E0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600674B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600674C")]
			[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600674D")]
			[Address(RVA = "0xBAEFE0", Offset = "0xBAE3E0", VA = "0x180BAEFE0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600674E")]
			[Address(RVA = "0xBAF260", Offset = "0xBAE660", VA = "0x180BAF260", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SearchByAccount other)
			{
			}

			[Token(Token = "0x600674F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006750")]
			[Address(RVA = "0xBAF660", Offset = "0xBAEA60", VA = "0x180BAF660", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002329")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerSearch> _parser;

	[Token(Token = "0x400232A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400232B")]
	public const int SearchByCharacterNameFieldNumber = 1;

	[Token(Token = "0x400232C")]
	public const int SearchByAccountFieldNumber = 2;

	[Token(Token = "0x400232D")]
	[FieldOffset(Offset = "0x18")]
	private object playerSearch_;

	[Token(Token = "0x400232E")]
	[FieldOffset(Offset = "0x20")]
	private PlayerSearchOneofCase playerSearchCase_;

	[Token(Token = "0x1700161E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerSearch> Parser
	{
		[Token(Token = "0x6006710")]
		[Address(RVA = "0xBAEBA0", Offset = "0xBADFA0", VA = "0x180BAEBA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700161F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006711")]
		[Address(RVA = "0xBAEAF0", Offset = "0xBADEF0", VA = "0x180BAEAF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001620")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006712")]
		[Address(RVA = "0xBAEFA0", Offset = "0xBAE3A0", VA = "0x180BAEFA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001621")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.SearchByCharacterName SearchByCharacterName
	{
		[Token(Token = "0x6006716")]
		[Address(RVA = "0xBAEC50", Offset = "0xBAE050", VA = "0x180BAEC50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006717")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17001622")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SearchByAccount SearchByAccount
	{
		[Token(Token = "0x6006718")]
		[Address(RVA = "0xBAEBF0", Offset = "0xBADFF0", VA = "0x180BAEBF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006719")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001623")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSearchOneofCase PlayerSearchCase
	{
		[Token(Token = "0x600671A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PlayerSearchOneofCase);
		}
	}

	[Token(Token = "0x6006713")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerSearch()
	{
	}

	[Token(Token = "0x6006714")]
	[Address(RVA = "0xBAE830", Offset = "0xBADC30", VA = "0x180BAE830")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerSearch(PlayerSearch other)
	{
	}

	[Token(Token = "0x6006715")]
	[Address(RVA = "0xBAE010", Offset = "0xBAD410", VA = "0x180BAE010", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSearch Clone()
	{
		return null;
	}

	[Token(Token = "0x600671B")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPlayerSearch()
	{
	}

	[Token(Token = "0x600671C")]
	[Address(RVA = "0xBAE070", Offset = "0xBAD470", VA = "0x180BAE070", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600671D")]
	[Address(RVA = "0xBAE1E0", Offset = "0xBAD5E0", VA = "0x180BAE1E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PlayerSearch other)
	{
		return default(bool);
	}

	[Token(Token = "0x600671E")]
	[Address(RVA = "0xBAE310", Offset = "0xBAD710", VA = "0x180BAE310", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600671F")]
	[Address(RVA = "0xBAE6D0", Offset = "0xBADAD0", VA = "0x180BAE6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006720")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006721")]
	[Address(RVA = "0xBAEE90", Offset = "0xBAE290", VA = "0x180BAEE90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006722")]
	[Address(RVA = "0xBADEE0", Offset = "0xBAD2E0", VA = "0x180BADEE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006723")]
	[Address(RVA = "0xBAE440", Offset = "0xBAD840", VA = "0x180BAE440", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerSearch other)
	{
	}

	[Token(Token = "0x6006724")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006725")]
	[Address(RVA = "0xBAECB0", Offset = "0xBAE0B0", VA = "0x180BAECB0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
