using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000CF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveTagStorageResponse : IMessage<RemoveTagStorageResponse>, IMessage, IEquatable<RemoveTagStorageResponse>, IDeepCloneable<RemoveTagStorageResponse>, IBufferMessage
{
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveTagStorageResponse> _parser;

	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002CA")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x170001B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RemoveTagStorageResponse> Parser
	{
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xA5B0C0", Offset = "0xA5A4C0", VA = "0x180A5B0C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xA5B010", Offset = "0xA5A410", VA = "0x180A5B010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xA5B1D0", Offset = "0xA5A5D0", VA = "0x180A5B1D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TagStorageUuid
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xA5B2B0", Offset = "0xA5A6B0", VA = "0x180A5B2B0")]
		set
		{
		}
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xA5AFC0", Offset = "0xA5A3C0", VA = "0x180A5AFC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagStorageResponse()
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xA5AF20", Offset = "0xA5A320", VA = "0x180A5AF20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveTagStorageResponse(RemoveTagStorageResponse other)
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xA5ABE0", Offset = "0xA59FE0", VA = "0x180A5ABE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveTagStorageResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xA5ACB0", Offset = "0xA5A0B0", VA = "0x180A5ACB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RemoveTagStorageResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xA5ADC0", Offset = "0xA5A1C0", VA = "0x180A5ADC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xA5AB50", Offset = "0xA59F50", VA = "0x180A5AB50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0xA5AD60", Offset = "0xA5A160", VA = "0x180A5AD60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveTagStorageResponse other)
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0xA5B110", Offset = "0xA5A510", VA = "0x180A5B110", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
