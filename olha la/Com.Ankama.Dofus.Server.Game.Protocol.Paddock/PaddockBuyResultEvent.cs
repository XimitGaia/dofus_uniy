using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002BB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockBuyResultEvent : IMessage<PaddockBuyResultEvent>, IMessage, IEquatable<PaddockBuyResultEvent>, IDeepCloneable<PaddockBuyResultEvent>, IBufferMessage
{
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockBuyResultEvent> _parser;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400099B")]
	public const int PaddockIdFieldNumber = 1;

	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x18")]
	private long paddockId_;

	[Token(Token = "0x400099D")]
	public const int BoughtFieldNumber = 2;

	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x20")]
	private bool bought_;

	[Token(Token = "0x400099F")]
	public const int PriceFieldNumber = 3;

	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x28")]
	private long price_;

	[Token(Token = "0x17000621")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddockBuyResultEvent> Parser
	{
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0xD06800", Offset = "0xD05C00", VA = "0x180D06800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000622")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0xD06750", Offset = "0xD05B50", VA = "0x180D06750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000623")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0xD069D0", Offset = "0xD05DD0", VA = "0x180D069D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000624")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PaddockId
	{
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000625")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Bought
	{
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000626")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Price
	{
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockBuyResultEvent()
	{
	}

	[Token(Token = "0x6001C78")]
	[Address(RVA = "0xD066F0", Offset = "0xD05AF0", VA = "0x180D066F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockBuyResultEvent(PaddockBuyResultEvent other)
	{
	}

	[Token(Token = "0x6001C79")]
	[Address(RVA = "0xD062D0", Offset = "0xD056D0", VA = "0x180D062D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockBuyResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C80")]
	[Address(RVA = "0xD063A0", Offset = "0xD057A0", VA = "0x180D063A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C81")]
	[Address(RVA = "0xD06360", Offset = "0xD05760", VA = "0x180D06360", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockBuyResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C82")]
	[Address(RVA = "0xD06440", Offset = "0xD05840", VA = "0x180D06440", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C83")]
	[Address(RVA = "0xD06590", Offset = "0xD05990", VA = "0x180D06590", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C85")]
	[Address(RVA = "0xD06930", Offset = "0xD05D30", VA = "0x180D06930", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C86")]
	[Address(RVA = "0xD06200", Offset = "0xD05600", VA = "0x180D06200", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C87")]
	[Address(RVA = "0xD06520", Offset = "0xD05920", VA = "0x180D06520", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockBuyResultEvent other)
	{
	}

	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C89")]
	[Address(RVA = "0xD06850", Offset = "0xD05C50", VA = "0x180D06850", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
