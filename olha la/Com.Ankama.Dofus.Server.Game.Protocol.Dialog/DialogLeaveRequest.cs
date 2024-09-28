using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog;

[Token(Token = "0x200075E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DialogLeaveRequest : IMessage<DialogLeaveRequest>, IMessage, IEquatable<DialogLeaveRequest>, IDeepCloneable<DialogLeaveRequest>, IBufferMessage
{
	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DialogLeaveRequest> _parser;

	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170010E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DialogLeaveRequest> Parser
	{
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0xADA590", Offset = "0xAD9990", VA = "0x180ADA590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0xADA4E0", Offset = "0xAD98E0", VA = "0x180ADA4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0xADA5E0", Offset = "0xAD99E0", VA = "0x180ADA5E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004EDD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogLeaveRequest()
	{
	}

	[Token(Token = "0x6004EDE")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DialogLeaveRequest(DialogLeaveRequest other)
	{
	}

	[Token(Token = "0x6004EDF")]
	[Address(RVA = "0xADA280", Offset = "0xAD9680", VA = "0x180ADA280", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogLeaveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004EE0")]
	[Address(RVA = "0xADA300", Offset = "0xAD9700", VA = "0x180ADA300", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EE1")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DialogLeaveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EE2")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004EE3")]
	[Address(RVA = "0xADA380", Offset = "0xAD9780", VA = "0x180ADA380", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004EE4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004EE5")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004EE6")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004EE7")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DialogLeaveRequest other)
	{
	}

	[Token(Token = "0x6004EE8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004EE9")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
