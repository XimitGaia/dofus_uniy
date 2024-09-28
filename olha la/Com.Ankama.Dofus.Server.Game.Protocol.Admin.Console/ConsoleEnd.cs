using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console;

[Token(Token = "0x2000D06")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ConsoleEnd : IMessage<ConsoleEnd>, IMessage, IEquatable<ConsoleEnd>, IDeepCloneable<ConsoleEnd>, IBufferMessage
{
	[Token(Token = "0x4002FDA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ConsoleEnd> _parser;

	[Token(Token = "0x4002FDB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FDC")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002FDD")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001DF9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ConsoleEnd> Parser
	{
		[Token(Token = "0x6008933")]
		[Address(RVA = "0xCB1130", Offset = "0xCB0530", VA = "0x180CB1130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DFA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008934")]
		[Address(RVA = "0xCB1080", Offset = "0xCB0480", VA = "0x180CB1080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008935")]
		[Address(RVA = "0xCB1180", Offset = "0xCB0580", VA = "0x180CB1180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DFC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6008939")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600893A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008936")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleEnd()
	{
	}

	[Token(Token = "0x6008937")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ConsoleEnd(ConsoleEnd other)
	{
	}

	[Token(Token = "0x6008938")]
	[Address(RVA = "0xCB0D70", Offset = "0xCB0170", VA = "0x180CB0D70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleEnd Clone()
	{
		return null;
	}

	[Token(Token = "0x600893B")]
	[Address(RVA = "0xCB0DF0", Offset = "0xCB01F0", VA = "0x180CB0DF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600893C")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ConsoleEnd other)
	{
		return default(bool);
	}

	[Token(Token = "0x600893D")]
	[Address(RVA = "0xCB0E80", Offset = "0xCB0280", VA = "0x180CB0E80", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600893E")]
	[Address(RVA = "0xCB0F20", Offset = "0xCB0320", VA = "0x180CB0F20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600893F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008940")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008941")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008942")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ConsoleEnd other)
	{
	}

	[Token(Token = "0x6008943")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008944")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
