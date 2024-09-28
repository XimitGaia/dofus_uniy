using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200041F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagEditRequest : IMessage<HavenBagEditRequest>, IMessage, IEquatable<HavenBagEditRequest>, IDeepCloneable<HavenBagEditRequest>, IBufferMessage
{
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagEditRequest> _parser;

	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000959")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagEditRequest> Parser
	{
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x9B9EC0", Offset = "0x9B92C0", VA = "0x1809B9EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B86")]
		[Address(RVA = "0x9B9E10", Offset = "0x9B9210", VA = "0x1809B9E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x9B9F10", Offset = "0x9B9310", VA = "0x1809B9F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B88")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEditRequest()
	{
	}

	[Token(Token = "0x6002B89")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagEditRequest(HavenBagEditRequest other)
	{
	}

	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x9B9BB0", Offset = "0x9B8FB0", VA = "0x1809B9BB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x9B9C30", Offset = "0x9B9030", VA = "0x1809B9C30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B8C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagEditRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B8D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B8E")]
	[Address(RVA = "0x9B9CB0", Offset = "0x9B90B0", VA = "0x1809B9CB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B8F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B90")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B91")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HavenBagEditRequest other)
	{
	}

	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
