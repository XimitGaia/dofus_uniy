using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x200079D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RefreshMonsterBoostsEvent : IMessage<RefreshMonsterBoostsEvent>, IMessage, IEquatable<RefreshMonsterBoostsEvent>, IDeepCloneable<RefreshMonsterBoostsEvent>, IBufferMessage
{
	[Token(Token = "0x4001A7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RefreshMonsterBoostsEvent> _parser;

	[Token(Token = "0x4001A7F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A80")]
	public const int MonsterBoostsFieldNumber = 1;

	[Token(Token = "0x4001A81")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MonsterBoosts> _repeated_monsterBoosts_codec;

	[Token(Token = "0x4001A82")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<MonsterBoosts> monsterBoosts_;

	[Token(Token = "0x4001A83")]
	public const int FamilyBoostsFieldNumber = 2;

	[Token(Token = "0x4001A84")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<MonsterBoosts> _repeated_familyBoosts_codec;

	[Token(Token = "0x4001A85")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<MonsterBoosts> familyBoosts_;

	[Token(Token = "0x1700114C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RefreshMonsterBoostsEvent> Parser
	{
		[Token(Token = "0x6005108")]
		[Address(RVA = "0xAE07D0", Offset = "0xADFBD0", VA = "0x180AE07D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700114D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005109")]
		[Address(RVA = "0xAE0720", Offset = "0xADFB20", VA = "0x180AE0720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700114E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600510A")]
		[Address(RVA = "0xAE0A60", Offset = "0xADFE60", VA = "0x180AE0A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700114F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterBoosts> MonsterBoosts
	{
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterBoosts> FamilyBoosts
	{
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600510B")]
	[Address(RVA = "0xAE0670", Offset = "0xADFA70", VA = "0x180AE0670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshMonsterBoostsEvent()
	{
	}

	[Token(Token = "0x600510C")]
	[Address(RVA = "0xAE05C0", Offset = "0xADF9C0", VA = "0x180AE05C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshMonsterBoostsEvent(RefreshMonsterBoostsEvent other)
	{
	}

	[Token(Token = "0x600510D")]
	[Address(RVA = "0xAE0020", Offset = "0xADF420", VA = "0x180AE0020", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshMonsterBoostsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005110")]
	[Address(RVA = "0xAE01B0", Offset = "0xADF5B0", VA = "0x180AE01B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005111")]
	[Address(RVA = "0xAE0100", Offset = "0xADF500", VA = "0x180AE0100", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RefreshMonsterBoostsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005112")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005113")]
	[Address(RVA = "0xAE0340", Offset = "0xADF740", VA = "0x180AE0340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005114")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005115")]
	[Address(RVA = "0xAE0980", Offset = "0xADFD80", VA = "0x180AE0980", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005116")]
	[Address(RVA = "0xADFF40", Offset = "0xADF340", VA = "0x180ADFF40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005117")]
	[Address(RVA = "0xAE02A0", Offset = "0xADF6A0", VA = "0x180AE02A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RefreshMonsterBoostsEvent other)
	{
	}

	[Token(Token = "0x6005118")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005119")]
	[Address(RVA = "0xAE0820", Offset = "0xADFC20", VA = "0x180AE0820", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
