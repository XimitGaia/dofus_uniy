using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000401")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseTeleportRequest : IMessage<HouseTeleportRequest>, IMessage, IEquatable<HouseTeleportRequest>, IDeepCloneable<HouseTeleportRequest>, IBufferMessage
{
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseTeleportRequest> _parser;

	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DCF")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000DD1")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x170008FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseTeleportRequest> Parser
	{
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x9A30A0", Offset = "0x9A24A0", VA = "0x1809A30A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x9A2FF0", Offset = "0x9A23F0", VA = "0x1809A2FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x9A30F0", Offset = "0x9A24F0", VA = "0x1809A30F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InstanceId
	{
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseTeleportRequest()
	{
	}

	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseTeleportRequest(HouseTeleportRequest other)
	{
	}

	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x9A2D70", Offset = "0x9A2170", VA = "0x1809A2D70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseTeleportRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x9A2E00", Offset = "0x9A2200", VA = "0x1809A2E00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseTeleportRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x9A2E90", Offset = "0x9A2290", VA = "0x1809A2E90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x9A2CB0", Offset = "0x9A20B0", VA = "0x1809A2CB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseTeleportRequest other)
	{
	}

	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
