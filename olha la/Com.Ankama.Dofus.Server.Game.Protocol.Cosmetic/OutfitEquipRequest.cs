using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C27")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipRequest : IMessage<OutfitEquipRequest>, IMessage, IEquatable<OutfitEquipRequest>, IDeepCloneable<OutfitEquipRequest>, IBufferMessage
{
	[Token(Token = "0x4002D10")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipRequest> _parser;

	[Token(Token = "0x4002D11")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D12")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x4002D13")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x17001C0C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipRequest> Parser
	{
		[Token(Token = "0x6007FDB")]
		[Address(RVA = "0xC66C50", Offset = "0xC66050", VA = "0x180C66C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007FDC")]
		[Address(RVA = "0xC66BA0", Offset = "0xC65FA0", VA = "0x180C66BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007FDD")]
		[Address(RVA = "0xC66D60", Offset = "0xC66160", VA = "0x180C66D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OutfitUuid
	{
		[Token(Token = "0x6007FE1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007FE2")]
		[Address(RVA = "0xC66E40", Offset = "0xC66240", VA = "0x180C66E40")]
		set
		{
		}
	}

	[Token(Token = "0x6007FDE")]
	[Address(RVA = "0xC66AB0", Offset = "0xC65EB0", VA = "0x180C66AB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipRequest()
	{
	}

	[Token(Token = "0x6007FDF")]
	[Address(RVA = "0xC66B00", Offset = "0xC65F00", VA = "0x180C66B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipRequest(OutfitEquipRequest other)
	{
	}

	[Token(Token = "0x6007FE0")]
	[Address(RVA = "0xC66770", Offset = "0xC65B70", VA = "0x180C66770", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FE3")]
	[Address(RVA = "0xC66840", Offset = "0xC65C40", VA = "0x180C66840", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FE4")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FE5")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007FE6")]
	[Address(RVA = "0xC66950", Offset = "0xC65D50", VA = "0x180C66950", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007FE7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007FE8")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007FE9")]
	[Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007FEA")]
	[Address(RVA = "0xC668F0", Offset = "0xC65CF0", VA = "0x180C668F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipRequest other)
	{
	}

	[Token(Token = "0x6007FEB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007FEC")]
	[Address(RVA = "0xC66CA0", Offset = "0xC660A0", VA = "0x180C66CA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
