using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200041D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagExitRequest : IMessage<HavenBagExitRequest>, IMessage, IEquatable<HavenBagExitRequest>, IDeepCloneable<HavenBagExitRequest>, IBufferMessage
{
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagExitRequest> _parser;

	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000956")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagExitRequest> Parser
	{
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x9BAC20", Offset = "0x9BA020", VA = "0x1809BAC20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000957")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x9BAB70", Offset = "0x9B9F70", VA = "0x1809BAB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000958")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x9BAC70", Offset = "0x9BA070", VA = "0x1809BAC70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagExitRequest()
	{
	}

	[Token(Token = "0x6002B75")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagExitRequest(HavenBagExitRequest other)
	{
	}

	[Token(Token = "0x6002B76")]
	[Address(RVA = "0x9BA910", Offset = "0x9B9D10", VA = "0x1809BA910", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagExitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B77")]
	[Address(RVA = "0x9BA990", Offset = "0x9B9D90", VA = "0x1809BA990", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B78")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagExitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B79")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B7A")]
	[Address(RVA = "0x9BAA10", Offset = "0x9B9E10", VA = "0x1809BAA10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B7B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B7C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagExitRequest other)
	{
	}

	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
