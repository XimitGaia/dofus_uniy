using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000A4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorTopListEvent : IMessage<TaxCollectorTopListEvent>, IMessage, IEquatable<TaxCollectorTopListEvent>, IDeepCloneable<TaxCollectorTopListEvent>, IBufferMessage
{
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorTopListEvent> _parser;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000223")]
	public const int DungeonTaxCollectorsInformationFieldNumber = 1;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorInformation> _repeated_dungeonTaxCollectorsInformation_codec;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TaxCollectorInformation> dungeonTaxCollectorsInformation_;

	[Token(Token = "0x4000226")]
	public const int WorldTaxCollectorsInformationFieldNumber = 2;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<TaxCollectorInformation> _repeated_worldTaxCollectorsInformation_codec;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<TaxCollectorInformation> worldTaxCollectorsInformation_;

	[Token(Token = "0x1700014C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorTopListEvent> Parser
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x9593E0", Offset = "0x9587E0", VA = "0x1809593E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x959330", Offset = "0x958730", VA = "0x180959330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x959670", Offset = "0x958A70", VA = "0x180959670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorInformation> DungeonTaxCollectorsInformation
	{
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TaxCollectorInformation> WorldTaxCollectorsInformation
	{
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x9591D0", Offset = "0x9585D0", VA = "0x1809591D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorTopListEvent()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x959280", Offset = "0x958680", VA = "0x180959280")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorTopListEvent(TaxCollectorTopListEvent other)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x958C30", Offset = "0x958030", VA = "0x180958C30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorTopListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x958D10", Offset = "0x958110", VA = "0x180958D10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x958E00", Offset = "0x958200", VA = "0x180958E00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorTopListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x958F50", Offset = "0x958350", VA = "0x180958F50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x959590", Offset = "0x958990", VA = "0x180959590", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x958B50", Offset = "0x957F50", VA = "0x180958B50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x958EB0", Offset = "0x9582B0", VA = "0x180958EB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorTopListEvent other)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x959430", Offset = "0x958830", VA = "0x180959430", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
