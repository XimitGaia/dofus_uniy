using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200018B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuideModReturnRequest : IMessage<GuideModReturnRequest>, IMessage, IEquatable<GuideModReturnRequest>, IDeepCloneable<GuideModReturnRequest>, IBufferMessage
{
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuideModReturnRequest> _parser;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000354")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuideModReturnRequest> Parser
	{
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0xC463C0", Offset = "0xC457C0", VA = "0x180C463C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000355")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0xC46310", Offset = "0xC45710", VA = "0x180C46310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000356")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0xC46410", Offset = "0xC45810", VA = "0x180C46410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideModReturnRequest()
	{
	}

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideModReturnRequest(GuideModReturnRequest other)
	{
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0xC460B0", Offset = "0xC454B0", VA = "0x180C460B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideModReturnRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0xC46130", Offset = "0xC45530", VA = "0x180C46130", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuideModReturnRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0xC461B0", Offset = "0xC455B0", VA = "0x180C461B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuideModReturnRequest other)
	{
	}

	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
