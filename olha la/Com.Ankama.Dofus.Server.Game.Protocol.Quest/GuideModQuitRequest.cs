using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200018D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuideModQuitRequest : IMessage<GuideModQuitRequest>, IMessage, IEquatable<GuideModQuitRequest>, IDeepCloneable<GuideModQuitRequest>, IBufferMessage
{
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuideModQuitRequest> _parser;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000357")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuideModQuitRequest> Parser
	{
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0xC45F80", Offset = "0xC45380", VA = "0x180C45F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000358")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0xC45ED0", Offset = "0xC452D0", VA = "0x180C45ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000359")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0xC45FD0", Offset = "0xC453D0", VA = "0x180C45FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideModQuitRequest()
	{
	}

	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuideModQuitRequest(GuideModQuitRequest other)
	{
	}

	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0xC45C70", Offset = "0xC45070", VA = "0x180C45C70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuideModQuitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0xC45CF0", Offset = "0xC450F0", VA = "0x180C45CF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuideModQuitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0xC45D70", Offset = "0xC45170", VA = "0x180C45D70", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuideModQuitRequest other)
	{
	}

	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
