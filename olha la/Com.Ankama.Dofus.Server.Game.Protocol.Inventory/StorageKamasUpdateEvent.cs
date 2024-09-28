using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003D3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageKamasUpdateEvent : IMessage<StorageKamasUpdateEvent>, IMessage, IEquatable<StorageKamasUpdateEvent>, IDeepCloneable<StorageKamasUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageKamasUpdateEvent> _parser;

	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D31")]
	public const int KamasFieldNumber = 1;

	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x18")]
	private long kamas_;

	[Token(Token = "0x1700088D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StorageKamasUpdateEvent> Parser
	{
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x9AC460", Offset = "0x9AB860", VA = "0x1809AC460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x9AC3B0", Offset = "0x9AB7B0", VA = "0x1809AC3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x9AC4B0", Offset = "0x9AB8B0", VA = "0x1809AC4B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000890")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6002802")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageKamasUpdateEvent()
	{
	}

	[Token(Token = "0x6002803")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StorageKamasUpdateEvent(StorageKamasUpdateEvent other)
	{
	}

	[Token(Token = "0x6002804")]
	[Address(RVA = "0x9AC140", Offset = "0x9AB540", VA = "0x1809AC140", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageKamasUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002807")]
	[Address(RVA = "0x9AC1C0", Offset = "0x9AB5C0", VA = "0x1809AC1C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002808")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageKamasUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002809")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600280A")]
	[Address(RVA = "0x9AC250", Offset = "0x9AB650", VA = "0x1809AC250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600280B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600280C")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600280D")]
	[Address(RVA = "0x9AC0B0", Offset = "0x9AB4B0", VA = "0x1809AC0B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600280E")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageKamasUpdateEvent other)
	{
	}

	[Token(Token = "0x600280F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002810")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
