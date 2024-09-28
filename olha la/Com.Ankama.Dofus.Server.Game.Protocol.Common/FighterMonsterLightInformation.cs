using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A16")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FighterMonsterLightInformation : IMessage<FighterMonsterLightInformation>, IMessage, IEquatable<FighterMonsterLightInformation>, IDeepCloneable<FighterMonsterLightInformation>, IBufferMessage
{
	[Token(Token = "0x400242E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FighterMonsterLightInformation> _parser;

	[Token(Token = "0x400242F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002430")]
	public const int MonsterGidFieldNumber = 1;

	[Token(Token = "0x4002431")]
	[FieldOffset(Offset = "0x18")]
	private int monsterGid_;

	[Token(Token = "0x170016B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FighterMonsterLightInformation> Parser
	{
		[Token(Token = "0x6006944")]
		[Address(RVA = "0xBC4A70", Offset = "0xBC3E70", VA = "0x180BC4A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006945")]
		[Address(RVA = "0xBC49C0", Offset = "0xBC3DC0", VA = "0x180BC49C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006946")]
		[Address(RVA = "0xBC4AC0", Offset = "0xBC3EC0", VA = "0x180BC4AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterGid
	{
		[Token(Token = "0x600694A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600694B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6006947")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterMonsterLightInformation()
	{
	}

	[Token(Token = "0x6006948")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterMonsterLightInformation(FighterMonsterLightInformation other)
	{
	}

	[Token(Token = "0x6006949")]
	[Address(RVA = "0xBC4750", Offset = "0xBC3B50", VA = "0x180BC4750", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FighterMonsterLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600694C")]
	[Address(RVA = "0xBC47D0", Offset = "0xBC3BD0", VA = "0x180BC47D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600694D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FighterMonsterLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600694E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600694F")]
	[Address(RVA = "0xBC4860", Offset = "0xBC3C60", VA = "0x180BC4860", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006950")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006951")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006952")]
	[Address(RVA = "0xBC46C0", Offset = "0xBC3AC0", VA = "0x180BC46C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006953")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FighterMonsterLightInformation other)
	{
	}

	[Token(Token = "0x6006954")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006955")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
