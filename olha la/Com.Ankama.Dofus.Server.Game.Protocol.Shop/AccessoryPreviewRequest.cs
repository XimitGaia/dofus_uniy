using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Shop;

[Token(Token = "0x2000144")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccessoryPreviewRequest : IMessage<AccessoryPreviewRequest>, IMessage, IEquatable<AccessoryPreviewRequest>, IDeepCloneable<AccessoryPreviewRequest>, IBufferMessage
{
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccessoryPreviewRequest> _parser;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000458")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectGid_codec;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectGid_;

	[Token(Token = "0x400045B")]
	public const int ShowCurrentObjectsFieldNumber = 2;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x20")]
	private bool showCurrentObjects_;

	[Token(Token = "0x170002B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AccessoryPreviewRequest> Parser
	{
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0xB62E90", Offset = "0xB62290", VA = "0x180B62E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0xB62DE0", Offset = "0xB621E0", VA = "0x180B62DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0xB630E0", Offset = "0xB624E0", VA = "0x180B630E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectGid
	{
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ShowCurrentObjects
	{
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0xB62D60", Offset = "0xB62160", VA = "0x180B62D60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewRequest()
	{
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0xB62CD0", Offset = "0xB620D0", VA = "0x180B62CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewRequest(AccessoryPreviewRequest other)
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0xB627B0", Offset = "0xB61BB0", VA = "0x180B627B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccessoryPreviewRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0xB62910", Offset = "0xB61D10", VA = "0x180B62910", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0xB62870", Offset = "0xB61C70", VA = "0x180B62870", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AccessoryPreviewRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0xB629F0", Offset = "0xB61DF0", VA = "0x180B629F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0xB62B40", Offset = "0xB61F40", VA = "0x180B62B40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0xB63010", Offset = "0xB62410", VA = "0x180B63010", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0xB62700", Offset = "0xB61B00", VA = "0x180B62700", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0xB62AB0", Offset = "0xB61EB0", VA = "0x180B62AB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AccessoryPreviewRequest other)
	{
	}

	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0xB62EE0", Offset = "0xB622E0", VA = "0x180B62EE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
