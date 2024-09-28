using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000305")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountFeedRequest : IMessage<MountFeedRequest>, IMessage, IEquatable<MountFeedRequest>, IDeepCloneable<MountFeedRequest>, IBufferMessage
{
	[Token(Token = "0x2000306")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000307")]
		public enum MountLocation
		{
			[Token(Token = "0x4000A9A")]
			[OriginalName("EQUIPPED")]
			Equipped,
			[Token(Token = "0x4000A9B")]
			[OriginalName("INVENTORY")]
			Inventory,
			[Token(Token = "0x4000A9C")]
			[OriginalName("STABLED")]
			Stabled,
			[Token(Token = "0x4000A9D")]
			[OriginalName("MAP")]
			Map
		}
	}

	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountFeedRequest> _parser;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A91")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x4000A93")]
	public const int MountLocationFieldNumber = 2;

	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x1C")]
	private Types.MountLocation mountLocation_;

	[Token(Token = "0x4000A95")]
	public const int MountFoodUidFieldNumber = 3;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x20")]
	private int mountFoodUid_;

	[Token(Token = "0x4000A97")]
	public const int QuantityFieldNumber = 4;

	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x24")]
	private int quantity_;

	[Token(Token = "0x170006C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountFeedRequest> Parser
	{
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0xD1CCF0", Offset = "0xD1C0F0", VA = "0x180D1CCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0xD1CC40", Offset = "0xD1C040", VA = "0x180D1CC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0xD1CE00", Offset = "0xD1C200", VA = "0x180D1CE00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170006C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.MountLocation MountLocation
	{
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.MountLocation);
		}
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170006C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MountFoodUid
	{
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170006C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountFeedRequest()
	{
	}

	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountFeedRequest(MountFeedRequest other)
	{
	}

	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0xD1C8F0", Offset = "0xD1BCF0", VA = "0x180D1C8F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountFeedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F67")]
	[Address(RVA = "0xD1C980", Offset = "0xD1BD80", VA = "0x180D1C980", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F68")]
	[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountFeedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F69")]
	[Address(RVA = "0xD1CA20", Offset = "0xD1BE20", VA = "0x180D1CA20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0xD1CAE0", Offset = "0xD1BEE0", VA = "0x180D1CAE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0xD1CD40", Offset = "0xD1C140", VA = "0x180D1CD40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0xD1C7E0", Offset = "0xD1BBE0", VA = "0x180D1C7E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountFeedRequest other)
	{
	}

	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
