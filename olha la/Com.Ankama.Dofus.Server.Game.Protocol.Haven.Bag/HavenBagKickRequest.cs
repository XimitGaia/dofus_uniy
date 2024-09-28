using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200042B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagKickRequest : IMessage<HavenBagKickRequest>, IMessage, IEquatable<HavenBagKickRequest>, IDeepCloneable<HavenBagKickRequest>, IBufferMessage
{
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagKickRequest> _parser;

	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E7B")]
	public const int GuestIdFieldNumber = 1;

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x18")]
	private long guestId_;

	[Token(Token = "0x1700096D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagKickRequest> Parser
	{
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x9BF010", Offset = "0x9BE410", VA = "0x1809BF010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700096E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x9BEF60", Offset = "0x9BE360", VA = "0x1809BEF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700096F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x9BF060", Offset = "0x9BE460", VA = "0x1809BF060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000970")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuestId
	{
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagKickRequest()
	{
	}

	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagKickRequest(HavenBagKickRequest other)
	{
	}

	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x9BECF0", Offset = "0x9BE0F0", VA = "0x1809BECF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x9BED70", Offset = "0x9BE170", VA = "0x1809BED70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x9BEE00", Offset = "0x9BE200", VA = "0x1809BEE00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x9BEC60", Offset = "0x9BE060", VA = "0x1809BEC60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HavenBagKickRequest other)
	{
	}

	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
