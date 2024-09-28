using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x2000800")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcquaintanceListEvent : IMessage<AcquaintanceListEvent>, IMessage, IEquatable<AcquaintanceListEvent>, IDeepCloneable<AcquaintanceListEvent>, IBufferMessage
{
	[Token(Token = "0x4001B8E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AcquaintanceListEvent> _parser;

	[Token(Token = "0x4001B8F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B90")]
	public const int AcquaintanceFieldNumber = 1;

	[Token(Token = "0x4001B91")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<AcquaintanceInformation> _repeated_acquaintance_codec;

	[Token(Token = "0x4001B92")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<AcquaintanceInformation> acquaintance_;

	[Token(Token = "0x17001208")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AcquaintanceListEvent> Parser
	{
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0xAE53B0", Offset = "0xAE47B0", VA = "0x180AE53B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001209")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0xAE5300", Offset = "0xAE4700", VA = "0x180AE5300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0xAE55C0", Offset = "0xAE49C0", VA = "0x180AE55C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<AcquaintanceInformation> Acquaintance
	{
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054D9")]
	[Address(RVA = "0xAE5280", Offset = "0xAE4680", VA = "0x180AE5280")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceListEvent()
	{
	}

	[Token(Token = "0x60054DA")]
	[Address(RVA = "0xAE51F0", Offset = "0xAE45F0", VA = "0x180AE51F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AcquaintanceListEvent(AcquaintanceListEvent other)
	{
	}

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0xAE4D40", Offset = "0xAE4140", VA = "0x180AE4D40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcquaintanceListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60054DD")]
	[Address(RVA = "0xAE4E00", Offset = "0xAE4200", VA = "0x180AE4E00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054DE")]
	[Address(RVA = "0xAE4EE0", Offset = "0xAE42E0", VA = "0x180AE4EE0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AcquaintanceListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054DF")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0xAE4FF0", Offset = "0xAE43F0", VA = "0x180AE4FF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60054E2")]
	[Address(RVA = "0xAE5510", Offset = "0xAE4910", VA = "0x180AE5510", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0xAE4CA0", Offset = "0xAE40A0", VA = "0x180AE4CA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60054E4")]
	[Address(RVA = "0xAE4F70", Offset = "0xAE4370", VA = "0x180AE4F70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AcquaintanceListEvent other)
	{
	}

	[Token(Token = "0x60054E5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60054E6")]
	[Address(RVA = "0xAE5400", Offset = "0xAE4800", VA = "0x180AE5400", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
