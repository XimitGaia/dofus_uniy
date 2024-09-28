using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CB7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFactsRequest : IMessage<AllianceFactsRequest>, IMessage, IEquatable<AllianceFactsRequest>, IDeepCloneable<AllianceFactsRequest>, IBufferMessage
{
	[Token(Token = "0x4002EC8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFactsRequest> _parser;

	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002ECA")]
	public const int AllianceUuidFieldNumber = 1;

	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x18")]
	private string allianceUuid_;

	[Token(Token = "0x17001D48")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFactsRequest> Parser
	{
		[Token(Token = "0x60085F3")]
		[Address(RVA = "0xC8F670", Offset = "0xC8EA70", VA = "0x180C8F670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D49")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60085F4")]
		[Address(RVA = "0xC8F5C0", Offset = "0xC8E9C0", VA = "0x180C8F5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D4A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60085F5")]
		[Address(RVA = "0xC8F780", Offset = "0xC8EB80", VA = "0x180C8F780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D4B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceUuid
	{
		[Token(Token = "0x60085F9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085FA")]
		[Address(RVA = "0xC8F860", Offset = "0xC8EC60", VA = "0x180C8F860")]
		set
		{
		}
	}

	[Token(Token = "0x60085F6")]
	[Address(RVA = "0xC8F570", Offset = "0xC8E970", VA = "0x180C8F570")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFactsRequest()
	{
	}

	[Token(Token = "0x60085F7")]
	[Address(RVA = "0xC8F4D0", Offset = "0xC8E8D0", VA = "0x180C8F4D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFactsRequest(AllianceFactsRequest other)
	{
	}

	[Token(Token = "0x60085F8")]
	[Address(RVA = "0xC8F190", Offset = "0xC8E590", VA = "0x180C8F190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFactsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60085FB")]
	[Address(RVA = "0xC8F260", Offset = "0xC8E660", VA = "0x180C8F260", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085FC")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFactsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085FD")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60085FE")]
	[Address(RVA = "0xC8F370", Offset = "0xC8E770", VA = "0x180C8F370", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60085FF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008600")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008601")]
	[Address(RVA = "0xC8F100", Offset = "0xC8E500", VA = "0x180C8F100", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008602")]
	[Address(RVA = "0xC8F310", Offset = "0xC8E710", VA = "0x180C8F310", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceFactsRequest other)
	{
	}

	[Token(Token = "0x6008603")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008604")]
	[Address(RVA = "0xC8F6C0", Offset = "0xC8EAC0", VA = "0x180C8F6C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
