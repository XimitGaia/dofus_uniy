using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C79")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRankCreationRequest : IMessage<AllianceRankCreationRequest>, IMessage, IEquatable<AllianceRankCreationRequest>, IDeepCloneable<AllianceRankCreationRequest>, IBufferMessage
{
	[Token(Token = "0x4002E17")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRankCreationRequest> _parser;

	[Token(Token = "0x4002E18")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E19")]
	public const int ParentRankIdFieldNumber = 1;

	[Token(Token = "0x4002E1A")]
	[FieldOffset(Offset = "0x18")]
	private int parentRankId_;

	[Token(Token = "0x4002E1B")]
	public const int GfxIdFieldNumber = 2;

	[Token(Token = "0x4002E1C")]
	[FieldOffset(Offset = "0x1C")]
	private int gfxId_;

	[Token(Token = "0x4002E1D")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4002E1E")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x17001CC3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRankCreationRequest> Parser
	{
		[Token(Token = "0x6008348")]
		[Address(RVA = "0xC772F0", Offset = "0xC766F0", VA = "0x180C772F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008349")]
		[Address(RVA = "0xC77240", Offset = "0xC76640", VA = "0x180C77240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600834A")]
		[Address(RVA = "0xC77430", Offset = "0xC76830", VA = "0x180C77430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ParentRankId
	{
		[Token(Token = "0x600834E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600834F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001CC7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GfxId
	{
		[Token(Token = "0x6008350")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008351")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001CC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6008352")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008353")]
		[Address(RVA = "0xC77510", Offset = "0xC76910", VA = "0x180C77510")]
		set
		{
		}
	}

	[Token(Token = "0x600834B")]
	[Address(RVA = "0xC771F0", Offset = "0xC765F0", VA = "0x180C771F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankCreationRequest()
	{
	}

	[Token(Token = "0x600834C")]
	[Address(RVA = "0xC77140", Offset = "0xC76540", VA = "0x180C77140")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankCreationRequest(AllianceRankCreationRequest other)
	{
	}

	[Token(Token = "0x600834D")]
	[Address(RVA = "0xC76DC0", Offset = "0xC761C0", VA = "0x180C76DC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankCreationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008354")]
	[Address(RVA = "0xC76EA0", Offset = "0xC762A0", VA = "0x180C76EA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008355")]
	[Address(RVA = "0x9B1620", Offset = "0x9B0A20", VA = "0x1809B1620", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRankCreationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008356")]
	[Address(RVA = "0x9B16A0", Offset = "0x9B0AA0", VA = "0x1809B16A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008357")]
	[Address(RVA = "0xC76FE0", Offset = "0xC763E0", VA = "0x180C76FE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008358")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008359")]
	[Address(RVA = "0x9B1C20", Offset = "0x9B1020", VA = "0x1809B1C20", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600835A")]
	[Address(RVA = "0xC76CE0", Offset = "0xC760E0", VA = "0x180C76CE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600835B")]
	[Address(RVA = "0xC76F60", Offset = "0xC76360", VA = "0x180C76F60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRankCreationRequest other)
	{
	}

	[Token(Token = "0x600835C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600835D")]
	[Address(RVA = "0xC77340", Offset = "0xC76740", VA = "0x180C77340", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
