using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B11")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorComplementaryInformation : IMessage<TaxCollectorComplementaryInformation>, IMessage, IEquatable<TaxCollectorComplementaryInformation>, IDeepCloneable<TaxCollectorComplementaryInformation>, IBufferMessage
{
	[Token(Token = "0x2000B12")]
	public enum ComplementaryInformationOneofCase
	{
		[Token(Token = "0x400291F")]
		None,
		[Token(Token = "0x4002920")]
		LootInformation,
		[Token(Token = "0x4002921")]
		WaitingForHelpInformation
	}

	[Token(Token = "0x4002918")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorComplementaryInformation> _parser;

	[Token(Token = "0x4002919")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400291A")]
	public const int LootInformationFieldNumber = 1;

	[Token(Token = "0x400291B")]
	public const int WaitingForHelpInformationFieldNumber = 2;

	[Token(Token = "0x400291C")]
	[FieldOffset(Offset = "0x18")]
	private object complementaryInformation_;

	[Token(Token = "0x400291D")]
	[FieldOffset(Offset = "0x20")]
	private ComplementaryInformationOneofCase complementaryInformationCase_;

	[Token(Token = "0x17001992")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorComplementaryInformation> Parser
	{
		[Token(Token = "0x6007469")]
		[Address(RVA = "0xC0E6A0", Offset = "0xC0DAA0", VA = "0x180C0E6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001993")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600746A")]
		[Address(RVA = "0xC0E590", Offset = "0xC0D990", VA = "0x180C0E590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001994")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600746B")]
		[Address(RVA = "0xC0EA40", Offset = "0xC0DE40", VA = "0x180C0EA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001995")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorLootInformation LootInformation
	{
		[Token(Token = "0x600746F")]
		[Address(RVA = "0xC0E640", Offset = "0xC0DA40", VA = "0x180C0E640")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007470")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17001996")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorWaitingForHelpInformation WaitingForHelpInformation
	{
		[Token(Token = "0x6007471")]
		[Address(RVA = "0xC0E6F0", Offset = "0xC0DAF0", VA = "0x180C0E6F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007472")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001997")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComplementaryInformationOneofCase ComplementaryInformationCase
	{
		[Token(Token = "0x6007473")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ComplementaryInformationOneofCase);
		}
	}

	[Token(Token = "0x600746C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorComplementaryInformation()
	{
	}

	[Token(Token = "0x600746D")]
	[Address(RVA = "0xC0E370", Offset = "0xC0D770", VA = "0x180C0E370")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorComplementaryInformation(TaxCollectorComplementaryInformation other)
	{
	}

	[Token(Token = "0x600746E")]
	[Address(RVA = "0xC0DB30", Offset = "0xC0CF30", VA = "0x180C0DB30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorComplementaryInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6007474")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplementaryInformation()
	{
	}

	[Token(Token = "0x6007475")]
	[Address(RVA = "0xC0DB90", Offset = "0xC0CF90", VA = "0x180C0DB90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007476")]
	[Address(RVA = "0xC0DD00", Offset = "0xC0D100", VA = "0x180C0DD00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorComplementaryInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007477")]
	[Address(RVA = "0xC0DE30", Offset = "0xC0D230", VA = "0x180C0DE30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007478")]
	[Address(RVA = "0xC0E210", Offset = "0xC0D610", VA = "0x180C0E210", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007479")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600747A")]
	[Address(RVA = "0xC0E930", Offset = "0xC0DD30", VA = "0x180C0E930", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600747B")]
	[Address(RVA = "0xC0DA00", Offset = "0xC0CE00", VA = "0x180C0DA00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600747C")]
	[Address(RVA = "0xC0DF60", Offset = "0xC0D360", VA = "0x180C0DF60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorComplementaryInformation other)
	{
	}

	[Token(Token = "0x600747D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600747E")]
	[Address(RVA = "0xC0E750", Offset = "0xC0DB50", VA = "0x180C0E750", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
