using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x200082A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientIdRequest : IMessage<ClientIdRequest>, IMessage, IEquatable<ClientIdRequest>, IDeepCloneable<ClientIdRequest>, IBufferMessage
{
	[Token(Token = "0x4001C28")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ClientIdRequest> _parser;

	[Token(Token = "0x4001C29")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C2A")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4001C2B")]
	[FieldOffset(Offset = "0x18")]
	private string id_;

	[Token(Token = "0x17001273")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientIdRequest> Parser
	{
		[Token(Token = "0x60056B4")]
		[Address(RVA = "0xB08E60", Offset = "0xB08260", VA = "0x180B08E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001274")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60056B5")]
		[Address(RVA = "0xB08DB0", Offset = "0xB081B0", VA = "0x180B08DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001275")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60056B6")]
		[Address(RVA = "0xB08F70", Offset = "0xB08370", VA = "0x180B08F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001276")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Id
	{
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0xB09050", Offset = "0xB08450", VA = "0x180B09050")]
		set
		{
		}
	}

	[Token(Token = "0x60056B7")]
	[Address(RVA = "0xB08CC0", Offset = "0xB080C0", VA = "0x180B08CC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientIdRequest()
	{
	}

	[Token(Token = "0x60056B8")]
	[Address(RVA = "0xB08D10", Offset = "0xB08110", VA = "0x180B08D10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientIdRequest(ClientIdRequest other)
	{
	}

	[Token(Token = "0x60056B9")]
	[Address(RVA = "0xB08980", Offset = "0xB07D80", VA = "0x180B08980", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientIdRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60056BC")]
	[Address(RVA = "0xB08A50", Offset = "0xB07E50", VA = "0x180B08A50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056BD")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientIdRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056BE")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60056BF")]
	[Address(RVA = "0xB08B60", Offset = "0xB07F60", VA = "0x180B08B60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60056C0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60056C1")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60056C2")]
	[Address(RVA = "0xB088F0", Offset = "0xB07CF0", VA = "0x180B088F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60056C3")]
	[Address(RVA = "0xB08B00", Offset = "0xB07F00", VA = "0x180B08B00", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ClientIdRequest other)
	{
	}

	[Token(Token = "0x60056C4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60056C5")]
	[Address(RVA = "0xB08EB0", Offset = "0xB082B0", VA = "0x180B08EB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
