using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003F3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseInformationResponse : IMessage<HouseInformationResponse>, IMessage, IEquatable<HouseInformationResponse>, IDeepCloneable<HouseInformationResponse>, IBufferMessage
{
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseInformationResponse> _parser;

	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D9C")]
	public const int HouseInformationFieldNumber = 1;

	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x18")]
	private HouseInstance houseInformation_;

	[Token(Token = "0x170008D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseInformationResponse> Parser
	{
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x99D270", Offset = "0x99C670", VA = "0x18099D270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x99D1C0", Offset = "0x99C5C0", VA = "0x18099D1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x99D3C0", Offset = "0x99C7C0", VA = "0x18099D3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInstance HouseInformation
	{
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseInformationResponse()
	{
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0x99D150", Offset = "0x99C550", VA = "0x18099D150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseInformationResponse(HouseInformationResponse other)
	{
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0x99CDD0", Offset = "0x99C1D0", VA = "0x18099CDD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseInformationResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6002967")]
	[Address(RVA = "0x99CE70", Offset = "0x99C270", VA = "0x18099CE70", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002968")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseInformationResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002969")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600296A")]
	[Address(RVA = "0x99CFF0", Offset = "0x99C3F0", VA = "0x18099CFF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600296B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600296C")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600296D")]
	[Address(RVA = "0x99CD40", Offset = "0x99C140", VA = "0x18099CD40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600296E")]
	[Address(RVA = "0x99CF20", Offset = "0x99C320", VA = "0x18099CF20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseInformationResponse other)
	{
	}

	[Token(Token = "0x600296F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002970")]
	[Address(RVA = "0x99D2C0", Offset = "0x99C6C0", VA = "0x18099D2C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
