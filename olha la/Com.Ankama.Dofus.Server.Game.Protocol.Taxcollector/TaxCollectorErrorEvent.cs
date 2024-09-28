using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000BA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorErrorEvent : IMessage<TaxCollectorErrorEvent>, IMessage, IEquatable<TaxCollectorErrorEvent>, IDeepCloneable<TaxCollectorErrorEvent>, IBufferMessage
{
	[Token(Token = "0x20000BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20000BC")]
		public enum TaxCollectorErrorReason
		{
			[Token(Token = "0x400028E")]
			[OriginalName("TAX_COLLECTOR_ERROR_UNKNOWN")]
			TaxCollectorErrorUnknown,
			[Token(Token = "0x400028F")]
			[OriginalName("TAX_COLLECTOR_NOT_FOUND")]
			TaxCollectorNotFound,
			[Token(Token = "0x4000290")]
			[OriginalName("TAX_COLLECTOR_NOT_OWNED")]
			TaxCollectorNotOwned,
			[Token(Token = "0x4000291")]
			[OriginalName("TAX_COLLECTOR_NO_RIGHTS")]
			TaxCollectorNoRights,
			[Token(Token = "0x4000292")]
			[OriginalName("TAX_COLLECTOR_MAX_REACHED")]
			TaxCollectorMaxReached,
			[Token(Token = "0x4000293")]
			[OriginalName("TAX_COLLECTOR_ALREADY_ONE")]
			TaxCollectorAlreadyOne,
			[Token(Token = "0x4000294")]
			[OriginalName("TAX_COLLECTOR_CANT_HIRE_YET")]
			TaxCollectorCantHireYet,
			[Token(Token = "0x4000295")]
			[OriginalName("TAX_COLLECTOR_CANT_HIRE_HERE")]
			TaxCollectorCantHireHere,
			[Token(Token = "0x4000296")]
			[OriginalName("TAX_COLLECTOR_NOT_ENOUGH_KAMAS")]
			TaxCollectorNotEnoughKamas
		}
	}

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorErrorEvent> _parser;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400028B")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x18")]
	private Types.TaxCollectorErrorReason reason_;

	[Token(Token = "0x1700018A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorErrorEvent> Parser
	{
		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA65840", Offset = "0xA64C40", VA = "0x180A65840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA65790", Offset = "0xA64B90", VA = "0x180A65790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000726")]
		[Address(RVA = "0xA65890", Offset = "0xA64C90", VA = "0x180A65890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.TaxCollectorErrorReason Reason
	{
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.TaxCollectorErrorReason);
		}
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorErrorEvent()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorErrorEvent(TaxCollectorErrorEvent other)
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xA65520", Offset = "0xA64920", VA = "0x180A65520", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xA655A0", Offset = "0xA649A0", VA = "0x180A655A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0xA65630", Offset = "0xA64A30", VA = "0x180A65630", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0xA65490", Offset = "0xA64890", VA = "0x180A65490", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorErrorEvent other)
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
