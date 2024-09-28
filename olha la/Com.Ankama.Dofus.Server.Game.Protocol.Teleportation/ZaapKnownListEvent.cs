using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000077")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ZaapKnownListEvent : IMessage<ZaapKnownListEvent>, IMessage, IEquatable<ZaapKnownListEvent>, IDeepCloneable<ZaapKnownListEvent>, IBufferMessage
{
	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ZaapKnownListEvent> _parser;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400017D")]
	public const int DestinationsFieldNumber = 1;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_destinations_codec;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<long> destinations_;

	[Token(Token = "0x170000DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ZaapKnownListEvent> Parser
	{
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x9683C0", Offset = "0x9677C0", VA = "0x1809683C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x968310", Offset = "0x967710", VA = "0x180968310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x9685E0", Offset = "0x9679E0", VA = "0x1809685E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Destinations
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x968290", Offset = "0x967690", VA = "0x180968290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ZaapKnownListEvent()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x968200", Offset = "0x967600", VA = "0x180968200")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ZaapKnownListEvent(ZaapKnownListEvent other)
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x967DC0", Offset = "0x9671C0", VA = "0x180967DC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ZaapKnownListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x967E80", Offset = "0x967280", VA = "0x180967E80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x967F60", Offset = "0x967360", VA = "0x180967F60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ZaapKnownListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x968530", Offset = "0x967930", VA = "0x180968530", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x967D20", Offset = "0x967120", VA = "0x180967D20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x967FF0", Offset = "0x9673F0", VA = "0x180967FF0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ZaapKnownListEvent other)
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x968410", Offset = "0x967810", VA = "0x180968410", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
