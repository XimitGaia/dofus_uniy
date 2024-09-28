using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CFD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NuggetsListenStartRequest : IMessage<NuggetsListenStartRequest>, IMessage, IEquatable<NuggetsListenStartRequest>, IDeepCloneable<NuggetsListenStartRequest>, IBufferMessage
{
	[Token(Token = "0x4002FC7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NuggetsListenStartRequest> _parser;

	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001DE9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NuggetsListenStartRequest> Parser
	{
		[Token(Token = "0x60088DB")]
		[Address(RVA = "0xCB5E70", Offset = "0xCB5270", VA = "0x180CB5E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DEA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60088DC")]
		[Address(RVA = "0xCB5DC0", Offset = "0xCB51C0", VA = "0x180CB5DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DEB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60088DD")]
		[Address(RVA = "0xCB5EC0", Offset = "0xCB52C0", VA = "0x180CB5EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60088DE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NuggetsListenStartRequest()
	{
	}

	[Token(Token = "0x60088DF")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsListenStartRequest(NuggetsListenStartRequest other)
	{
	}

	[Token(Token = "0x60088E0")]
	[Address(RVA = "0xCB5B60", Offset = "0xCB4F60", VA = "0x180CB5B60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsListenStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60088E1")]
	[Address(RVA = "0xCB5BE0", Offset = "0xCB4FE0", VA = "0x180CB5BE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088E2")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NuggetsListenStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088E3")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60088E4")]
	[Address(RVA = "0xCB5C60", Offset = "0xCB5060", VA = "0x180CB5C60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60088E5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60088E6")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60088E7")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60088E8")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NuggetsListenStartRequest other)
	{
	}

	[Token(Token = "0x60088E9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60088EA")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
