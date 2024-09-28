using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000421")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagEditCancelRequest : IMessage<HavenBagEditCancelRequest>, IMessage, IEquatable<HavenBagEditCancelRequest>, IDeepCloneable<HavenBagEditCancelRequest>, IBufferMessage
{
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagEditCancelRequest> _parser;

	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700095C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagEditCancelRequest> Parser
	{
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x9B9640", Offset = "0x9B8A40", VA = "0x1809B9640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x9B9590", Offset = "0x9B8990", VA = "0x1809B9590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x9B9690", Offset = "0x9B8A90", VA = "0x1809B9690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditCancelRequest()
	{
	}

	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditCancelRequest(HavenBagEditCancelRequest other)
	{
	}

	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x9B9330", Offset = "0x9B8730", VA = "0x1809B9330", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagEditCancelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B9F")]
	[Address(RVA = "0x9B93B0", Offset = "0x9B87B0", VA = "0x1809B93B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagEditCancelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x9B9430", Offset = "0x9B8830", VA = "0x1809B9430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HavenBagEditCancelRequest other)
	{
	}

	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
