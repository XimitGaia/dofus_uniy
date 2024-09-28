using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000B6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorMovementsOfflineEvent : IMessage<TaxCollectorMovementsOfflineEvent>, IMessage, IEquatable<TaxCollectorMovementsOfflineEvent>, IDeepCloneable<TaxCollectorMovementsOfflineEvent>, IBufferMessage
{
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorMovementsOfflineEvent> _parser;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000279")]
	public const int MovementsFieldNumber = 1;

	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorMovement> _repeated_movements_codec;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TaxCollectorMovement> movements_;

	[Token(Token = "0x1700017F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorMovementsOfflineEvent> Parser
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xA67E40", Offset = "0xA67240", VA = "0x180A67E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000180")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xA67D90", Offset = "0xA67190", VA = "0x180A67D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000181")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xA68050", Offset = "0xA67450", VA = "0x180A68050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000182")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TaxCollectorMovement> Movements
	{
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0xA67C80", Offset = "0xA67080", VA = "0x180A67C80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorMovementsOfflineEvent()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0xA67D00", Offset = "0xA67100", VA = "0x180A67D00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorMovementsOfflineEvent(TaxCollectorMovementsOfflineEvent other)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0xA677D0", Offset = "0xA66BD0", VA = "0x180A677D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorMovementsOfflineEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0xA67920", Offset = "0xA66D20", VA = "0x180A67920", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0xA67890", Offset = "0xA66C90", VA = "0x180A67890", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorMovementsOfflineEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0xA67A80", Offset = "0xA66E80", VA = "0x180A67A80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0xA67FA0", Offset = "0xA673A0", VA = "0x180A67FA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0xA67730", Offset = "0xA66B30", VA = "0x180A67730", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0xA67A00", Offset = "0xA66E00", VA = "0x180A67A00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorMovementsOfflineEvent other)
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0xA67E90", Offset = "0xA67290", VA = "0x180A67E90", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
