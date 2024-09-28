using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000E3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TagStorageData : IMessage<TagStorageData>, IMessage, IEquatable<TagStorageData>, IDeepCloneable<TagStorageData>, IBufferMessage
{
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TagStorageData> _parser;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000305")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x4000307")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4000309")]
	public const int PictoFieldNumber = 3;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x28")]
	private int picto_;

	[Token(Token = "0x170001DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TagStorageData> Parser
	{
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xA60240", Offset = "0xA5F640", VA = "0x180A60240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xA60190", Offset = "0xA5F590", VA = "0x180A60190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xA60450", Offset = "0xA5F850", VA = "0x180A60450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TagStorageUuid
	{
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xA605A0", Offset = "0xA5F9A0", VA = "0x180A605A0")]
		set
		{
		}
	}

	[Token(Token = "0x170001DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xA60530", Offset = "0xA5F930", VA = "0x180A60530")]
		set
		{
		}
	}

	[Token(Token = "0x170001E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Picto
	{
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0xA60040", Offset = "0xA5F440", VA = "0x180A60040")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagStorageData()
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0xA600B0", Offset = "0xA5F4B0", VA = "0x180A600B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagStorageData(TagStorageData other)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0xA5FB30", Offset = "0xA5EF30", VA = "0x180A5FB30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagStorageData Clone()
	{
		return null;
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0xA5FCC0", Offset = "0xA5F0C0", VA = "0x180A5FCC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0xA5FC40", Offset = "0xA5F040", VA = "0x180A5FC40", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TagStorageData other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0xA5FD90", Offset = "0xA5F190", VA = "0x180A5FD90", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0xA5FEE0", Offset = "0xA5F2E0", VA = "0x180A5FEE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0xA603A0", Offset = "0xA5F7A0", VA = "0x180A603A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0xA5FA40", Offset = "0xA5EE40", VA = "0x180A5FA40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0xA5FE50", Offset = "0xA5F250", VA = "0x180A5FE50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TagStorageData other)
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0xA60290", Offset = "0xA5F690", VA = "0x180A60290", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
