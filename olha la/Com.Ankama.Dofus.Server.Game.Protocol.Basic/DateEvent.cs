using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B40")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DateEvent : IMessage<DateEvent>, IMessage, IEquatable<DateEvent>, IDeepCloneable<DateEvent>, IBufferMessage
{
	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DateEvent> _parser;

	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A04")]
	public const int DayFieldNumber = 1;

	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x18")]
	private int day_;

	[Token(Token = "0x4002A06")]
	public const int MonthFieldNumber = 2;

	[Token(Token = "0x4002A07")]
	[FieldOffset(Offset = "0x1C")]
	private int month_;

	[Token(Token = "0x4002A08")]
	public const int YearFieldNumber = 3;

	[Token(Token = "0x4002A09")]
	[FieldOffset(Offset = "0x20")]
	private int year_;

	[Token(Token = "0x17001A20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DateEvent> Parser
	{
		[Token(Token = "0x6007696")]
		[Address(RVA = "0xC23D10", Offset = "0xC23110", VA = "0x180C23D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007697")]
		[Address(RVA = "0xC23C60", Offset = "0xC23060", VA = "0x180C23C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007698")]
		[Address(RVA = "0xC23D60", Offset = "0xC23160", VA = "0x180C23D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A23")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Day
	{
		[Token(Token = "0x600769C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600769D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001A24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Month
	{
		[Token(Token = "0x600769E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600769F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Year
	{
		[Token(Token = "0x60076A0")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60076A1")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6007699")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DateEvent()
	{
	}

	[Token(Token = "0x600769A")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DateEvent(DateEvent other)
	{
	}

	[Token(Token = "0x600769B")]
	[Address(RVA = "0xC239D0", Offset = "0xC22DD0", VA = "0x180C239D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60076A2")]
	[Address(RVA = "0xC23A60", Offset = "0xC22E60", VA = "0x180C23A60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076A3")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076A4")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60076A5")]
	[Address(RVA = "0xC23B00", Offset = "0xC22F00", VA = "0x180C23B00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60076A6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60076A7")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60076A8")]
	[Address(RVA = "0xC238F0", Offset = "0xC22CF0", VA = "0x180C238F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60076A9")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DateEvent other)
	{
	}

	[Token(Token = "0x60076AA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60076AB")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
