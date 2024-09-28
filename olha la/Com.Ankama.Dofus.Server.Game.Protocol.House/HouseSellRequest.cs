using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003F7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseSellRequest : IMessage<HouseSellRequest>, IMessage, IEquatable<HouseSellRequest>, IDeepCloneable<HouseSellRequest>, IBufferMessage
{
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseSellRequest> _parser;

	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DA6")]
	public const int InstanceIdFieldNumber = 1;

	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x18")]
	private int instanceId_;

	[Token(Token = "0x4000DA8")]
	public const int AmountFieldNumber = 2;

	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x20")]
	private long amount_;

	[Token(Token = "0x4000DAA")]
	public const int ForSaleFieldNumber = 3;

	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x28")]
	private bool forSale_;

	[Token(Token = "0x4000DAC")]
	public const int IsInsideFieldNumber = 4;

	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x29")]
	private bool isInside_;

	[Token(Token = "0x170008DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseSellRequest> Parser
	{
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x9A1B90", Offset = "0x9A0F90", VA = "0x1809A1B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x9A1AD0", Offset = "0x9A0ED0", VA = "0x1809A1AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x9A1DA0", Offset = "0x9A11A0", VA = "0x1809A1DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InstanceId
	{
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Amount
	{
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170008E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ForSale
	{
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002996")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x170008E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsInside
	{
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x9A1B80", Offset = "0x9A0F80", VA = "0x1809A1B80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x9A1E90", Offset = "0x9A1290", VA = "0x1809A1E90")]
		set
		{
		}
	}

	[Token(Token = "0x600298E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellRequest()
	{
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x9A1A60", Offset = "0x9A0E60", VA = "0x1809A1A60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellRequest(HouseSellRequest other)
	{
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x9A15E0", Offset = "0x9A09E0", VA = "0x1809A15E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002999")]
	[Address(RVA = "0x9A16D0", Offset = "0x9A0AD0", VA = "0x1809A16D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600299A")]
	[Address(RVA = "0x9A1680", Offset = "0x9A0A80", VA = "0x1809A1680", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600299B")]
	[Address(RVA = "0x9A1780", Offset = "0x9A0B80", VA = "0x1809A1780", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600299C")]
	[Address(RVA = "0x9A1900", Offset = "0x9A0D00", VA = "0x1809A1900", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600299D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600299E")]
	[Address(RVA = "0x9A1CE0", Offset = "0x9A10E0", VA = "0x1809A1CE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600299F")]
	[Address(RVA = "0x9A1510", Offset = "0x9A0910", VA = "0x1809A1510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x9A1890", Offset = "0x9A0C90", VA = "0x1809A1890", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseSellRequest other)
	{
	}

	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x9A1BE0", Offset = "0x9A0FE0", VA = "0x1809A1BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
