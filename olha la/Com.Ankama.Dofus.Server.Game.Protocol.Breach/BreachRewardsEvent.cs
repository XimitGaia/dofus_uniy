using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x200090F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRewardsEvent : IMessage<BreachRewardsEvent>, IMessage, IEquatable<BreachRewardsEvent>, IDeepCloneable<BreachRewardsEvent>, IBufferMessage
{
	[Token(Token = "0x4001EFB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRewardsEvent> _parser;

	[Token(Token = "0x4001EFC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EFD")]
	public const int RewardsFieldNumber = 1;

	[Token(Token = "0x4001EFE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<BreachReward> _repeated_rewards_codec;

	[Token(Token = "0x4001EFF")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<BreachReward> rewards_;

	[Token(Token = "0x17001445")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachRewardsEvent> Parser
	{
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0xB558E0", Offset = "0xB54CE0", VA = "0x180B558E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001446")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0xB55830", Offset = "0xB54C30", VA = "0x180B55830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001447")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0xB55AF0", Offset = "0xB54EF0", VA = "0x180B55AF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001448")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BreachReward> Rewards
	{
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005FD3")]
	[Address(RVA = "0xB557B0", Offset = "0xB54BB0", VA = "0x180B557B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRewardsEvent()
	{
	}

	[Token(Token = "0x6005FD4")]
	[Address(RVA = "0xB55720", Offset = "0xB54B20", VA = "0x180B55720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRewardsEvent(BreachRewardsEvent other)
	{
	}

	[Token(Token = "0x6005FD5")]
	[Address(RVA = "0xB55270", Offset = "0xB54670", VA = "0x180B55270", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRewardsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005FD7")]
	[Address(RVA = "0xB55330", Offset = "0xB54730", VA = "0x180B55330", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FD8")]
	[Address(RVA = "0xB55410", Offset = "0xB54810", VA = "0x180B55410", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachRewardsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FD9")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005FDA")]
	[Address(RVA = "0xB55520", Offset = "0xB54920", VA = "0x180B55520", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005FDB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005FDC")]
	[Address(RVA = "0xB55A40", Offset = "0xB54E40", VA = "0x180B55A40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005FDD")]
	[Address(RVA = "0xB551D0", Offset = "0xB545D0", VA = "0x180B551D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005FDE")]
	[Address(RVA = "0xB554A0", Offset = "0xB548A0", VA = "0x180B554A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachRewardsEvent other)
	{
	}

	[Token(Token = "0x6005FDF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005FE0")]
	[Address(RVA = "0xB55930", Offset = "0xB54D30", VA = "0x180B55930", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
