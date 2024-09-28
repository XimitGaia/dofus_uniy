using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C85")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRanksEvent : IMessage<AllianceRanksEvent>, IMessage, IEquatable<AllianceRanksEvent>, IDeepCloneable<AllianceRanksEvent>, IBufferMessage
{
	[Token(Token = "0x4002E3C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRanksEvent> _parser;

	[Token(Token = "0x4002E3D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E3E")]
	public const int RanksFieldNumber = 1;

	[Token(Token = "0x4002E3F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

	[Token(Token = "0x4002E40")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<RankInformation> ranks_;

	[Token(Token = "0x17001CDE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceRanksEvent> Parser
	{
		[Token(Token = "0x60083D1")]
		[Address(RVA = "0xC7A150", Offset = "0xC79550", VA = "0x180C7A150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60083D2")]
		[Address(RVA = "0xC7A0A0", Offset = "0xC794A0", VA = "0x180C7A0A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60083D3")]
		[Address(RVA = "0xC7A360", Offset = "0xC79760", VA = "0x180C7A360", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RankInformation> Ranks
	{
		[Token(Token = "0x60083D7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60083D4")]
	[Address(RVA = "0xC79F90", Offset = "0xC79390", VA = "0x180C79F90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRanksEvent()
	{
	}

	[Token(Token = "0x60083D5")]
	[Address(RVA = "0xC7A010", Offset = "0xC79410", VA = "0x180C7A010")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRanksEvent(AllianceRanksEvent other)
	{
	}

	[Token(Token = "0x60083D6")]
	[Address(RVA = "0xC79AE0", Offset = "0xC78EE0", VA = "0x180C79AE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRanksEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60083D8")]
	[Address(RVA = "0xC79C30", Offset = "0xC79030", VA = "0x180C79C30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083D9")]
	[Address(RVA = "0xC79BA0", Offset = "0xC78FA0", VA = "0x180C79BA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRanksEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083DA")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60083DB")]
	[Address(RVA = "0xC79D90", Offset = "0xC79190", VA = "0x180C79D90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60083DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60083DD")]
	[Address(RVA = "0xC7A2B0", Offset = "0xC796B0", VA = "0x180C7A2B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60083DE")]
	[Address(RVA = "0xC79A40", Offset = "0xC78E40", VA = "0x180C79A40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60083DF")]
	[Address(RVA = "0xC79D10", Offset = "0xC79110", VA = "0x180C79D10", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceRanksEvent other)
	{
	}

	[Token(Token = "0x60083E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60083E1")]
	[Address(RVA = "0xC7A1A0", Offset = "0xC795A0", VA = "0x180C7A1A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
