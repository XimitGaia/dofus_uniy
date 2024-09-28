using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CD7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightListenStopRequest : IMessage<AllianceFightListenStopRequest>, IMessage, IEquatable<AllianceFightListenStopRequest>, IDeepCloneable<AllianceFightListenStopRequest>, IBufferMessage
{
	[Token(Token = "0x4002F4B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightListenStopRequest> _parser;

	[Token(Token = "0x4002F4C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001D96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightListenStopRequest> Parser
	{
		[Token(Token = "0x600874C")]
		[Address(RVA = "0xCACA30", Offset = "0xCABE30", VA = "0x180CACA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600874D")]
		[Address(RVA = "0xCAC980", Offset = "0xCABD80", VA = "0x180CAC980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D98")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600874E")]
		[Address(RVA = "0xCACA80", Offset = "0xCABE80", VA = "0x180CACA80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600874F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightListenStopRequest()
	{
	}

	[Token(Token = "0x6008750")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightListenStopRequest(AllianceFightListenStopRequest other)
	{
	}

	[Token(Token = "0x6008751")]
	[Address(RVA = "0xCAC720", Offset = "0xCABB20", VA = "0x180CAC720", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightListenStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008752")]
	[Address(RVA = "0xCAC7A0", Offset = "0xCABBA0", VA = "0x180CAC7A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008753")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightListenStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008754")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008755")]
	[Address(RVA = "0xCAC820", Offset = "0xCABC20", VA = "0x180CAC820", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008756")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008757")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008758")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008759")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightListenStopRequest other)
	{
	}

	[Token(Token = "0x600875A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600875B")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
