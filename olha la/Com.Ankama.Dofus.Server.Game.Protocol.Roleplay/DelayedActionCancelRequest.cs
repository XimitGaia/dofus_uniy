using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200016A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DelayedActionCancelRequest : IMessage<DelayedActionCancelRequest>, IMessage, IEquatable<DelayedActionCancelRequest>, IDeepCloneable<DelayedActionCancelRequest>, IBufferMessage
{
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DelayedActionCancelRequest> _parser;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170002FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DelayedActionCancelRequest> Parser
	{
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0xC430A0", Offset = "0xC424A0", VA = "0x180C430A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0xC42FF0", Offset = "0xC423F0", VA = "0x180C42FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000301")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0xC430F0", Offset = "0xC424F0", VA = "0x180C430F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionCancelRequest()
	{
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedActionCancelRequest(DelayedActionCancelRequest other)
	{
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0xC42D90", Offset = "0xC42190", VA = "0x180C42D90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DelayedActionCancelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0xC42E10", Offset = "0xC42210", VA = "0x180C42E10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DelayedActionCancelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0xC42E90", Offset = "0xC42290", VA = "0x180C42E90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DelayedActionCancelRequest other)
	{
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
