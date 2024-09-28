using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000670")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeFocusedReadyRequest : IMessage<ExchangeFocusedReadyRequest>, IMessage, IEquatable<ExchangeFocusedReadyRequest>, IDeepCloneable<ExchangeFocusedReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeFocusedReadyRequest> _parser;

	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001683")]
	public const int ReadyFieldNumber = 1;

	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x18")]
	private bool ready_;

	[Token(Token = "0x4001685")]
	public const int StepFieldNumber = 2;

	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x1C")]
	private int step_;

	[Token(Token = "0x4001687")]
	public const int FocusActionIdFieldNumber = 3;

	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0x20")]
	private int focusActionId_;

	[Token(Token = "0x17000EC5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeFocusedReadyRequest> Parser
	{
		[Token(Token = "0x600450B")]
		[Address(RVA = "0xA8A030", Offset = "0xA89430", VA = "0x180A8A030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600450C")]
		[Address(RVA = "0xA89F80", Offset = "0xA89380", VA = "0x180A89F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600450D")]
		[Address(RVA = "0xA8A1F0", Offset = "0xA895F0", VA = "0x180A8A1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Ready
	{
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Step
	{
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FocusActionId
	{
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600450E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeFocusedReadyRequest()
	{
	}

	[Token(Token = "0x600450F")]
	[Address(RVA = "0xA89F20", Offset = "0xA89320", VA = "0x180A89F20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeFocusedReadyRequest(ExchangeFocusedReadyRequest other)
	{
	}

	[Token(Token = "0x6004510")]
	[Address(RVA = "0xA89B00", Offset = "0xA88F00", VA = "0x180A89B00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeFocusedReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004517")]
	[Address(RVA = "0xA89BD0", Offset = "0xA88FD0", VA = "0x180A89BD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004518")]
	[Address(RVA = "0xA89B90", Offset = "0xA88F90", VA = "0x180A89B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeFocusedReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0xA89C70", Offset = "0xA89070", VA = "0x180A89C70", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600451A")]
	[Address(RVA = "0xA89DC0", Offset = "0xA891C0", VA = "0x180A89DC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0xA8A150", Offset = "0xA89550", VA = "0x180A8A150", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600451D")]
	[Address(RVA = "0xA89A40", Offset = "0xA88E40", VA = "0x180A89A40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600451E")]
	[Address(RVA = "0xA89D50", Offset = "0xA89150", VA = "0x180A89D50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeFocusedReadyRequest other)
	{
	}

	[Token(Token = "0x600451F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004520")]
	[Address(RVA = "0xA8A080", Offset = "0xA89480", VA = "0x180A8A080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
