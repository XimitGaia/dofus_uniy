using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000709")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountsStableAddedEvent : IMessage<ExchangeMountsStableAddedEvent>, IMessage, IEquatable<ExchangeMountsStableAddedEvent>, IDeepCloneable<ExchangeMountsStableAddedEvent>, IBufferMessage
{
	[Token(Token = "0x40018CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountsStableAddedEvent> _parser;

	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018D0")]
	public const int MountsFieldNumber = 1;

	[Token(Token = "0x40018D1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MountData> _repeated_mounts_codec;

	[Token(Token = "0x40018D2")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<MountData> mounts_;

	[Token(Token = "0x40018D3")]
	public const int NewBornFieldNumber = 2;

	[Token(Token = "0x40018D4")]
	[FieldOffset(Offset = "0x20")]
	private bool newBorn_;

	[Token(Token = "0x17001032")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeMountsStableAddedEvent> Parser
	{
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0xABE050", Offset = "0xABD450", VA = "0x180ABE050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001033")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0xABDFA0", Offset = "0xABD3A0", VA = "0x180ABDFA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001034")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0xABE2A0", Offset = "0xABD6A0", VA = "0x180ABE2A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001035")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MountData> Mounts
	{
		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001036")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NewBorn
	{
		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6004BA1")]
	[Address(RVA = "0xABDE90", Offset = "0xABD290", VA = "0x180ABDE90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountsStableAddedEvent()
	{
	}

	[Token(Token = "0x6004BA2")]
	[Address(RVA = "0xABDF10", Offset = "0xABD310", VA = "0x180ABDF10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsStableAddedEvent(ExchangeMountsStableAddedEvent other)
	{
	}

	[Token(Token = "0x6004BA3")]
	[Address(RVA = "0xABD900", Offset = "0xABCD00", VA = "0x180ABD900", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsStableAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004BA7")]
	[Address(RVA = "0xABDA60", Offset = "0xABCE60", VA = "0x180ABDA60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BA8")]
	[Address(RVA = "0xABD9C0", Offset = "0xABCDC0", VA = "0x180ABD9C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeMountsStableAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BA9")]
	[Address(RVA = "0xABDB40", Offset = "0xABCF40", VA = "0x180ABDB40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004BAA")]
	[Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004BAB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004BAC")]
	[Address(RVA = "0xABE1D0", Offset = "0xABD5D0", VA = "0x180ABE1D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004BAD")]
	[Address(RVA = "0xABD850", Offset = "0xABCC50", VA = "0x180ABD850", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004BAE")]
	[Address(RVA = "0xABDC00", Offset = "0xABD000", VA = "0x180ABDC00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountsStableAddedEvent other)
	{
	}

	[Token(Token = "0x6004BAF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004BB0")]
	[Address(RVA = "0xABE0A0", Offset = "0xABD4A0", VA = "0x180ABE0A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
