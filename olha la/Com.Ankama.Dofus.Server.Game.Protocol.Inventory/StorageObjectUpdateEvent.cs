using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003D5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageObjectUpdateEvent : IMessage<StorageObjectUpdateEvent>, IMessage, IEquatable<StorageObjectUpdateEvent>, IDeepCloneable<StorageObjectUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageObjectUpdateEvent> _parser;

	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D36")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItemInventory object_;

	[Token(Token = "0x17000891")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StorageObjectUpdateEvent> Parser
	{
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x9ACF30", Offset = "0x9AC330", VA = "0x1809ACF30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000892")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x9ACE80", Offset = "0x9AC280", VA = "0x1809ACE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000893")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x9AD080", Offset = "0x9AC480", VA = "0x1809AD080", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000894")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectUpdateEvent()
	{
	}

	[Token(Token = "0x6002819")]
	[Address(RVA = "0x990EB0", Offset = "0x9902B0", VA = "0x180990EB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectUpdateEvent(StorageObjectUpdateEvent other)
	{
	}

	[Token(Token = "0x600281A")]
	[Address(RVA = "0x9ACB00", Offset = "0x9ABF00", VA = "0x1809ACB00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0x9ACBA0", Offset = "0x9ABFA0", VA = "0x1809ACBA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageObjectUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600281F")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002820")]
	[Address(RVA = "0x9ACD20", Offset = "0x9AC120", VA = "0x1809ACD20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002821")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002822")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0x9ACA70", Offset = "0x9ABE70", VA = "0x1809ACA70", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002824")]
	[Address(RVA = "0x9ACC50", Offset = "0x9AC050", VA = "0x1809ACC50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageObjectUpdateEvent other)
	{
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0x9ACF80", Offset = "0x9AC380", VA = "0x1809ACF80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
