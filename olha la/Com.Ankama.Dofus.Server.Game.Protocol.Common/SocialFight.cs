using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A0B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialFight : IMessage<SocialFight>, IMessage, IEquatable<SocialFight>, IDeepCloneable<SocialFight>, IBufferMessage
{
	[Token(Token = "0x40023F0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SocialFight> _parser;

	[Token(Token = "0x40023F1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023F2")]
	public const int SocialFightInfoFieldNumber = 1;

	[Token(Token = "0x40023F3")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation socialFightInfo_;

	[Token(Token = "0x40023F4")]
	public const int AttackersFieldNumber = 2;

	[Token(Token = "0x40023F5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Character> _repeated_attackers_codec;

	[Token(Token = "0x40023F6")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Character> attackers_;

	[Token(Token = "0x40023F7")]
	public const int DefendersFieldNumber = 3;

	[Token(Token = "0x40023F8")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Character> _repeated_defenders_codec;

	[Token(Token = "0x40023F9")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Character> defenders_;

	[Token(Token = "0x40023FA")]
	public const int PhaseFieldNumber = 4;

	[Token(Token = "0x40023FB")]
	[FieldOffset(Offset = "0x30")]
	private FightPhaseInfo phase_;

	[Token(Token = "0x17001690")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SocialFight> Parser
	{
		[Token(Token = "0x60068CC")]
		[Address(RVA = "0xBC6420", Offset = "0xBC5820", VA = "0x180BC6420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001691")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60068CD")]
		[Address(RVA = "0xBC6370", Offset = "0xBC5770", VA = "0x180BC6370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001692")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xBC67D0", Offset = "0xBC5BD0", VA = "0x180BC67D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001693")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation SocialFightInfo
	{
		[Token(Token = "0x60068D2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60068D3")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001694")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Character> Attackers
	{
		[Token(Token = "0x60068D4")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001695")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Character> Defenders
	{
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001696")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPhaseInfo Phase
	{
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x60068CF")]
	[Address(RVA = "0xBC6140", Offset = "0xBC5540", VA = "0x180BC6140")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFight()
	{
	}

	[Token(Token = "0x60068D0")]
	[Address(RVA = "0xBC61F0", Offset = "0xBC55F0", VA = "0x180BC61F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFight(SocialFight other)
	{
	}

	[Token(Token = "0x60068D1")]
	[Address(RVA = "0xBC59D0", Offset = "0xBC4DD0", VA = "0x180BC59D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFight Clone()
	{
		return null;
	}

	[Token(Token = "0x60068D8")]
	[Address(RVA = "0xBC5B10", Offset = "0xBC4F10", VA = "0x180BC5B10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068D9")]
	[Address(RVA = "0xBC5A30", Offset = "0xBC4E30", VA = "0x180BC5A30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SocialFight other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068DA")]
	[Address(RVA = "0xBC5C40", Offset = "0xBC5040", VA = "0x180BC5C40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60068DB")]
	[Address(RVA = "0xBC5EC0", Offset = "0xBC52C0", VA = "0x180BC5EC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60068DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60068DD")]
	[Address(RVA = "0xBC66A0", Offset = "0xBC5AA0", VA = "0x180BC66A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60068DE")]
	[Address(RVA = "0xBC5890", Offset = "0xBC4C90", VA = "0x180BC5890", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60068DF")]
	[Address(RVA = "0xBC5D20", Offset = "0xBC5120", VA = "0x180BC5D20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SocialFight other)
	{
	}

	[Token(Token = "0x60068E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60068E1")]
	[Address(RVA = "0xBC6470", Offset = "0xBC5870", VA = "0x180BC6470", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
