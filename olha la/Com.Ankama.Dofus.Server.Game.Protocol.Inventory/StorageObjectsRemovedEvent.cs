using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003DB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageObjectsRemovedEvent : IMessage<StorageObjectsRemovedEvent>, IMessage, IEquatable<StorageObjectsRemovedEvent>, IDeepCloneable<StorageObjectsRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageObjectsRemovedEvent> _parser;

	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D46")]
	public const int ObjectsUidFieldNumber = 1;

	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectsUid_codec;

	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectsUid_;

	[Token(Token = "0x1700089D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StorageObjectsRemovedEvent> Parser
	{
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x9AD800", Offset = "0x9ACC00", VA = "0x1809AD800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x9AD750", Offset = "0x9ACB50", VA = "0x1809AD750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x9ADA20", Offset = "0x9ACE20", VA = "0x1809ADA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectsUid
	{
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002859")]
	[Address(RVA = "0x9AD6D0", Offset = "0x9ACAD0", VA = "0x1809AD6D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectsRemovedEvent()
	{
	}

	[Token(Token = "0x600285A")]
	[Address(RVA = "0x9AD640", Offset = "0x9ACA40", VA = "0x1809AD640")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StorageObjectsRemovedEvent(StorageObjectsRemovedEvent other)
	{
	}

	[Token(Token = "0x600285B")]
	[Address(RVA = "0x9AD200", Offset = "0x9AC600", VA = "0x1809AD200", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectsRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600285D")]
	[Address(RVA = "0x9AD350", Offset = "0x9AC750", VA = "0x1809AD350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0x9AD2C0", Offset = "0x9AC6C0", VA = "0x1809AD2C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageObjectsRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0x9AD4B0", Offset = "0x9AC8B0", VA = "0x1809AD4B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002862")]
	[Address(RVA = "0x9AD970", Offset = "0x9ACD70", VA = "0x1809AD970", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x9AD160", Offset = "0x9AC560", VA = "0x1809AD160", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0x9AD430", Offset = "0x9AC830", VA = "0x1809AD430", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageObjectsRemovedEvent other)
	{
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0x9AD850", Offset = "0x9ACC50", VA = "0x1809AD850", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
