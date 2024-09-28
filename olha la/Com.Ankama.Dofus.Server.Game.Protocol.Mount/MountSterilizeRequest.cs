using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x20002FF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountSterilizeRequest : IMessage<MountSterilizeRequest>, IMessage, IEquatable<MountSterilizeRequest>, IDeepCloneable<MountSterilizeRequest>, IBufferMessage
{
	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountSterilizeRequest> _parser;

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006B6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountSterilizeRequest> Parser
	{
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0xD23100", Offset = "0xD22500", VA = "0x180D23100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0xD23050", Offset = "0xD22450", VA = "0x180D23050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0xD23150", Offset = "0xD22550", VA = "0x180D23150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountSterilizeRequest()
	{
	}

	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountSterilizeRequest(MountSterilizeRequest other)
	{
	}

	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0xD22DF0", Offset = "0xD221F0", VA = "0x180D22DF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountSterilizeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0xD22E70", Offset = "0xD22270", VA = "0x180D22E70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountSterilizeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F22")]
	[Address(RVA = "0xD22EF0", Offset = "0xD222F0", VA = "0x180D22EF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F24")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F25")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountSterilizeRequest other)
	{
	}

	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
