using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000301")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountToggleRidingRequest : IMessage<MountToggleRidingRequest>, IMessage, IEquatable<MountToggleRidingRequest>, IDeepCloneable<MountToggleRidingRequest>, IBufferMessage
{
	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountToggleRidingRequest> _parser;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170006B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountToggleRidingRequest> Parser
	{
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0xD23A20", Offset = "0xD22E20", VA = "0x180D23A20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0xD23970", Offset = "0xD22D70", VA = "0x180D23970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0xD23A70", Offset = "0xD22E70", VA = "0x180D23A70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountToggleRidingRequest()
	{
	}

	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountToggleRidingRequest(MountToggleRidingRequest other)
	{
	}

	[Token(Token = "0x6001F32")]
	[Address(RVA = "0xD23710", Offset = "0xD22B10", VA = "0x180D23710", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountToggleRidingRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F33")]
	[Address(RVA = "0xD23790", Offset = "0xD22B90", VA = "0x180D23790", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountToggleRidingRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F36")]
	[Address(RVA = "0xD23810", Offset = "0xD22C10", VA = "0x180D23810", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountToggleRidingRequest other)
	{
	}

	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
