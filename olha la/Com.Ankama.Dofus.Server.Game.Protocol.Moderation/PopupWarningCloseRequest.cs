using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation;

[Token(Token = "0x2000337")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PopupWarningCloseRequest : IMessage<PopupWarningCloseRequest>, IMessage, IEquatable<PopupWarningCloseRequest>, IDeepCloneable<PopupWarningCloseRequest>, IBufferMessage
{
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PopupWarningCloseRequest> _parser;

	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700071F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PopupWarningCloseRequest> Parser
	{
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x97DA80", Offset = "0x97CE80", VA = "0x18097DA80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x97D9D0", Offset = "0x97CDD0", VA = "0x18097D9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000721")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x97DAD0", Offset = "0x97CED0", VA = "0x18097DAD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600213D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningCloseRequest()
	{
	}

	[Token(Token = "0x600213E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PopupWarningCloseRequest(PopupWarningCloseRequest other)
	{
	}

	[Token(Token = "0x600213F")]
	[Address(RVA = "0x97D770", Offset = "0x97CB70", VA = "0x18097D770", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PopupWarningCloseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002140")]
	[Address(RVA = "0x97D7F0", Offset = "0x97CBF0", VA = "0x18097D7F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002141")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PopupWarningCloseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002142")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002143")]
	[Address(RVA = "0x97D870", Offset = "0x97CC70", VA = "0x18097D870", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002144")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002145")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002146")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002147")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PopupWarningCloseRequest other)
	{
	}

	[Token(Token = "0x6002148")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002149")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
