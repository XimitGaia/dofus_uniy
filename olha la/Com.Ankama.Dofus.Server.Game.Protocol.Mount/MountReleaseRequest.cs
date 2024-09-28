using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x20002FD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountReleaseRequest : IMessage<MountReleaseRequest>, IMessage, IEquatable<MountReleaseRequest>, IDeepCloneable<MountReleaseRequest>, IBufferMessage
{
	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountReleaseRequest> _parser;

	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountReleaseRequest> Parser
	{
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0xD20DC0", Offset = "0xD201C0", VA = "0x180D20DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0xD20D10", Offset = "0xD20110", VA = "0x180D20D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0xD20E10", Offset = "0xD20210", VA = "0x180D20E10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleaseRequest()
	{
	}

	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleaseRequest(MountReleaseRequest other)
	{
	}

	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0xD20AB0", Offset = "0xD1FEB0", VA = "0x180D20AB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleaseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0xD20B30", Offset = "0xD1FF30", VA = "0x180D20B30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountReleaseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0xD20BB0", Offset = "0xD1FFB0", VA = "0x180D20BB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountReleaseRequest other)
	{
	}

	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
