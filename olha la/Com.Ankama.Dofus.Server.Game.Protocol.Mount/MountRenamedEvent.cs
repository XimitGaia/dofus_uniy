using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000317")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountRenamedEvent : IMessage<MountRenamedEvent>, IMessage, IEquatable<MountRenamedEvent>, IDeepCloneable<MountRenamedEvent>, IBufferMessage
{
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountRenamedEvent> _parser;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AC4")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x4000AC6")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x170006E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountRenamedEvent> Parser
	{
		[Token(Token = "0x600200F")]
		[Address(RVA = "0xD226A0", Offset = "0xD21AA0", VA = "0x180D226A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002010")]
		[Address(RVA = "0xD225F0", Offset = "0xD219F0", VA = "0x180D225F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002011")]
		[Address(RVA = "0xD227C0", Offset = "0xD21BC0", VA = "0x180D227C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170006E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002018")]
		[Address(RVA = "0xD228A0", Offset = "0xD21CA0", VA = "0x180D228A0")]
		set
		{
		}
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0xD225A0", Offset = "0xD219A0", VA = "0x180D225A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenamedEvent()
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0xD224F0", Offset = "0xD218F0", VA = "0x180D224F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountRenamedEvent(MountRenamedEvent other)
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0xD221A0", Offset = "0xD215A0", VA = "0x180D221A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenamedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0xD22270", Offset = "0xD21670", VA = "0x180D22270", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600201A")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountRenamedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0xD22390", Offset = "0xD21790", VA = "0x180D22390", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0xB789B0", Offset = "0xB77DB0", VA = "0x180B789B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0xD220E0", Offset = "0xD214E0", VA = "0x180D220E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002020")]
	[Address(RVA = "0xD22320", Offset = "0xD21720", VA = "0x180D22320", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountRenamedEvent other)
	{
	}

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0xD226F0", Offset = "0xD21AF0", VA = "0x180D226F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
