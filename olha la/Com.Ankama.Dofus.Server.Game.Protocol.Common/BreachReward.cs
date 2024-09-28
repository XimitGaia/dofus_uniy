using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200099E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachReward : IMessage<BreachReward>, IMessage, IEquatable<BreachReward>, IDeepCloneable<BreachReward>, IBufferMessage
{
	[Token(Token = "0x200099F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009A0")]
		public enum BreachRewardLock
		{
			[Token(Token = "0x40021DD")]
			[OriginalName("BREACH_REWARD_LOCK_OWNER")]
			Owner,
			[Token(Token = "0x40021DE")]
			[OriginalName("BREACH_REWARD_LOCK_FIGHTER")]
			Fighter,
			[Token(Token = "0x40021DF")]
			[OriginalName("BREACH_REWARD_LOCK_RESOURCES")]
			Resources,
			[Token(Token = "0x40021E0")]
			[OriginalName("BREACH_REWARD_LOCK_CRITERION")]
			Criterion,
			[Token(Token = "0x40021E1")]
			[OriginalName("BREACH_REWARD_LOCK_USELESS")]
			Useless,
			[Token(Token = "0x40021E2")]
			[OriginalName("BREACH_REWARD_MAX_PURCHASE_REACHED")]
			BreachRewardMaxPurchaseReached
		}
	}

	[Token(Token = "0x40021CF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachReward> _parser;

	[Token(Token = "0x40021D0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40021D1")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x40021D2")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x40021D3")]
	public const int BuyLocksFieldNumber = 2;

	[Token(Token = "0x40021D4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.BreachRewardLock> _repeated_buyLocks_codec;

	[Token(Token = "0x40021D5")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.BreachRewardLock> buyLocks_;

	[Token(Token = "0x40021D6")]
	public const int BuyCriterionFieldNumber = 3;

	[Token(Token = "0x40021D7")]
	[FieldOffset(Offset = "0x28")]
	private string buyCriterion_;

	[Token(Token = "0x40021D8")]
	public const int RemainingQuantityFieldNumber = 4;

	[Token(Token = "0x40021D9")]
	[FieldOffset(Offset = "0x30")]
	private int remainingQuantity_;

	[Token(Token = "0x40021DA")]
	public const int PriceFieldNumber = 5;

	[Token(Token = "0x40021DB")]
	[FieldOffset(Offset = "0x34")]
	private int price_;

	[Token(Token = "0x1700155F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachReward> Parser
	{
		[Token(Token = "0x6006446")]
		[Address(RVA = "0xB90830", Offset = "0xB8FC30", VA = "0x180B90830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001560")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006447")]
		[Address(RVA = "0xB90780", Offset = "0xB8FB80", VA = "0x180B90780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001561")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006448")]
		[Address(RVA = "0xB90B70", Offset = "0xB8FF70", VA = "0x180B90B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001562")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		[Token(Token = "0x600644C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600644D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001563")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.BreachRewardLock> BuyLocks
	{
		[Token(Token = "0x600644E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001564")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BuyCriterion
	{
		[Token(Token = "0x600644F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006450")]
		[Address(RVA = "0xB90C50", Offset = "0xB90050", VA = "0x180B90C50")]
		set
		{
		}
	}

	[Token(Token = "0x17001565")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RemainingQuantity
	{
		[Token(Token = "0x6006451")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006452")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001566")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Price
	{
		[Token(Token = "0x6006453")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x6006449")]
	[Address(RVA = "0xB906E0", Offset = "0xB8FAE0", VA = "0x180B906E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachReward()
	{
	}

	[Token(Token = "0x600644A")]
	[Address(RVA = "0xB90630", Offset = "0xB8FA30", VA = "0x180B90630")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachReward(BreachReward other)
	{
	}

	[Token(Token = "0x600644B")]
	[Address(RVA = "0xB8FFA0", Offset = "0xB8F3A0", VA = "0x180B8FFA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachReward Clone()
	{
		return null;
	}

	[Token(Token = "0x6006455")]
	[Address(RVA = "0xB90140", Offset = "0xB8F540", VA = "0x180B90140", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006456")]
	[Address(RVA = "0xB90080", Offset = "0xB8F480", VA = "0x180B90080", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachReward other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006457")]
	[Address(RVA = "0xB90240", Offset = "0xB8F640", VA = "0x180B90240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006458")]
	[Address(RVA = "0xB903E0", Offset = "0xB8F7E0", VA = "0x180B903E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006459")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600645A")]
	[Address(RVA = "0xB90A20", Offset = "0xB8FE20", VA = "0x180B90A20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600645B")]
	[Address(RVA = "0xB8FE30", Offset = "0xB8F230", VA = "0x180B8FE30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600645C")]
	[Address(RVA = "0xB90320", Offset = "0xB8F720", VA = "0x180B90320", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachReward other)
	{
	}

	[Token(Token = "0x600645D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600645E")]
	[Address(RVA = "0xB90880", Offset = "0xB8FC80", VA = "0x180B90880", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
