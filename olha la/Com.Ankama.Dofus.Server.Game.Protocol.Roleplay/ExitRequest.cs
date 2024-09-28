using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000168")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExitRequest : IMessage<ExitRequest>, IMessage, IEquatable<ExitRequest>, IDeepCloneable<ExitRequest>, IBufferMessage
{
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExitRequest> _parser;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170002FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExitRequest> Parser
	{
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0xC444E0", Offset = "0xC438E0", VA = "0x180C444E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0xC44430", Offset = "0xC43830", VA = "0x180C44430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0xC44530", Offset = "0xC43930", VA = "0x180C44530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExitRequest()
	{
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExitRequest(ExitRequest other)
	{
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0xC441D0", Offset = "0xC435D0", VA = "0x180C441D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0xC44250", Offset = "0xC43650", VA = "0x180C44250", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0xC442D0", Offset = "0xC436D0", VA = "0x180C442D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExitRequest other)
	{
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
