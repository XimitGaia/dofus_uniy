using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001B9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismRecycleRequest : IMessage<PrismRecycleRequest>, IMessage, IEquatable<PrismRecycleRequest>, IDeepCloneable<PrismRecycleRequest>, IBufferMessage
{
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismRecycleRequest> _parser;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170003B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrismRecycleRequest> Parser
	{
		[Token(Token = "0x6001174")]
		[Address(RVA = "0xCD08A0", Offset = "0xCCFCA0", VA = "0x180CD08A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001175")]
		[Address(RVA = "0xCD07F0", Offset = "0xCCFBF0", VA = "0x180CD07F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001176")]
		[Address(RVA = "0xCD08F0", Offset = "0xCCFCF0", VA = "0x180CD08F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismRecycleRequest()
	{
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismRecycleRequest(PrismRecycleRequest other)
	{
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0xCD0590", Offset = "0xCCF990", VA = "0x180CD0590", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismRecycleRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0xCD0610", Offset = "0xCCFA10", VA = "0x180CD0610", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismRecycleRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0xCD0690", Offset = "0xCCFA90", VA = "0x180CD0690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600117F")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001180")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismRecycleRequest other)
	{
	}

	[Token(Token = "0x6001182")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001183")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
