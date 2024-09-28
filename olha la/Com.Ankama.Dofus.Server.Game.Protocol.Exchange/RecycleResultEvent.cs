using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200072C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RecycleResultEvent : IMessage<RecycleResultEvent>, IMessage, IEquatable<RecycleResultEvent>, IDeepCloneable<RecycleResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001943")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RecycleResultEvent> _parser;

	[Token(Token = "0x4001944")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001945")]
	public const int PrismNuggetsFieldNumber = 1;

	[Token(Token = "0x4001946")]
	[FieldOffset(Offset = "0x18")]
	private int prismNuggets_;

	[Token(Token = "0x4001947")]
	public const int PlayerNuggetsFieldNumber = 2;

	[Token(Token = "0x4001948")]
	[FieldOffset(Offset = "0x1C")]
	private int playerNuggets_;

	[Token(Token = "0x1700107E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RecycleResultEvent> Parser
	{
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0xAC5890", Offset = "0xAC4C90", VA = "0x180AC5890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700107F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0xAC57E0", Offset = "0xAC4BE0", VA = "0x180AC57E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001080")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004D10")]
		[Address(RVA = "0xAC58E0", Offset = "0xAC4CE0", VA = "0x180AC58E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001081")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrismNuggets
	{
		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001082")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PlayerNuggets
	{
		[Token(Token = "0x6004D16")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004D11")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecycleResultEvent()
	{
	}

	[Token(Token = "0x6004D12")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecycleResultEvent(RecycleResultEvent other)
	{
	}

	[Token(Token = "0x6004D13")]
	[Address(RVA = "0xAC5560", Offset = "0xAC4960", VA = "0x180AC5560", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RecycleResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004D18")]
	[Address(RVA = "0xAC55F0", Offset = "0xAC49F0", VA = "0x180AC55F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D19")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RecycleResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D1A")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004D1B")]
	[Address(RVA = "0xAC5680", Offset = "0xAC4A80", VA = "0x180AC5680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004D1C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004D1D")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004D1E")]
	[Address(RVA = "0xAC54A0", Offset = "0xAC48A0", VA = "0x180AC54A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004D1F")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RecycleResultEvent other)
	{
	}

	[Token(Token = "0x6004D20")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004D21")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
