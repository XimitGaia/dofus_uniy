using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console;

[Token(Token = "0x2000D04")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ConsoleCommand : IMessage<ConsoleCommand>, IMessage, IEquatable<ConsoleCommand>, IDeepCloneable<ConsoleCommand>, IBufferMessage
{
	[Token(Token = "0x4002FD3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ConsoleCommand> _parser;

	[Token(Token = "0x4002FD4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FD5")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4002FD6")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x4002FD7")]
	public const int QuietFieldNumber = 2;

	[Token(Token = "0x4002FD8")]
	[FieldOffset(Offset = "0x20")]
	private bool quiet_;

	[Token(Token = "0x17001DF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ConsoleCommand> Parser
	{
		[Token(Token = "0x600891B")]
		[Address(RVA = "0xCB0A60", Offset = "0xCAFE60", VA = "0x180CB0A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600891C")]
		[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600891D")]
		[Address(RVA = "0xCB0C20", Offset = "0xCB0020", VA = "0x180CB0C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DF7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Content
	{
		[Token(Token = "0x6008921")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008922")]
		[Address(RVA = "0xCB0D00", Offset = "0xCB0100", VA = "0x180CB0D00")]
		set
		{
		}
	}

	[Token(Token = "0x17001DF8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Quiet
	{
		[Token(Token = "0x6008923")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008924")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x600891E")]
	[Address(RVA = "0xCB0960", Offset = "0xCAFD60", VA = "0x180CB0960")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleCommand()
	{
	}

	[Token(Token = "0x600891F")]
	[Address(RVA = "0xCB08B0", Offset = "0xCAFCB0", VA = "0x180CB08B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleCommand(ConsoleCommand other)
	{
	}

	[Token(Token = "0x6008920")]
	[Address(RVA = "0xCB0430", Offset = "0xCAF830", VA = "0x180CB0430", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleCommand Clone()
	{
		return null;
	}

	[Token(Token = "0x6008925")]
	[Address(RVA = "0xCB0570", Offset = "0xCAF970", VA = "0x180CB0570", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008926")]
	[Address(RVA = "0xCB0500", Offset = "0xCAF900", VA = "0x180CB0500", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ConsoleCommand other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008927")]
	[Address(RVA = "0xCB0620", Offset = "0xCAFA20", VA = "0x180CB0620", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008928")]
	[Address(RVA = "0xCB0750", Offset = "0xCAFB50", VA = "0x180CB0750", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008929")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600892A")]
	[Address(RVA = "0xCB0B90", Offset = "0xCAFF90", VA = "0x180CB0B90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600892B")]
	[Address(RVA = "0xCB03A0", Offset = "0xCAF7A0", VA = "0x180CB03A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600892C")]
	[Address(RVA = "0xCB06E0", Offset = "0xCAFAE0", VA = "0x180CB06E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ConsoleCommand other)
	{
	}

	[Token(Token = "0x600892D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600892E")]
	[Address(RVA = "0xCB0AB0", Offset = "0xCAFEB0", VA = "0x180CB0AB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
