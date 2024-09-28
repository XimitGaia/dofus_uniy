using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation;

[Token(Token = "0x200033B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PopupWarningClosedEvent : IMessage<PopupWarningClosedEvent>, IMessage, IEquatable<PopupWarningClosedEvent>, IDeepCloneable<PopupWarningClosedEvent>, IBufferMessage
{
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PopupWarningClosedEvent> _parser;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000728")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PopupWarningClosedEvent> Parser
	{
		[Token(Token = "0x6002168")]
		[Address(RVA = "0x97DEC0", Offset = "0x97D2C0", VA = "0x18097DEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000729")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002169")]
		[Address(RVA = "0x97DE10", Offset = "0x97D210", VA = "0x18097DE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x97DF10", Offset = "0x97D310", VA = "0x18097DF10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600216B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningClosedEvent()
	{
	}

	[Token(Token = "0x600216C")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningClosedEvent(PopupWarningClosedEvent other)
	{
	}

	[Token(Token = "0x600216D")]
	[Address(RVA = "0x97DBB0", Offset = "0x97CFB0", VA = "0x18097DBB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningClosedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600216E")]
	[Address(RVA = "0x97DC30", Offset = "0x97D030", VA = "0x18097DC30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600216F")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PopupWarningClosedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002170")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002171")]
	[Address(RVA = "0x97DCB0", Offset = "0x97D0B0", VA = "0x18097DCB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002172")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002173")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002174")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002175")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PopupWarningClosedEvent other)
	{
	}

	[Token(Token = "0x6002176")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002177")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
