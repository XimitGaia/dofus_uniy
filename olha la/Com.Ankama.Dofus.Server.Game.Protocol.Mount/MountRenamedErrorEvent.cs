using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000319")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountRenamedErrorEvent : IMessage<MountRenamedErrorEvent>, IMessage, IEquatable<MountRenamedErrorEvent>, IDeepCloneable<MountRenamedErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountRenamedErrorEvent> _parser;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ACB")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x170006E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountRenamedErrorEvent> Parser
	{
		[Token(Token = "0x6002027")]
		[Address(RVA = "0xD21FB0", Offset = "0xD213B0", VA = "0x180D21FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002028")]
		[Address(RVA = "0xD21F00", Offset = "0xD21300", VA = "0x180D21F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002029")]
		[Address(RVA = "0xD22000", Offset = "0xD21400", VA = "0x180D22000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600202A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenamedErrorEvent()
	{
	}

	[Token(Token = "0x600202B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountRenamedErrorEvent(MountRenamedErrorEvent other)
	{
	}

	[Token(Token = "0x600202C")]
	[Address(RVA = "0xD21C90", Offset = "0xD21090", VA = "0x180D21C90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountRenamedErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0xD21D10", Offset = "0xD21110", VA = "0x180D21D10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountRenamedErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0xD21DA0", Offset = "0xD211A0", VA = "0x180D21DA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0xD21C00", Offset = "0xD21000", VA = "0x180D21C00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountRenamedErrorEvent other)
	{
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
