using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000439")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagPackListEvent : IMessage<HavenBagPackListEvent>, IMessage, IEquatable<HavenBagPackListEvent>, IDeepCloneable<HavenBagPackListEvent>, IBufferMessage
{
	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagPackListEvent> _parser;

	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EA1")]
	public const int PacksIdFieldNumber = 1;

	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_packsId_codec;

	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> packsId_;

	[Token(Token = "0x17000987")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagPackListEvent> Parser
	{
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x9BF7E0", Offset = "0x9BEBE0", VA = "0x1809BF7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000988")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C88")]
		[Address(RVA = "0x9BF730", Offset = "0x9BEB30", VA = "0x1809BF730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000989")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C89")]
		[Address(RVA = "0x9BFA00", Offset = "0x9BEE00", VA = "0x1809BFA00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700098A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PacksId
	{
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x9BF620", Offset = "0x9BEA20", VA = "0x1809BF620")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPackListEvent()
	{
	}

	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x9BF6A0", Offset = "0x9BEAA0", VA = "0x1809BF6A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPackListEvent(HavenBagPackListEvent other)
	{
	}

	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x9BF1E0", Offset = "0x9BE5E0", VA = "0x1809BF1E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagPackListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x9BF330", Offset = "0x9BE730", VA = "0x1809BF330", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x9BF2A0", Offset = "0x9BE6A0", VA = "0x1809BF2A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagPackListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x9BF490", Offset = "0x9BE890", VA = "0x1809BF490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x9BF950", Offset = "0x9BED50", VA = "0x1809BF950", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x9BF140", Offset = "0x9BE540", VA = "0x1809BF140", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x9BF410", Offset = "0x9BE810", VA = "0x1809BF410", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagPackListEvent other)
	{
	}

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x9BF830", Offset = "0x9BEC30", VA = "0x1809BF830", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
