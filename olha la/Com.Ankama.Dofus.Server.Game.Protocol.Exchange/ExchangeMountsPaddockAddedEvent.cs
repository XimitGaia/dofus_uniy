using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200070B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountsPaddockAddedEvent : IMessage<ExchangeMountsPaddockAddedEvent>, IMessage, IEquatable<ExchangeMountsPaddockAddedEvent>, IDeepCloneable<ExchangeMountsPaddockAddedEvent>, IBufferMessage
{
	[Token(Token = "0x40018D6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountsPaddockAddedEvent> _parser;

	[Token(Token = "0x40018D7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018D8")]
	public const int MountsFieldNumber = 1;

	[Token(Token = "0x40018D9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MountData> _repeated_mounts_codec;

	[Token(Token = "0x40018DA")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<MountData> mounts_;

	[Token(Token = "0x17001037")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMountsPaddockAddedEvent> Parser
	{
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0xABCBC0", Offset = "0xABBFC0", VA = "0x180ABCBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001038")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0xABCB10", Offset = "0xABBF10", VA = "0x180ABCB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001039")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0xABCDD0", Offset = "0xABC1D0", VA = "0x180ABCDD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MountData> Mounts
	{
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BB8")]
	[Address(RVA = "0xABCA00", Offset = "0xABBE00", VA = "0x180ABCA00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountsPaddockAddedEvent()
	{
	}

	[Token(Token = "0x6004BB9")]
	[Address(RVA = "0xABCA80", Offset = "0xABBE80", VA = "0x180ABCA80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsPaddockAddedEvent(ExchangeMountsPaddockAddedEvent other)
	{
	}

	[Token(Token = "0x6004BBA")]
	[Address(RVA = "0xABC550", Offset = "0xABB950", VA = "0x180ABC550", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountsPaddockAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004BBC")]
	[Address(RVA = "0xABC610", Offset = "0xABBA10", VA = "0x180ABC610", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BBD")]
	[Address(RVA = "0xABC6F0", Offset = "0xABBAF0", VA = "0x180ABC6F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountsPaddockAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004BBE")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004BBF")]
	[Address(RVA = "0xABC800", Offset = "0xABBC00", VA = "0x180ABC800", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004BC0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004BC1")]
	[Address(RVA = "0xABCD20", Offset = "0xABC120", VA = "0x180ABCD20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004BC2")]
	[Address(RVA = "0xABC4B0", Offset = "0xABB8B0", VA = "0x180ABC4B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004BC3")]
	[Address(RVA = "0xABC780", Offset = "0xABBB80", VA = "0x180ABC780", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountsPaddockAddedEvent other)
	{
	}

	[Token(Token = "0x6004BC4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004BC5")]
	[Address(RVA = "0xABCC10", Offset = "0xABC010", VA = "0x180ABCC10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
