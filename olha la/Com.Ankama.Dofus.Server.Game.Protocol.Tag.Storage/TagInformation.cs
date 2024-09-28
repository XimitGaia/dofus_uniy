using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000E1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TagInformation : IMessage<TagInformation>, IMessage, IEquatable<TagInformation>, IDeepCloneable<TagInformation>, IBufferMessage
{
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TagInformation> _parser;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002FE")]
	public const int TagStorageDataFieldNumber = 1;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x18")]
	private TagStorageData tagStorageData_;

	[Token(Token = "0x4000300")]
	public const int TagObjectDataFieldNumber = 2;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x20")]
	private TagObjectData tagObjectData_;

	[Token(Token = "0x170001D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TagInformation> Parser
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xA5E5F0", Offset = "0xA5D9F0", VA = "0x180A5E5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xA5E540", Offset = "0xA5D940", VA = "0x180A5E540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xA5E790", Offset = "0xA5DB90", VA = "0x180A5E790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagStorageData TagStorageData
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170001DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagObjectData TagObjectData
	{
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagInformation()
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0xA5E400", Offset = "0xA5D800", VA = "0x180A5E400")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagInformation(TagInformation other)
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0xA5DE80", Offset = "0xA5D280", VA = "0x180A5DE80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0xA5DFF0", Offset = "0xA5D3F0", VA = "0x180A5DFF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TagInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0xA5E2A0", Offset = "0xA5D6A0", VA = "0x180A5E2A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0xA5DDC0", Offset = "0xA5D1C0", VA = "0x180A5DDC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0xA5E0B0", Offset = "0xA5D4B0", VA = "0x180A5E0B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TagInformation other)
	{
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0xA5E640", Offset = "0xA5DA40", VA = "0x180A5E640", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
