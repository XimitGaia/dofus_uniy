using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C5C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationDeletionRequest : IMessage<AllianceApplicationDeletionRequest>, IMessage, IEquatable<AllianceApplicationDeletionRequest>, IDeepCloneable<AllianceApplicationDeletionRequest>, IBufferMessage
{
	[Token(Token = "0x4002DC3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationDeletionRequest> _parser;

	[Token(Token = "0x4002DC4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001C84")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationDeletionRequest> Parser
	{
		[Token(Token = "0x6008207")]
		[Address(RVA = "0xC6F720", Offset = "0xC6EB20", VA = "0x180C6F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C85")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008208")]
		[Address(RVA = "0xC6F670", Offset = "0xC6EA70", VA = "0x180C6F670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C86")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008209")]
		[Address(RVA = "0xC6F770", Offset = "0xC6EB70", VA = "0x180C6F770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600820A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationDeletionRequest()
	{
	}

	[Token(Token = "0x600820B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationDeletionRequest(AllianceApplicationDeletionRequest other)
	{
	}

	[Token(Token = "0x600820C")]
	[Address(RVA = "0xC6F410", Offset = "0xC6E810", VA = "0x180C6F410", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationDeletionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600820D")]
	[Address(RVA = "0xC6F490", Offset = "0xC6E890", VA = "0x180C6F490", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600820E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceApplicationDeletionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600820F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008210")]
	[Address(RVA = "0xC6F510", Offset = "0xC6E910", VA = "0x180C6F510", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008211")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008212")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008213")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008214")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceApplicationDeletionRequest other)
	{
	}

	[Token(Token = "0x6008215")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008216")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
