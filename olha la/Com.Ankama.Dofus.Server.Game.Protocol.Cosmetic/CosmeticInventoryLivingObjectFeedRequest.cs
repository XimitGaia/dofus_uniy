using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BFB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryLivingObjectFeedRequest : IMessage<CosmeticInventoryLivingObjectFeedRequest>, IMessage, IEquatable<CosmeticInventoryLivingObjectFeedRequest>, IDeepCloneable<CosmeticInventoryLivingObjectFeedRequest>, IBufferMessage
{
	[Token(Token = "0x4002C77")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryLivingObjectFeedRequest> _parser;

	[Token(Token = "0x4002C78")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C79")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x4002C7A")]
	[FieldOffset(Offset = "0x18")]
	private int gid_;

	[Token(Token = "0x4002C7B")]
	public const int FoodObjectUidFieldNumber = 2;

	[Token(Token = "0x4002C7C")]
	[FieldOffset(Offset = "0x1C")]
	private int foodObjectUid_;

	[Token(Token = "0x17001B9E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CosmeticInventoryLivingObjectFeedRequest> Parser
	{
		[Token(Token = "0x6007DCB")]
		[Address(RVA = "0xC598F0", Offset = "0xC58CF0", VA = "0x180C598F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007DCC")]
		[Address(RVA = "0xC59840", Offset = "0xC58C40", VA = "0x180C59840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007DCD")]
		[Address(RVA = "0xC59940", Offset = "0xC58D40", VA = "0x180C59940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Gid
	{
		[Token(Token = "0x6007DD1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007DD2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001BA2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FoodObjectUid
	{
		[Token(Token = "0x6007DD3")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007DD4")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6007DCE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryLivingObjectFeedRequest()
	{
	}

	[Token(Token = "0x6007DCF")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryLivingObjectFeedRequest(CosmeticInventoryLivingObjectFeedRequest other)
	{
	}

	[Token(Token = "0x6007DD0")]
	[Address(RVA = "0xC595C0", Offset = "0xC589C0", VA = "0x180C595C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryLivingObjectFeedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007DD5")]
	[Address(RVA = "0xC59650", Offset = "0xC58A50", VA = "0x180C59650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DD6")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryLivingObjectFeedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DD7")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007DD8")]
	[Address(RVA = "0xC596E0", Offset = "0xC58AE0", VA = "0x180C596E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007DD9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007DDA")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007DDB")]
	[Address(RVA = "0xC59500", Offset = "0xC58900", VA = "0x180C59500", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007DDC")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryLivingObjectFeedRequest other)
	{
	}

	[Token(Token = "0x6007DDD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007DDE")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
