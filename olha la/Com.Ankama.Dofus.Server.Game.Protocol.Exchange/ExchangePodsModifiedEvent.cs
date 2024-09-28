using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006A5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangePodsModifiedEvent : IMessage<ExchangePodsModifiedEvent>, IMessage, IEquatable<ExchangePodsModifiedEvent>, IDeepCloneable<ExchangePodsModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangePodsModifiedEvent> _parser;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001742")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001744")]
	public const int CurrentWeightFieldNumber = 2;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x1C")]
	private int currentWeight_;

	[Token(Token = "0x4001746")]
	public const int MaxWeightFieldNumber = 3;

	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x20")]
	private int maxWeight_;

	[Token(Token = "0x17000F3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangePodsModifiedEvent> Parser
	{
		[Token(Token = "0x6004753")]
		[Address(RVA = "0xA96180", Offset = "0xA95580", VA = "0x180A96180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004754")]
		[Address(RVA = "0xA960D0", Offset = "0xA954D0", VA = "0x180A960D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004755")]
		[Address(RVA = "0xA961D0", Offset = "0xA955D0", VA = "0x180A961D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x6004759")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentWeight
	{
		[Token(Token = "0x600475B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600475C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F42")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxWeight
	{
		[Token(Token = "0x600475D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600475E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6004756")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangePodsModifiedEvent()
	{
	}

	[Token(Token = "0x6004757")]
	[Address(RVA = "0xA89F20", Offset = "0xA89320", VA = "0x180A89F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangePodsModifiedEvent(ExchangePodsModifiedEvent other)
	{
	}

	[Token(Token = "0x6004758")]
	[Address(RVA = "0xA95D60", Offset = "0xA95160", VA = "0x180A95D60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangePodsModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600475F")]
	[Address(RVA = "0xA95DF0", Offset = "0xA951F0", VA = "0x180A95DF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004760")]
	[Address(RVA = "0xA89B90", Offset = "0xA88F90", VA = "0x180A89B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangePodsModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004761")]
	[Address(RVA = "0xA95E90", Offset = "0xA95290", VA = "0x180A95E90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004762")]
	[Address(RVA = "0xA95F70", Offset = "0xA95370", VA = "0x180A95F70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004763")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004764")]
	[Address(RVA = "0xA8A150", Offset = "0xA89550", VA = "0x180A8A150", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004765")]
	[Address(RVA = "0xA95CA0", Offset = "0xA950A0", VA = "0x180A95CA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004766")]
	[Address(RVA = "0xA89D50", Offset = "0xA89150", VA = "0x180A89D50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangePodsModifiedEvent other)
	{
	}

	[Token(Token = "0x6004767")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004768")]
	[Address(RVA = "0xA8A080", Offset = "0xA89480", VA = "0x180A8A080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
