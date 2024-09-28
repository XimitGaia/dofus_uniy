using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageObjectsUpdateEvent : IMessage<StorageObjectsUpdateEvent>, IMessage, IEquatable<StorageObjectsUpdateEvent>, IDeepCloneable<StorageObjectsUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageObjectsUpdateEvent> _parser;

	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D3B")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x17000895")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StorageObjectsUpdateEvent> Parser
	{
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x9AE210", Offset = "0x9AD610", VA = "0x1809AE210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000896")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x9AE160", Offset = "0x9AD560", VA = "0x1809AE160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000897")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000898")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600282E")]
	[Address(RVA = "0x9AE0E0", Offset = "0x9AD4E0", VA = "0x1809AE0E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectsUpdateEvent()
	{
	}

	[Token(Token = "0x600282F")]
	[Address(RVA = "0x9AE050", Offset = "0x9AD450", VA = "0x1809AE050")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectsUpdateEvent(StorageObjectsUpdateEvent other)
	{
	}

	[Token(Token = "0x6002830")]
	[Address(RVA = "0x9ADBA0", Offset = "0x9ACFA0", VA = "0x1809ADBA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectsUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002832")]
	[Address(RVA = "0x9ADC60", Offset = "0x9AD060", VA = "0x1809ADC60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002833")]
	[Address(RVA = "0x9ADD40", Offset = "0x9AD140", VA = "0x1809ADD40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageObjectsUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002834")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002835")]
	[Address(RVA = "0x9ADE50", Offset = "0x9AD250", VA = "0x1809ADE50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002836")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002837")]
	[Address(RVA = "0x9AE370", Offset = "0x9AD770", VA = "0x1809AE370", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002838")]
	[Address(RVA = "0x9ADB00", Offset = "0x9ACF00", VA = "0x1809ADB00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0x9ADDD0", Offset = "0x9AD1D0", VA = "0x1809ADDD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageObjectsUpdateEvent other)
	{
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600283B")]
	[Address(RVA = "0x9AE260", Offset = "0x9AD660", VA = "0x1809AE260", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
