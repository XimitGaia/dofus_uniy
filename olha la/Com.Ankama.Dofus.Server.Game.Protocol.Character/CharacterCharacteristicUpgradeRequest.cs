using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000867")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicUpgradeRequest : IMessage<CharacterCharacteristicUpgradeRequest>, IMessage, IEquatable<CharacterCharacteristicUpgradeRequest>, IDeepCloneable<CharacterCharacteristicUpgradeRequest>, IBufferMessage
{
	[Token(Token = "0x4001D19")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicUpgradeRequest> _parser;

	[Token(Token = "0x4001D1A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D1B")]
	public const int StrengthFieldNumber = 1;

	[Token(Token = "0x4001D1C")]
	[FieldOffset(Offset = "0x18")]
	private int strength_;

	[Token(Token = "0x4001D1D")]
	public const int VitalityFieldNumber = 2;

	[Token(Token = "0x4001D1E")]
	[FieldOffset(Offset = "0x1C")]
	private int vitality_;

	[Token(Token = "0x4001D1F")]
	public const int WisdomFieldNumber = 3;

	[Token(Token = "0x4001D20")]
	[FieldOffset(Offset = "0x20")]
	private int wisdom_;

	[Token(Token = "0x4001D21")]
	public const int ChanceFieldNumber = 4;

	[Token(Token = "0x4001D22")]
	[FieldOffset(Offset = "0x24")]
	private int chance_;

	[Token(Token = "0x4001D23")]
	public const int AgilityFieldNumber = 5;

	[Token(Token = "0x4001D24")]
	[FieldOffset(Offset = "0x28")]
	private int agility_;

	[Token(Token = "0x4001D25")]
	public const int IntelligenceFieldNumber = 6;

	[Token(Token = "0x4001D26")]
	[FieldOffset(Offset = "0x2C")]
	private int intelligence_;

	[Token(Token = "0x17001301")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCharacteristicUpgradeRequest> Parser
	{
		[Token(Token = "0x6005945")]
		[Address(RVA = "0xB16D80", Offset = "0xB16180", VA = "0x180B16D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001302")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005946")]
		[Address(RVA = "0xB16CD0", Offset = "0xB160D0", VA = "0x180B16CD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001303")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005947")]
		[Address(RVA = "0xB17000", Offset = "0xB16400", VA = "0x180B17000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001304")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Strength
	{
		[Token(Token = "0x600594B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600594C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001305")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Vitality
	{
		[Token(Token = "0x600594D")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600594E")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001306")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Wisdom
	{
		[Token(Token = "0x600594F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005950")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001307")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Chance
	{
		[Token(Token = "0x6005951")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001308")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Agility
	{
		[Token(Token = "0x6005953")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005954")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001309")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Intelligence
	{
		[Token(Token = "0x6005955")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005956")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6005948")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicUpgradeRequest()
	{
	}

	[Token(Token = "0x6005949")]
	[Address(RVA = "0xB16C60", Offset = "0xB16060", VA = "0x180B16C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicUpgradeRequest(CharacterCharacteristicUpgradeRequest other)
	{
	}

	[Token(Token = "0x600594A")]
	[Address(RVA = "0xB167F0", Offset = "0xB15BF0", VA = "0x180B167F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicUpgradeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005957")]
	[Address(RVA = "0xB168E0", Offset = "0xB15CE0", VA = "0x180B168E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005958")]
	[Address(RVA = "0xB16890", Offset = "0xB15C90", VA = "0x180B16890", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCharacteristicUpgradeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005959")]
	[Address(RVA = "0xB16990", Offset = "0xB15D90", VA = "0x180B16990", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600595A")]
	[Address(RVA = "0xB16B00", Offset = "0xB15F00", VA = "0x180B16B00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600595B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600595C")]
	[Address(RVA = "0xB16F00", Offset = "0xB16300", VA = "0x180B16F00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600595D")]
	[Address(RVA = "0xB16690", Offset = "0xB15A90", VA = "0x180B16690", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600595E")]
	[Address(RVA = "0xB16A80", Offset = "0xB15E80", VA = "0x180B16A80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterCharacteristicUpgradeRequest other)
	{
	}

	[Token(Token = "0x600595F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005960")]
	[Address(RVA = "0xB16DD0", Offset = "0xB161D0", VA = "0x180B16DD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
