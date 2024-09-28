using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000315")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountReleasedEvent : IMessage<MountReleasedEvent>, IMessage, IEquatable<MountReleasedEvent>, IDeepCloneable<MountReleasedEvent>, IBufferMessage
{
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountReleasedEvent> _parser;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ABF")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x170006E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountReleasedEvent> Parser
	{
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0xD212A0", Offset = "0xD206A0", VA = "0x180D212A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0xD211F0", Offset = "0xD205F0", VA = "0x180D211F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0xD212F0", Offset = "0xD206F0", VA = "0x180D212F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MountId
	{
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleasedEvent()
	{
	}

	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleasedEvent(MountReleasedEvent other)
	{
	}

	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0xD20F80", Offset = "0xD20380", VA = "0x180D20F80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountReleasedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002001")]
	[Address(RVA = "0xD21000", Offset = "0xD20400", VA = "0x180D21000", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountReleasedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0xD21090", Offset = "0xD20490", VA = "0x180D21090", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002005")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002006")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002007")]
	[Address(RVA = "0xD20EF0", Offset = "0xD202F0", VA = "0x180D20EF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002008")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountReleasedEvent other)
	{
	}

	[Token(Token = "0x6002009")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600200A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
