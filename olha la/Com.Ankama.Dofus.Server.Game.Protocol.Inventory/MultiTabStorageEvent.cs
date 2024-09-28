using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003CF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MultiTabStorageEvent : IMessage<MultiTabStorageEvent>, IMessage, IEquatable<MultiTabStorageEvent>, IDeepCloneable<MultiTabStorageEvent>, IBufferMessage
{
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MultiTabStorageEvent> _parser;

	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D23")]
	public const int TabsFieldNumber = 1;

	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<StorageTab> _repeated_tabs_codec;

	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<StorageTab> tabs_;

	[Token(Token = "0x17000884")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MultiTabStorageEvent> Parser
	{
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x9A87B0", Offset = "0x9A7BB0", VA = "0x1809A87B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000885")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x9A8700", Offset = "0x9A7B00", VA = "0x1809A8700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000886")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x9A89C0", Offset = "0x9A7DC0", VA = "0x1809A89C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000887")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<StorageTab> Tabs
	{
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027D6")]
	[Address(RVA = "0x9A85F0", Offset = "0x9A79F0", VA = "0x1809A85F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MultiTabStorageEvent()
	{
	}

	[Token(Token = "0x60027D7")]
	[Address(RVA = "0x9A8670", Offset = "0x9A7A70", VA = "0x1809A8670")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MultiTabStorageEvent(MultiTabStorageEvent other)
	{
	}

	[Token(Token = "0x60027D8")]
	[Address(RVA = "0x9A8140", Offset = "0x9A7540", VA = "0x1809A8140", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MultiTabStorageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60027DA")]
	[Address(RVA = "0x9A8200", Offset = "0x9A7600", VA = "0x1809A8200", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027DB")]
	[Address(RVA = "0x9A82E0", Offset = "0x9A76E0", VA = "0x1809A82E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MultiTabStorageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x9A83F0", Offset = "0x9A77F0", VA = "0x1809A83F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x9A8910", Offset = "0x9A7D10", VA = "0x1809A8910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x9A80A0", Offset = "0x9A74A0", VA = "0x1809A80A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x9A8370", Offset = "0x9A7770", VA = "0x1809A8370", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MultiTabStorageEvent other)
	{
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x9A8800", Offset = "0x9A7C00", VA = "0x1809A8800", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
