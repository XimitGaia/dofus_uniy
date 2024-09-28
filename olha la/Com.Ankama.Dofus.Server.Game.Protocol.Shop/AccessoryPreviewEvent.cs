using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop;

[Token(Token = "0x200014A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccessoryPreviewEvent : IMessage<AccessoryPreviewEvent>, IMessage, IEquatable<AccessoryPreviewEvent>, IDeepCloneable<AccessoryPreviewEvent>, IBufferMessage
{
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccessoryPreviewEvent> _parser;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000469")]
	public const int LookFieldNumber = 1;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x18")]
	private EntityLook look_;

	[Token(Token = "0x170002BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AccessoryPreviewEvent> Parser
	{
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0xB624D0", Offset = "0xB618D0", VA = "0x180B624D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0xB62420", Offset = "0xB61820", VA = "0x180B62420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0xB62620", Offset = "0xB61A20", VA = "0x180B62620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook Look
	{
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewEvent()
	{
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0xB623B0", Offset = "0xB617B0", VA = "0x180B623B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccessoryPreviewEvent(AccessoryPreviewEvent other)
	{
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0xB62030", Offset = "0xB61430", VA = "0x180B62030", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0xB620D0", Offset = "0xB614D0", VA = "0x180B620D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AccessoryPreviewEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0xB62250", Offset = "0xB61650", VA = "0x180B62250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0xB61FA0", Offset = "0xB613A0", VA = "0x180B61FA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0xB62180", Offset = "0xB61580", VA = "0x180B62180", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AccessoryPreviewEvent other)
	{
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0xB62520", Offset = "0xB61920", VA = "0x180B62520", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
