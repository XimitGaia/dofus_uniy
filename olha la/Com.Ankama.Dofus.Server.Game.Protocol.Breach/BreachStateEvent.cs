using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000903")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachStateEvent : IMessage<BreachStateEvent>, IMessage, IEquatable<BreachStateEvent>, IDeepCloneable<BreachStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001ED4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachStateEvent> _parser;

	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001ED6")]
	public const int OwnerFieldNumber = 1;

	[Token(Token = "0x4001ED7")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character owner_;

	[Token(Token = "0x4001ED8")]
	public const int BonusesFieldNumber = 2;

	[Token(Token = "0x4001ED9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_bonuses_codec;

	[Token(Token = "0x4001EDA")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectEffect> bonuses_;

	[Token(Token = "0x4001EDB")]
	public const int BudgetFieldNumber = 3;

	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0x28")]
	private int budget_;

	[Token(Token = "0x4001EDD")]
	public const int SavedFieldNumber = 4;

	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0x2C")]
	private bool saved_;

	[Token(Token = "0x1700142A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachStateEvent> Parser
	{
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0xB578C0", Offset = "0xB56CC0", VA = "0x180B578C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700142B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0xB57810", Offset = "0xB56C10", VA = "0x180B57810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700142C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0xB57BE0", Offset = "0xB56FE0", VA = "0x180B57BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700142D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Owner
	{
		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005F50")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700142E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Bonuses
	{
		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700142F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Budget
	{
		[Token(Token = "0x6005F52")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005F53")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Saved
	{
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x6005F4C")]
	[Address(RVA = "0xB576D0", Offset = "0xB56AD0", VA = "0x180B576D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachStateEvent()
	{
	}

	[Token(Token = "0x6005F4D")]
	[Address(RVA = "0xB57750", Offset = "0xB56B50", VA = "0x180B57750")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachStateEvent(BreachStateEvent other)
	{
	}

	[Token(Token = "0x6005F4E")]
	[Address(RVA = "0xB57020", Offset = "0xB56420", VA = "0x180B57020", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F56")]
	[Address(RVA = "0xB571D0", Offset = "0xB565D0", VA = "0x180B571D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F57")]
	[Address(RVA = "0xB57110", Offset = "0xB56510", VA = "0x180B57110", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F58")]
	[Address(RVA = "0xB572D0", Offset = "0xB566D0", VA = "0x180B572D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F59")]
	[Address(RVA = "0xB574D0", Offset = "0xB568D0", VA = "0x180B574D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F5A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F5B")]
	[Address(RVA = "0xB57AC0", Offset = "0xB56EC0", VA = "0x180B57AC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F5C")]
	[Address(RVA = "0xB56F00", Offset = "0xB56300", VA = "0x180B56F00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F5D")]
	[Address(RVA = "0xB573D0", Offset = "0xB567D0", VA = "0x180B573D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachStateEvent other)
	{
	}

	[Token(Token = "0x6005F5E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F5F")]
	[Address(RVA = "0xB57910", Offset = "0xB56D10", VA = "0x180B57910", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
