using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000875")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateLifePointsEvent : IMessage<UpdateLifePointsEvent>, IMessage, IEquatable<UpdateLifePointsEvent>, IDeepCloneable<UpdateLifePointsEvent>, IBufferMessage
{
	[Token(Token = "0x4001D4C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UpdateLifePointsEvent> _parser;

	[Token(Token = "0x4001D4D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D4E")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4001D4F")]
	public const int LifePointsFieldNumber = 1;

	[Token(Token = "0x4001D50")]
	[FieldOffset(Offset = "0x1C")]
	private int lifePoints_;

	[Token(Token = "0x4001D51")]
	public const int MaxLifePointsFieldNumber = 2;

	[Token(Token = "0x4001D52")]
	[FieldOffset(Offset = "0x20")]
	private int maxLifePoints_;

	[Token(Token = "0x4001D53")]
	public const int LifePointsGainedFieldNumber = 3;

	[Token(Token = "0x4001D54")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int LifePointsGainedDefaultValue;

	[Token(Token = "0x4001D55")]
	[FieldOffset(Offset = "0x24")]
	private int lifePointsGained_;

	[Token(Token = "0x17001325")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateLifePointsEvent> Parser
	{
		[Token(Token = "0x60059EF")]
		[Address(RVA = "0xB2C210", Offset = "0xB2B610", VA = "0x180B2C210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001326")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60059F0")]
		[Address(RVA = "0xB2C0F0", Offset = "0xB2B4F0", VA = "0x180B2C0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001327")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60059F1")]
		[Address(RVA = "0xB2C340", Offset = "0xB2B740", VA = "0x180B2C340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001328")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LifePoints
	{
		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001329")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLifePoints
	{
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700132A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LifePointsGained
	{
		[Token(Token = "0x60059F9")]
		[Address(RVA = "0xB2C1A0", Offset = "0xB2B5A0", VA = "0x180B2C1A0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x945AB0", Offset = "0x944EB0", VA = "0x180945AB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700132B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasLifePointsGained
	{
		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60059F2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateLifePointsEvent()
	{
	}

	[Token(Token = "0x60059F3")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateLifePointsEvent(UpdateLifePointsEvent other)
	{
	}

	[Token(Token = "0x60059F4")]
	[Address(RVA = "0xB2BC50", Offset = "0xB2B050", VA = "0x180B2BC50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateLifePointsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60059FC")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearLifePointsGained()
	{
	}

	[Token(Token = "0x60059FD")]
	[Address(RVA = "0xB2BD60", Offset = "0xB2B160", VA = "0x180B2BD60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059FE")]
	[Address(RVA = "0xB2BCE0", Offset = "0xB2B0E0", VA = "0x180B2BCE0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(UpdateLifePointsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059FF")]
	[Address(RVA = "0xB2BE20", Offset = "0xB2B220", VA = "0x180B2BE20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A00")]
	[Address(RVA = "0xB2BF80", Offset = "0xB2B380", VA = "0x180B2BF80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A01")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A02")]
	[Address(RVA = "0xB2C260", Offset = "0xB2B660", VA = "0x180B2C260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A03")]
	[Address(RVA = "0xB2BB20", Offset = "0xB2AF20", VA = "0x180B2BB20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A04")]
	[Address(RVA = "0xB2BF10", Offset = "0xB2B310", VA = "0x180B2BF10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateLifePointsEvent other)
	{
	}

	[Token(Token = "0x6005A05")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A06")]
	[Address(RVA = "0x945820", Offset = "0x944C20", VA = "0x180945820", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
