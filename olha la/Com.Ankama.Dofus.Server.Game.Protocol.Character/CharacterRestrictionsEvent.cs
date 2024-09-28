using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000881")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterRestrictionsEvent : IMessage<CharacterRestrictionsEvent>, IMessage, IEquatable<CharacterRestrictionsEvent>, IDeepCloneable<CharacterRestrictionsEvent>, IBufferMessage
{
	[Token(Token = "0x4001D72")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterRestrictionsEvent> _parser;

	[Token(Token = "0x4001D73")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D74")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001D75")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001D76")]
	public const int RestrictionsFieldNumber = 2;

	[Token(Token = "0x4001D77")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Restriction> _repeated_restrictions_codec;

	[Token(Token = "0x4001D78")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Restriction> restrictions_;

	[Token(Token = "0x17001339")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterRestrictionsEvent> Parser
	{
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0xB244A0", Offset = "0xB238A0", VA = "0x180B244A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A50")]
		[Address(RVA = "0xB243F0", Offset = "0xB237F0", VA = "0x180B243F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A51")]
		[Address(RVA = "0xB246F0", Offset = "0xB23AF0", VA = "0x180B246F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700133D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Restriction> Restrictions
	{
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005A52")]
	[Address(RVA = "0xB24370", Offset = "0xB23770", VA = "0x180B24370")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterRestrictionsEvent()
	{
	}

	[Token(Token = "0x6005A53")]
	[Address(RVA = "0xB242D0", Offset = "0xB236D0", VA = "0x180B242D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterRestrictionsEvent(CharacterRestrictionsEvent other)
	{
	}

	[Token(Token = "0x6005A54")]
	[Address(RVA = "0xB23DB0", Offset = "0xB231B0", VA = "0x180B23DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterRestrictionsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A58")]
	[Address(RVA = "0xB23F10", Offset = "0xB23310", VA = "0x180B23F10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A59")]
	[Address(RVA = "0xB23E70", Offset = "0xB23270", VA = "0x180B23E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterRestrictionsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A5A")]
	[Address(RVA = "0x97D020", Offset = "0x97C420", VA = "0x18097D020", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A5B")]
	[Address(RVA = "0xB24080", Offset = "0xB23480", VA = "0x180B24080", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A5C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A5D")]
	[Address(RVA = "0xB24620", Offset = "0xB23A20", VA = "0x180B24620", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A5E")]
	[Address(RVA = "0xB23CD0", Offset = "0xB230D0", VA = "0x180B23CD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A5F")]
	[Address(RVA = "0xB23FF0", Offset = "0xB233F0", VA = "0x180B23FF0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterRestrictionsEvent other)
	{
	}

	[Token(Token = "0x6005A60")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A61")]
	[Address(RVA = "0xB244F0", Offset = "0xB238F0", VA = "0x180B244F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
