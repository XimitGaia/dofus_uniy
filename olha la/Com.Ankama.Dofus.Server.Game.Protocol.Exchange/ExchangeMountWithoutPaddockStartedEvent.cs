using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000707")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountWithoutPaddockStartedEvent : IMessage<ExchangeMountWithoutPaddockStartedEvent>, IMessage, IEquatable<ExchangeMountWithoutPaddockStartedEvent>, IDeepCloneable<ExchangeMountWithoutPaddockStartedEvent>, IBufferMessage
{
	[Token(Token = "0x40018C5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountWithoutPaddockStartedEvent> _parser;

	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018C7")]
	public const int StabledMountsFieldNumber = 1;

	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MountData> _repeated_stabledMounts_codec;

	[Token(Token = "0x40018C9")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<MountData> stabledMounts_;

	[Token(Token = "0x40018CA")]
	public const int PaddockedMountsFieldNumber = 2;

	[Token(Token = "0x40018CB")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<MountData> _repeated_paddockedMounts_codec;

	[Token(Token = "0x40018CC")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<MountData> paddockedMounts_;

	[Token(Token = "0x1700102D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMountWithoutPaddockStartedEvent> Parser
	{
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0xABC140", Offset = "0xABB540", VA = "0x180ABC140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0xABC090", Offset = "0xABB490", VA = "0x180ABC090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0xABC3D0", Offset = "0xABB7D0", VA = "0x180ABC3D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001030")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MountData> StabledMounts
	{
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001031")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MountData> PaddockedMounts
	{
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B8B")]
	[Address(RVA = "0xABBFE0", Offset = "0xABB3E0", VA = "0x180ABBFE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountWithoutPaddockStartedEvent()
	{
	}

	[Token(Token = "0x6004B8C")]
	[Address(RVA = "0xABBF30", Offset = "0xABB330", VA = "0x180ABBF30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountWithoutPaddockStartedEvent(ExchangeMountWithoutPaddockStartedEvent other)
	{
	}

	[Token(Token = "0x6004B8D")]
	[Address(RVA = "0xABB990", Offset = "0xABAD90", VA = "0x180ABB990", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountWithoutPaddockStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004B90")]
	[Address(RVA = "0xABBB20", Offset = "0xABAF20", VA = "0x180ABBB20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B91")]
	[Address(RVA = "0xABBA70", Offset = "0xABAE70", VA = "0x180ABBA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountWithoutPaddockStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B92")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004B93")]
	[Address(RVA = "0xABBCB0", Offset = "0xABB0B0", VA = "0x180ABBCB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004B94")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B95")]
	[Address(RVA = "0xABC2F0", Offset = "0xABB6F0", VA = "0x180ABC2F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B96")]
	[Address(RVA = "0xABB8B0", Offset = "0xABACB0", VA = "0x180ABB8B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B97")]
	[Address(RVA = "0xABBC10", Offset = "0xABB010", VA = "0x180ABBC10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountWithoutPaddockStartedEvent other)
	{
	}

	[Token(Token = "0x6004B98")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B99")]
	[Address(RVA = "0xABC190", Offset = "0xABB590", VA = "0x180ABC190", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
