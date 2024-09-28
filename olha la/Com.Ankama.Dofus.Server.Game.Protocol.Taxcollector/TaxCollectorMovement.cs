using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000B2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorMovement : IMessage<TaxCollectorMovement>, IMessage, IEquatable<TaxCollectorMovement>, IDeepCloneable<TaxCollectorMovement>, IBufferMessage
{
	[Token(Token = "0x20000B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20000B4")]
		public enum TaxCollectorMovementType
		{
			[Token(Token = "0x4000271")]
			[OriginalName("TAX_COLLECTOR_UNKNOWN_ACTION")]
			TaxCollectorUnknownAction,
			[Token(Token = "0x4000272")]
			[OriginalName("TAX_COLLECTOR_HIRED")]
			TaxCollectorHired,
			[Token(Token = "0x4000273")]
			[OriginalName("TAX_COLLECTOR_HARVESTED")]
			TaxCollectorHarvested,
			[Token(Token = "0x4000274")]
			[OriginalName("TAX_COLLECTOR_DEFEATED")]
			TaxCollectorDefeated,
			[Token(Token = "0x4000275")]
			[OriginalName("TAX_COLLECTOR_DESTROYED")]
			TaxCollectorDestroyed
		}
	}

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorMovement> _parser;

	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000264")]
	public const int MovementTypeFieldNumber = 1;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x18")]
	private Types.TaxCollectorMovementType movementType_;

	[Token(Token = "0x4000266")]
	public const int FirstNameIdFieldNumber = 2;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x1C")]
	private int firstNameId_;

	[Token(Token = "0x4000268")]
	public const int LastNameIdFieldNumber = 3;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x20")]
	private int lastNameId_;

	[Token(Token = "0x400026A")]
	public const int CoordinatesFieldNumber = 4;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x28")]
	private MapExtendedCoordinates coordinates_;

	[Token(Token = "0x400026C")]
	public const int PlayerIdFieldNumber = 5;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x30")]
	private long playerId_;

	[Token(Token = "0x400026E")]
	public const int PlayerNameFieldNumber = 6;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x38")]
	private string playerName_;

	[Token(Token = "0x17000176")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorMovement> Parser
	{
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xA672E0", Offset = "0xA666E0", VA = "0x180A672E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000177")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xA67230", Offset = "0xA66630", VA = "0x180A67230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000178")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xA675E0", Offset = "0xA669E0", VA = "0x180A675E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000179")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.TaxCollectorMovementType MovementType
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.TaxCollectorMovementType);
		}
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700017A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstNameId
	{
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700017B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LastNameId
	{
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700017C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapExtendedCoordinates Coordinates
	{
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700017D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700017E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PlayerName
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xA676C0", Offset = "0xA66AC0", VA = "0x180A676C0")]
		set
		{
		}
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xA671E0", Offset = "0xA665E0", VA = "0x180A671E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorMovement()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xA67100", Offset = "0xA66500", VA = "0x180A67100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorMovement(TaxCollectorMovement other)
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xA66AF0", Offset = "0xA65EF0", VA = "0x180A66AF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorMovement Clone()
	{
		return null;
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0xA66CA0", Offset = "0xA660A0", VA = "0x180A66CA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xA66C00", Offset = "0xA66000", VA = "0x180A66C00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorMovement other)
	{
		return default(bool);
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0xA66D90", Offset = "0xA66190", VA = "0x180A66D90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0xA66FA0", Offset = "0xA663A0", VA = "0x180A66FA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xA674D0", Offset = "0xA668D0", VA = "0x180A674D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0xA66990", Offset = "0xA65D90", VA = "0x180A66990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0xA66E90", Offset = "0xA66290", VA = "0x180A66E90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorMovement other)
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0xA67330", Offset = "0xA66730", VA = "0x180A67330", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
