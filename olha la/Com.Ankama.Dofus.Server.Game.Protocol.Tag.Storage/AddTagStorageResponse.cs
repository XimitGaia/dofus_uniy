using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000CB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddTagStorageResponse : IMessage<AddTagStorageResponse>, IMessage, IEquatable<AddTagStorageResponse>, IDeepCloneable<AddTagStorageResponse>, IBufferMessage
{
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AddTagStorageResponse> _parser;

	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002C0")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x170001A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddTagStorageResponse> Parser
	{
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xA579B0", Offset = "0xA56DB0", VA = "0x180A579B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xA57900", Offset = "0xA56D00", VA = "0x180A57900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xA57AC0", Offset = "0xA56EC0", VA = "0x180A57AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TagStorageUuid
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xA57BA0", Offset = "0xA56FA0", VA = "0x180A57BA0")]
		set
		{
		}
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0xA578B0", Offset = "0xA56CB0", VA = "0x180A578B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddTagStorageResponse()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0xA57810", Offset = "0xA56C10", VA = "0x180A57810")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagStorageResponse(AddTagStorageResponse other)
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0xA574D0", Offset = "0xA568D0", VA = "0x180A574D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagStorageResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0xA575A0", Offset = "0xA569A0", VA = "0x180A575A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddTagStorageResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0xA576B0", Offset = "0xA56AB0", VA = "0x180A576B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0xA57440", Offset = "0xA56840", VA = "0x180A57440", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0xA57650", Offset = "0xA56A50", VA = "0x180A57650", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AddTagStorageResponse other)
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0xA57A00", Offset = "0xA56E00", VA = "0x180A57A00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
