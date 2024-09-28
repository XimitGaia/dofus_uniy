using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A4B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTriggeredEffect : IMessage<FightTriggeredEffect>, IMessage, IEquatable<FightTriggeredEffect>, IDeepCloneable<FightTriggeredEffect>, IBufferMessage
{
	[Token(Token = "0x4002528")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTriggeredEffect> _parser;

	[Token(Token = "0x4002529")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400252A")]
	public const int FirstParamFieldNumber = 1;

	[Token(Token = "0x400252B")]
	[FieldOffset(Offset = "0x18")]
	private int firstParam_;

	[Token(Token = "0x400252C")]
	public const int SecondParamFieldNumber = 2;

	[Token(Token = "0x400252D")]
	[FieldOffset(Offset = "0x1C")]
	private int secondParam_;

	[Token(Token = "0x400252E")]
	public const int ThirdParamFieldNumber = 3;

	[Token(Token = "0x400252F")]
	[FieldOffset(Offset = "0x20")]
	private int thirdParam_;

	[Token(Token = "0x4002530")]
	public const int DelayFieldNumber = 4;

	[Token(Token = "0x4002531")]
	[FieldOffset(Offset = "0x24")]
	private int delay_;

	[Token(Token = "0x17001748")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTriggeredEffect> Parser
	{
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0xBCEED0", Offset = "0xBCE2D0", VA = "0x180BCEED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001749")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0xBCEE20", Offset = "0xBCE220", VA = "0x180BCEE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700174A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0xBCEF20", Offset = "0xBCE320", VA = "0x180BCEF20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700174B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FirstParam
	{
		[Token(Token = "0x6006BA5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BA6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700174C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SecondParam
	{
		[Token(Token = "0x6006BA7")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700174D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ThirdParam
	{
		[Token(Token = "0x6006BA9")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700174E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Delay
	{
		[Token(Token = "0x6006BAB")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BAC")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6006BA2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTriggeredEffect()
	{
	}

	[Token(Token = "0x6006BA3")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTriggeredEffect(FightTriggeredEffect other)
	{
	}

	[Token(Token = "0x6006BA4")]
	[Address(RVA = "0xBCEB90", Offset = "0xBCDF90", VA = "0x180BCEB90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTriggeredEffect Clone()
	{
		return null;
	}

	[Token(Token = "0x6006BAD")]
	[Address(RVA = "0xBCEC20", Offset = "0xBCE020", VA = "0x180BCEC20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006BAE")]
	[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTriggeredEffect other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006BAF")]
	[Address(RVA = "0xBADA20", Offset = "0xBACE20", VA = "0x180BADA20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006BB0")]
	[Address(RVA = "0xBCECC0", Offset = "0xBCE0C0", VA = "0x180BCECC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006BB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006BB2")]
	[Address(RVA = "0xBADD40", Offset = "0xBAD140", VA = "0x180BADD40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006BB3")]
	[Address(RVA = "0xBCEA80", Offset = "0xBCDE80", VA = "0x180BCEA80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006BB4")]
	[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightTriggeredEffect other)
	{
	}

	[Token(Token = "0x6006BB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006BB6")]
	[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
