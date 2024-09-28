using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B34")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DateRequest : IMessage<DateRequest>, IMessage, IEquatable<DateRequest>, IDeepCloneable<DateRequest>, IBufferMessage
{
	[Token(Token = "0x40029E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DateRequest> _parser;

	[Token(Token = "0x40029E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DateRequest> Parser
	{
		[Token(Token = "0x6007612")]
		[Address(RVA = "0xC24150", Offset = "0xC23550", VA = "0x180C24150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007613")]
		[Address(RVA = "0xC240A0", Offset = "0xC234A0", VA = "0x180C240A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007614")]
		[Address(RVA = "0xC241A0", Offset = "0xC235A0", VA = "0x180C241A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007615")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DateRequest()
	{
	}

	[Token(Token = "0x6007616")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DateRequest(DateRequest other)
	{
	}

	[Token(Token = "0x6007617")]
	[Address(RVA = "0xC23E40", Offset = "0xC23240", VA = "0x180C23E40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007618")]
	[Address(RVA = "0xC23EC0", Offset = "0xC232C0", VA = "0x180C23EC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007619")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600761A")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600761B")]
	[Address(RVA = "0xC23F40", Offset = "0xC23340", VA = "0x180C23F40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600761C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600761D")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600761E")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600761F")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DateRequest other)
	{
	}

	[Token(Token = "0x6007620")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007621")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
