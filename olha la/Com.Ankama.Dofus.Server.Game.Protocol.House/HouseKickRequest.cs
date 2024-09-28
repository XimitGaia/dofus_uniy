using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003F5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseKickRequest : IMessage<HouseKickRequest>, IMessage, IEquatable<HouseKickRequest>, IDeepCloneable<HouseKickRequest>, IBufferMessage
{
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseKickRequest> _parser;

	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DA1")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x170008DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseKickRequest> Parser
	{
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x99D850", Offset = "0x99CC50", VA = "0x18099D850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x99D7A0", Offset = "0x99CBA0", VA = "0x18099D7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x99D8A0", Offset = "0x99CCA0", VA = "0x18099D8A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6002978")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseKickRequest()
	{
	}

	[Token(Token = "0x6002979")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseKickRequest(HouseKickRequest other)
	{
	}

	[Token(Token = "0x600297A")]
	[Address(RVA = "0x99D530", Offset = "0x99C930", VA = "0x18099D530", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600297D")]
	[Address(RVA = "0x99D5B0", Offset = "0x99C9B0", VA = "0x18099D5B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600297E")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600297F")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002980")]
	[Address(RVA = "0x99D640", Offset = "0x99CA40", VA = "0x18099D640", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002981")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002982")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002983")]
	[Address(RVA = "0x99D4A0", Offset = "0x99C8A0", VA = "0x18099D4A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002984")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseKickRequest other)
	{
	}

	[Token(Token = "0x6002985")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002986")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
