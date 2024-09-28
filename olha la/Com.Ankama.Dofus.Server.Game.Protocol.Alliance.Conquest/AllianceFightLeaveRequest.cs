using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CDD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightLeaveRequest : IMessage<AllianceFightLeaveRequest>, IMessage, IEquatable<AllianceFightLeaveRequest>, IDeepCloneable<AllianceFightLeaveRequest>, IBufferMessage
{
	[Token(Token = "0x4002F5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightLeaveRequest> _parser;

	[Token(Token = "0x4002F5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F5C")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F5D")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x17001DA2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFightLeaveRequest> Parser
	{
		[Token(Token = "0x600878E")]
		[Address(RVA = "0xCAC0B0", Offset = "0xCAB4B0", VA = "0x180CAC0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600878F")]
		[Address(RVA = "0xCAC000", Offset = "0xCAB400", VA = "0x180CAC000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008790")]
		[Address(RVA = "0xCAC200", Offset = "0xCAB600", VA = "0x180CAC200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x6008794")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008795")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008791")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightLeaveRequest()
	{
	}

	[Token(Token = "0x6008792")]
	[Address(RVA = "0xCAB1B0", Offset = "0xCAA5B0", VA = "0x180CAB1B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightLeaveRequest(AllianceFightLeaveRequest other)
	{
	}

	[Token(Token = "0x6008793")]
	[Address(RVA = "0xCABC80", Offset = "0xCAB080", VA = "0x180CABC80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightLeaveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008796")]
	[Address(RVA = "0xCABD20", Offset = "0xCAB120", VA = "0x180CABD20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008797")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFightLeaveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008798")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008799")]
	[Address(RVA = "0xCABEA0", Offset = "0xCAB2A0", VA = "0x180CABEA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600879A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600879B")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600879C")]
	[Address(RVA = "0xCABBF0", Offset = "0xCAAFF0", VA = "0x180CABBF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600879D")]
	[Address(RVA = "0xCABDD0", Offset = "0xCAB1D0", VA = "0x180CABDD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightLeaveRequest other)
	{
	}

	[Token(Token = "0x600879E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600879F")]
	[Address(RVA = "0xCAC100", Offset = "0xCAB500", VA = "0x180CAC100", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
