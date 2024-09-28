using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B16")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorWaitingForHelpInformation : IMessage<TaxCollectorWaitingForHelpInformation>, IMessage, IEquatable<TaxCollectorWaitingForHelpInformation>, IDeepCloneable<TaxCollectorWaitingForHelpInformation>, IBufferMessage
{
	[Token(Token = "0x400292A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorWaitingForHelpInformation> _parser;

	[Token(Token = "0x400292B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400292C")]
	public const int TimeLeftBeforeFightFieldNumber = 1;

	[Token(Token = "0x400292D")]
	[FieldOffset(Offset = "0x18")]
	private long timeLeftBeforeFight_;

	[Token(Token = "0x400292E")]
	public const int PlacementTimeLeftFieldNumber = 2;

	[Token(Token = "0x400292F")]
	[FieldOffset(Offset = "0x20")]
	private long placementTimeLeft_;

	[Token(Token = "0x4002930")]
	public const int DefenderSlotsLeftFieldNumber = 3;

	[Token(Token = "0x4002931")]
	[FieldOffset(Offset = "0x28")]
	private int defenderSlotsLeft_;

	[Token(Token = "0x1700199D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorWaitingForHelpInformation> Parser
	{
		[Token(Token = "0x600749B")]
		[Address(RVA = "0xC133A0", Offset = "0xC127A0", VA = "0x180C133A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700199E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600749C")]
		[Address(RVA = "0xC132F0", Offset = "0xC126F0", VA = "0x180C132F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700199F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600749D")]
		[Address(RVA = "0xC133F0", Offset = "0xC127F0", VA = "0x180C133F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TimeLeftBeforeFight
	{
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074A2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170019A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlacementTimeLeft
	{
		[Token(Token = "0x60074A3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60074A4")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170019A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefenderSlotsLeft
	{
		[Token(Token = "0x60074A5")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60074A6")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x600749E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorWaitingForHelpInformation()
	{
	}

	[Token(Token = "0x600749F")]
	[Address(RVA = "0xAA8980", Offset = "0xAA7D80", VA = "0x180AA8980")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorWaitingForHelpInformation(TaxCollectorWaitingForHelpInformation other)
	{
	}

	[Token(Token = "0x60074A0")]
	[Address(RVA = "0xC13060", Offset = "0xC12460", VA = "0x180C13060", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorWaitingForHelpInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60074A7")]
	[Address(RVA = "0xC130F0", Offset = "0xC124F0", VA = "0x180C130F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074A8")]
	[Address(RVA = "0xAA86C0", Offset = "0xAA7AC0", VA = "0x180AA86C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorWaitingForHelpInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074A9")]
	[Address(RVA = "0xAA8700", Offset = "0xAA7B00", VA = "0x180AA8700", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60074AA")]
	[Address(RVA = "0xC13190", Offset = "0xC12590", VA = "0x180C13190", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60074AB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60074AC")]
	[Address(RVA = "0xB683E0", Offset = "0xB677E0", VA = "0x180B683E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60074AD")]
	[Address(RVA = "0xC12F70", Offset = "0xC12370", VA = "0x180C12F70", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60074AE")]
	[Address(RVA = "0xAA87B0", Offset = "0xAA7BB0", VA = "0x180AA87B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorWaitingForHelpInformation other)
	{
	}

	[Token(Token = "0x60074AF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60074B0")]
	[Address(RVA = "0xAA8AE0", Offset = "0xAA7EE0", VA = "0x180AA8AE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
