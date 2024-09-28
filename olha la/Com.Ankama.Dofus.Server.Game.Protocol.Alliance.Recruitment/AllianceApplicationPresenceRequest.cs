using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C66")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationPresenceRequest : IMessage<AllianceApplicationPresenceRequest>, IMessage, IEquatable<AllianceApplicationPresenceRequest>, IDeepCloneable<AllianceApplicationPresenceRequest>, IBufferMessage
{
	[Token(Token = "0x4002DDC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationPresenceRequest> _parser;

	[Token(Token = "0x4002DDD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001C98")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceApplicationPresenceRequest> Parser
	{
		[Token(Token = "0x6008275")]
		[Address(RVA = "0xC72B20", Offset = "0xC71F20", VA = "0x180C72B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C99")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008276")]
		[Address(RVA = "0xC72A70", Offset = "0xC71E70", VA = "0x180C72A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008277")]
		[Address(RVA = "0xC72B70", Offset = "0xC71F70", VA = "0x180C72B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008278")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationPresenceRequest()
	{
	}

	[Token(Token = "0x6008279")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationPresenceRequest(AllianceApplicationPresenceRequest other)
	{
	}

	[Token(Token = "0x600827A")]
	[Address(RVA = "0xC72810", Offset = "0xC71C10", VA = "0x180C72810", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationPresenceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600827B")]
	[Address(RVA = "0xC72890", Offset = "0xC71C90", VA = "0x180C72890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600827C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationPresenceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600827D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600827E")]
	[Address(RVA = "0xC72910", Offset = "0xC71D10", VA = "0x180C72910", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600827F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008280")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008281")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008282")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationPresenceRequest other)
	{
	}

	[Token(Token = "0x6008283")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008284")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
