using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterInformation : IMessage<CharacterInformation>, IMessage, IEquatable<CharacterInformation>, IDeepCloneable<CharacterInformation>, IBufferMessage
{
	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterInformation> _parser;

	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002306")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4002307")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4002308")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4002309")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x400230A")]
	public const int BreedIdFieldNumber = 3;

	[Token(Token = "0x400230B")]
	[FieldOffset(Offset = "0x28")]
	private int breedId_;

	[Token(Token = "0x400230C")]
	public const int GenderFieldNumber = 4;

	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x2C")]
	private Gender gender_;

	[Token(Token = "0x400230E")]
	public const int LevelFieldNumber = 5;

	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x30")]
	private int level_;

	[Token(Token = "0x4002310")]
	public const int AccountIdFieldNumber = 6;

	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x38")]
	private long accountId_;

	[Token(Token = "0x4002312")]
	public const int AccountTagFieldNumber = 7;

	[Token(Token = "0x4002313")]
	[FieldOffset(Offset = "0x40")]
	private string accountTag_;

	[Token(Token = "0x4002314")]
	public const int AccountNicknameFieldNumber = 8;

	[Token(Token = "0x4002315")]
	[FieldOffset(Offset = "0x48")]
	private string accountNickname_;

	[Token(Token = "0x4002316")]
	public const int StatusFieldNumber = 9;

	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x50")]
	private CharacterStatus status_;

	[Token(Token = "0x1700160C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterInformation> Parser
	{
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0xBA6FE0", Offset = "0xBA63E0", VA = "0x180BA6FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700160D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60066D1")]
		[Address(RVA = "0xBA6F30", Offset = "0xBA6330", VA = "0x180BA6F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700160E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0xBA7410", Offset = "0xBA6810", VA = "0x180BA7410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700160F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x60066D6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001610")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0xBA75D0", Offset = "0xBA69D0", VA = "0x180BA75D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001611")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BreedId
	{
		[Token(Token = "0x60066DA")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066DB")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001612")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Gender Gender
	{
		[Token(Token = "0x60066DC")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x60066DD")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17001613")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001614")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60066E1")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x17001615")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AccountTag
	{
		[Token(Token = "0x60066E2")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066E3")]
		[Address(RVA = "0xBA7560", Offset = "0xBA6960", VA = "0x180BA7560")]
		set
		{
		}
	}

	[Token(Token = "0x17001616")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AccountNickname
	{
		[Token(Token = "0x60066E4")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066E5")]
		[Address(RVA = "0xBA74F0", Offset = "0xBA68F0", VA = "0x180BA74F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001617")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterStatus Status
	{
		[Token(Token = "0x60066E6")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x60066D3")]
	[Address(RVA = "0xBA6EA0", Offset = "0xBA62A0", VA = "0x180BA6EA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterInformation()
	{
	}

	[Token(Token = "0x60066D4")]
	[Address(RVA = "0xBA6D60", Offset = "0xBA6160", VA = "0x180BA6D60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterInformation(CharacterInformation other)
	{
	}

	[Token(Token = "0x60066D5")]
	[Address(RVA = "0xBA6570", Offset = "0xBA5970", VA = "0x180BA6570", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60066E8")]
	[Address(RVA = "0xBA66D0", Offset = "0xBA5AD0", VA = "0x180BA66D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066E9")]
	[Address(RVA = "0xBA6800", Offset = "0xBA5C00", VA = "0x180BA6800", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066EA")]
	[Address(RVA = "0xBA68E0", Offset = "0xBA5CE0", VA = "0x180BA68E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60066EB")]
	[Address(RVA = "0xBA6C00", Offset = "0xBA6000", VA = "0x180BA6C00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60066EC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60066ED")]
	[Address(RVA = "0xBA7280", Offset = "0xBA6680", VA = "0x180BA7280", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60066EE")]
	[Address(RVA = "0xBA6370", Offset = "0xBA5770", VA = "0x180BA6370", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60066EF")]
	[Address(RVA = "0xBA6A50", Offset = "0xBA5E50", VA = "0x180BA6A50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterInformation other)
	{
	}

	[Token(Token = "0x60066F0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60066F1")]
	[Address(RVA = "0xBA7030", Offset = "0xBA6430", VA = "0x180BA7030", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
