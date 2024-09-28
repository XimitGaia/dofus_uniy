using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002ED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayAnimationOnNpcEvent : IMessage<PlayAnimationOnNpcEvent>, IMessage, IEquatable<PlayAnimationOnNpcEvent>, IDeepCloneable<PlayAnimationOnNpcEvent>, IBufferMessage
{
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayAnimationOnNpcEvent> _parser;

	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A53")]
	public const int NpcIdFieldNumber = 1;

	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x18")]
	private int npcId_;

	[Token(Token = "0x4000A55")]
	public const int AnimationFieldNumber = 2;

	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x20")]
	private string animation_;

	[Token(Token = "0x17000692")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayAnimationOnNpcEvent> Parser
	{
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0xD2C730", Offset = "0xD2BB30", VA = "0x180D2C730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000693")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0xD2C680", Offset = "0xD2BA80", VA = "0x180D2C680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000694")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0xD2C850", Offset = "0xD2BC50", VA = "0x180D2C850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000695")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NpcId
	{
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000696")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Animation
	{
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0xD2C930", Offset = "0xD2BD30", VA = "0x180D2C930")]
		set
		{
		}
	}

	[Token(Token = "0x6001E67")]
	[Address(RVA = "0xD2C580", Offset = "0xD2B980", VA = "0x180D2C580")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayAnimationOnNpcEvent()
	{
	}

	[Token(Token = "0x6001E68")]
	[Address(RVA = "0xD2C5D0", Offset = "0xD2B9D0", VA = "0x180D2C5D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayAnimationOnNpcEvent(PlayAnimationOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E69")]
	[Address(RVA = "0xD2C230", Offset = "0xD2B630", VA = "0x180D2C230", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayAnimationOnNpcEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0xD2C300", Offset = "0xD2B700", VA = "0x180D2C300", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayAnimationOnNpcEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E70")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E71")]
	[Address(RVA = "0xD2C420", Offset = "0xD2B820", VA = "0x180D2C420", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E73")]
	[Address(RVA = "0xB789B0", Offset = "0xB77DB0", VA = "0x180B789B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E74")]
	[Address(RVA = "0xD2C170", Offset = "0xD2B570", VA = "0x180D2C170", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E75")]
	[Address(RVA = "0xD2C3B0", Offset = "0xD2B7B0", VA = "0x180D2C3B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayAnimationOnNpcEvent other)
	{
	}

	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E77")]
	[Address(RVA = "0xD2C780", Offset = "0xD2BB80", VA = "0x180D2C780", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
