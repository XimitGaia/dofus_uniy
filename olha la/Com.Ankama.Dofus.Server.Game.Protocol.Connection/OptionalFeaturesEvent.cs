using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x200081F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OptionalFeaturesEvent : IMessage<OptionalFeaturesEvent>, IMessage, IEquatable<OptionalFeaturesEvent>, IDeepCloneable<OptionalFeaturesEvent>, IBufferMessage
{
	[Token(Token = "0x4001C0D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OptionalFeaturesEvent> _parser;

	[Token(Token = "0x4001C0E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C0F")]
	public const int FeaturesFieldNumber = 1;

	[Token(Token = "0x4001C10")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_features_codec;

	[Token(Token = "0x4001C11")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> features_;

	[Token(Token = "0x1700125E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OptionalFeaturesEvent> Parser
	{
		[Token(Token = "0x6005645")]
		[Address(RVA = "0xB0DA20", Offset = "0xB0CE20", VA = "0x180B0DA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005646")]
		[Address(RVA = "0xB0D970", Offset = "0xB0CD70", VA = "0x180B0D970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001260")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005647")]
		[Address(RVA = "0xB0DC40", Offset = "0xB0D040", VA = "0x180B0DC40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001261")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Features
	{
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005648")]
	[Address(RVA = "0xB0D8F0", Offset = "0xB0CCF0", VA = "0x180B0D8F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OptionalFeaturesEvent()
	{
	}

	[Token(Token = "0x6005649")]
	[Address(RVA = "0xB0D860", Offset = "0xB0CC60", VA = "0x180B0D860")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OptionalFeaturesEvent(OptionalFeaturesEvent other)
	{
	}

	[Token(Token = "0x600564A")]
	[Address(RVA = "0xB0D420", Offset = "0xB0C820", VA = "0x180B0D420", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OptionalFeaturesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600564C")]
	[Address(RVA = "0xB0D570", Offset = "0xB0C970", VA = "0x180B0D570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600564D")]
	[Address(RVA = "0xB0D4E0", Offset = "0xB0C8E0", VA = "0x180B0D4E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OptionalFeaturesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600564E")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600564F")]
	[Address(RVA = "0xB0D6D0", Offset = "0xB0CAD0", VA = "0x180B0D6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005650")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005651")]
	[Address(RVA = "0xB0DB90", Offset = "0xB0CF90", VA = "0x180B0DB90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005652")]
	[Address(RVA = "0xB0D380", Offset = "0xB0C780", VA = "0x180B0D380", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005653")]
	[Address(RVA = "0xB0D650", Offset = "0xB0CA50", VA = "0x180B0D650", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OptionalFeaturesEvent other)
	{
	}

	[Token(Token = "0x6005654")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005655")]
	[Address(RVA = "0xB0DA70", Offset = "0xB0CE70", VA = "0x180B0DA70", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
