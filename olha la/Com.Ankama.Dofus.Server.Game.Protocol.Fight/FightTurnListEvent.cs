using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005EB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnListEvent : IMessage<FightTurnListEvent>, IMessage, IEquatable<FightTurnListEvent>, IDeepCloneable<FightTurnListEvent>, IBufferMessage
{
	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnListEvent> _parser;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014BA")]
	public const int IdsFieldNumber = 1;

	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_ids_codec;

	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<long> ids_;

	[Token(Token = "0x40014BD")]
	public const int SlainFieldNumber = 2;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<long> _repeated_slain_codec;

	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<long> slain_;

	[Token(Token = "0x17000D93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTurnListEvent> Parser
	{
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0xA4E040", Offset = "0xA4D440", VA = "0x180A4E040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0xA4DF90", Offset = "0xA4D390", VA = "0x180A4DF90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D95")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0xA4E2D0", Offset = "0xA4D6D0", VA = "0x180A4E2D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D96")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> Ids
	{
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Slain
	{
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F38")]
	[Address(RVA = "0xA4DEE0", Offset = "0xA4D2E0", VA = "0x180A4DEE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnListEvent()
	{
	}

	[Token(Token = "0x6003F39")]
	[Address(RVA = "0xA4DE30", Offset = "0xA4D230", VA = "0x180A4DE30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnListEvent(FightTurnListEvent other)
	{
	}

	[Token(Token = "0x6003F3A")]
	[Address(RVA = "0xA4D950", Offset = "0xA4CD50", VA = "0x180A4D950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0xA4DAE0", Offset = "0xA4CEE0", VA = "0x180A4DAE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0xA4DA30", Offset = "0xA4CE30", VA = "0x180A4DA30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTurnListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F40")]
	[Address(RVA = "0xA4DC70", Offset = "0xA4D070", VA = "0x180A4DC70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F42")]
	[Address(RVA = "0xA4E1F0", Offset = "0xA4D5F0", VA = "0x180A4E1F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F43")]
	[Address(RVA = "0xA4D870", Offset = "0xA4CC70", VA = "0x180A4D870", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0xA4DBD0", Offset = "0xA4CFD0", VA = "0x180A4DBD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTurnListEvent other)
	{
	}

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F46")]
	[Address(RVA = "0xA4E090", Offset = "0xA4D490", VA = "0x180A4E090", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
