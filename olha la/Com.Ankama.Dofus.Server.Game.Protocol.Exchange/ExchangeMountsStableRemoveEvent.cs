using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200070D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountsStableRemoveEvent : IMessage<ExchangeMountsStableRemoveEvent>, IMessage, IEquatable<ExchangeMountsStableRemoveEvent>, IDeepCloneable<ExchangeMountsStableRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x40018DC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountsStableRemoveEvent> _parser;

	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018DE")]
	public const int MountsIdFieldNumber = 1;

	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_mountsId_codec;

	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> mountsId_;

	[Token(Token = "0x1700103B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMountsStableRemoveEvent> Parser
	{
		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0xABEA20", Offset = "0xABDE20", VA = "0x180ABEA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0xABE970", Offset = "0xABDD70", VA = "0x180ABE970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0xABEC40", Offset = "0xABE040", VA = "0x180ABEC40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MountsId
	{
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BCD")]
	[Address(RVA = "0xABE860", Offset = "0xABDC60", VA = "0x180ABE860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsStableRemoveEvent()
	{
	}

	[Token(Token = "0x6004BCE")]
	[Address(RVA = "0xABE8E0", Offset = "0xABDCE0", VA = "0x180ABE8E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsStableRemoveEvent(ExchangeMountsStableRemoveEvent other)
	{
	}

	[Token(Token = "0x6004BCF")]
	[Address(RVA = "0xABE420", Offset = "0xABD820", VA = "0x180ABE420", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountsStableRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004BD1")]
	[Address(RVA = "0xABE570", Offset = "0xABD970", VA = "0x180ABE570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BD2")]
	[Address(RVA = "0xABE4E0", Offset = "0xABD8E0", VA = "0x180ABE4E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountsStableRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BD3")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004BD4")]
	[Address(RVA = "0xABE6D0", Offset = "0xABDAD0", VA = "0x180ABE6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004BD5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004BD6")]
	[Address(RVA = "0xABEB90", Offset = "0xABDF90", VA = "0x180ABEB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004BD7")]
	[Address(RVA = "0xABE380", Offset = "0xABD780", VA = "0x180ABE380", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004BD8")]
	[Address(RVA = "0xABE650", Offset = "0xABDA50", VA = "0x180ABE650", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeMountsStableRemoveEvent other)
	{
	}

	[Token(Token = "0x6004BD9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004BDA")]
	[Address(RVA = "0xABEA70", Offset = "0xABDE70", VA = "0x180ABEA70", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
