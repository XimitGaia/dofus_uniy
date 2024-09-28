using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200070F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountsPaddockRemoveEvent : IMessage<ExchangeMountsPaddockRemoveEvent>, IMessage, IEquatable<ExchangeMountsPaddockRemoveEvent>, IDeepCloneable<ExchangeMountsPaddockRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountsPaddockRemoveEvent> _parser;

	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018E4")]
	public const int MountsIdFieldNumber = 1;

	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_mountsId_codec;

	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> mountsId_;

	[Token(Token = "0x1700103F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeMountsPaddockRemoveEvent> Parser
	{
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0xABD550", Offset = "0xABC950", VA = "0x180ABD550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001040")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0xABD4A0", Offset = "0xABC8A0", VA = "0x180ABD4A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001041")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0xABD770", Offset = "0xABCB70", VA = "0x180ABD770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001042")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MountsId
	{
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BE2")]
	[Address(RVA = "0xABD420", Offset = "0xABC820", VA = "0x180ABD420")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsPaddockRemoveEvent()
	{
	}

	[Token(Token = "0x6004BE3")]
	[Address(RVA = "0xABD390", Offset = "0xABC790", VA = "0x180ABD390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsPaddockRemoveEvent(ExchangeMountsPaddockRemoveEvent other)
	{
	}

	[Token(Token = "0x6004BE4")]
	[Address(RVA = "0xABCF50", Offset = "0xABC350", VA = "0x180ABCF50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsPaddockRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004BE6")]
	[Address(RVA = "0xABD010", Offset = "0xABC410", VA = "0x180ABD010", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BE7")]
	[Address(RVA = "0xABD0F0", Offset = "0xABC4F0", VA = "0x180ABD0F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountsPaddockRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BE8")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004BE9")]
	[Address(RVA = "0xABD200", Offset = "0xABC600", VA = "0x180ABD200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004BEA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004BEB")]
	[Address(RVA = "0xABD6C0", Offset = "0xABCAC0", VA = "0x180ABD6C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004BEC")]
	[Address(RVA = "0xABCEB0", Offset = "0xABC2B0", VA = "0x180ABCEB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004BED")]
	[Address(RVA = "0xABD180", Offset = "0xABC580", VA = "0x180ABD180", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountsPaddockRemoveEvent other)
	{
	}

	[Token(Token = "0x6004BEE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004BEF")]
	[Address(RVA = "0xABD5A0", Offset = "0xABC9A0", VA = "0x180ABD5A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
