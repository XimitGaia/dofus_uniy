using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateTagStorageContentResponse : IMessage<UpdateTagStorageContentResponse>, IMessage, IEquatable<UpdateTagStorageContentResponse>, IDeepCloneable<UpdateTagStorageContentResponse>, IBufferMessage
{
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UpdateTagStorageContentResponse> _parser;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002F3")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x170001CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateTagStorageContentResponse> Parser
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0xA6D620", Offset = "0xA6CA20", VA = "0x180A6D620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000886")]
		[Address(RVA = "0xA6D570", Offset = "0xA6C970", VA = "0x180A6D570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000887")]
		[Address(RVA = "0xA6D730", Offset = "0xA6CB30", VA = "0x180A6D730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TagStorageUuid
	{
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600088C")]
		[Address(RVA = "0xA6D810", Offset = "0xA6CC10", VA = "0x180A6D810")]
		set
		{
		}
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0xA6D480", Offset = "0xA6C880", VA = "0x180A6D480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTagStorageContentResponse()
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0xA6D4D0", Offset = "0xA6C8D0", VA = "0x180A6D4D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTagStorageContentResponse(UpdateTagStorageContentResponse other)
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UpdateTagStorageContentResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0xA6D210", Offset = "0xA6C610", VA = "0x180A6D210", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateTagStorageContentResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0xA6D320", Offset = "0xA6C720", VA = "0x180A6D320", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0xA6D0B0", Offset = "0xA6C4B0", VA = "0x180A6D0B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0xA6D2C0", Offset = "0xA6C6C0", VA = "0x180A6D2C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(UpdateTagStorageContentResponse other)
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0xA6D670", Offset = "0xA6CA70", VA = "0x180A6D670", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
