using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000693")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftCountModifiedEvent : IMessage<ExchangeCraftCountModifiedEvent>, IMessage, IEquatable<ExchangeCraftCountModifiedEvent>, IDeepCloneable<ExchangeCraftCountModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x40016FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftCountModifiedEvent> _parser;

	[Token(Token = "0x40016FD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016FE")]
	public const int CountFieldNumber = 1;

	[Token(Token = "0x40016FF")]
	[FieldOffset(Offset = "0x18")]
	private int count_;

	[Token(Token = "0x17000F0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeCraftCountModifiedEvent> Parser
	{
		[Token(Token = "0x600467C")]
		[Address(RVA = "0xA88F50", Offset = "0xA88350", VA = "0x180A88F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600467D")]
		[Address(RVA = "0xA88EA0", Offset = "0xA882A0", VA = "0x180A88EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600467E")]
		[Address(RVA = "0xA88FA0", Offset = "0xA883A0", VA = "0x180A88FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600467F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftCountModifiedEvent()
	{
	}

	[Token(Token = "0x6004680")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftCountModifiedEvent(ExchangeCraftCountModifiedEvent other)
	{
	}

	[Token(Token = "0x6004681")]
	[Address(RVA = "0xA88C30", Offset = "0xA88030", VA = "0x180A88C30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftCountModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004684")]
	[Address(RVA = "0xA88CB0", Offset = "0xA880B0", VA = "0x180A88CB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004685")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeCraftCountModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004686")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004687")]
	[Address(RVA = "0xA88D40", Offset = "0xA88140", VA = "0x180A88D40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004688")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004689")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600468A")]
	[Address(RVA = "0xA88BA0", Offset = "0xA87FA0", VA = "0x180A88BA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600468B")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeCraftCountModifiedEvent other)
	{
	}

	[Token(Token = "0x600468C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600468D")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
