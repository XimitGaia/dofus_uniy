using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BFD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryLivingObjectFeedResponse : IMessage<CosmeticInventoryLivingObjectFeedResponse>, IMessage, IEquatable<CosmeticInventoryLivingObjectFeedResponse>, IDeepCloneable<CosmeticInventoryLivingObjectFeedResponse>, IBufferMessage
{
	[Token(Token = "0x4002C7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryLivingObjectFeedResponse> _parser;

	[Token(Token = "0x4002C7F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C80")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002C81")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x4002C82")]
	public const int LivingObjectFedFieldNumber = 2;

	[Token(Token = "0x4002C83")]
	[FieldOffset(Offset = "0x20")]
	private ObjectItem livingObjectFed_;

	[Token(Token = "0x17001BA3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CosmeticInventoryLivingObjectFeedResponse> Parser
	{
		[Token(Token = "0x6007DE3")]
		[Address(RVA = "0xC5A030", Offset = "0xC59430", VA = "0x180C5A030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007DE4")]
		[Address(RVA = "0xC59F80", Offset = "0xC59380", VA = "0x180C59F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007DE5")]
		[Address(RVA = "0xC5A1B0", Offset = "0xC595B0", VA = "0x180C5A1B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007DE9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DEA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001BA7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItem LivingObjectFed
	{
		[Token(Token = "0x6007DEB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DEC")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6007DE6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryLivingObjectFeedResponse()
	{
	}

	[Token(Token = "0x6007DE7")]
	[Address(RVA = "0xC59F10", Offset = "0xC59310", VA = "0x180C59F10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryLivingObjectFeedResponse(CosmeticInventoryLivingObjectFeedResponse other)
	{
	}

	[Token(Token = "0x6007DE8")]
	[Address(RVA = "0xC59AC0", Offset = "0xC58EC0", VA = "0x180C59AC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryLivingObjectFeedResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007DED")]
	[Address(RVA = "0xC59B60", Offset = "0xC58F60", VA = "0x180C59B60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DEE")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CosmeticInventoryLivingObjectFeedResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DEF")]
	[Address(RVA = "0xC59C10", Offset = "0xC59010", VA = "0x180C59C10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007DF0")]
	[Address(RVA = "0xC59DB0", Offset = "0xC591B0", VA = "0x180C59DB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007DF1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007DF2")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007DF3")]
	[Address(RVA = "0xC59A20", Offset = "0xC58E20", VA = "0x180C59A20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007DF4")]
	[Address(RVA = "0xC59CD0", Offset = "0xC590D0", VA = "0x180C59CD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CosmeticInventoryLivingObjectFeedResponse other)
	{
	}

	[Token(Token = "0x6007DF5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007DF6")]
	[Address(RVA = "0xC5A080", Offset = "0xC59480", VA = "0x180C5A080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
