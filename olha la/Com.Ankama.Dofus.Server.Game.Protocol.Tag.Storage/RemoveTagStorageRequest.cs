using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000CD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveTagStorageRequest : IMessage<RemoveTagStorageRequest>, IMessage, IEquatable<RemoveTagStorageRequest>, IDeepCloneable<RemoveTagStorageRequest>, IBufferMessage
{
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveTagStorageRequest> _parser;

	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002C5")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x170001AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RemoveTagStorageRequest> Parser
	{
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xA5A8F0", Offset = "0xA59CF0", VA = "0x180A5A8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xA5A840", Offset = "0xA59C40", VA = "0x180A5A840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xA5AA00", Offset = "0xA59E00", VA = "0x180A5AA00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TagStorageUuid
	{
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xA5AAE0", Offset = "0xA59EE0", VA = "0x180A5AAE0")]
		set
		{
		}
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0xA5A7F0", Offset = "0xA59BF0", VA = "0x180A5A7F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagStorageRequest()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0xA5A750", Offset = "0xA59B50", VA = "0x180A5A750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagStorageRequest(RemoveTagStorageRequest other)
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0xA5A410", Offset = "0xA59810", VA = "0x180A5A410", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagStorageRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0xA5A4E0", Offset = "0xA598E0", VA = "0x180A5A4E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RemoveTagStorageRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0xA5A5F0", Offset = "0xA599F0", VA = "0x180A5A5F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0xA5A380", Offset = "0xA59780", VA = "0x180A5A380", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0xA5A590", Offset = "0xA59990", VA = "0x180A5A590", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveTagStorageRequest other)
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0xA5A940", Offset = "0xA59D40", VA = "0x180A5A940", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
