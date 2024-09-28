using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000073")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ZaapRespawnUpdatedEvent : IMessage<ZaapRespawnUpdatedEvent>, IMessage, IEquatable<ZaapRespawnUpdatedEvent>, IDeepCloneable<ZaapRespawnUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ZaapRespawnUpdatedEvent> _parser;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400016C")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x170000D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ZaapRespawnUpdatedEvent> Parser
	{
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x968EB0", Offset = "0x9682B0", VA = "0x180968EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x968E00", Offset = "0x968200", VA = "0x180968E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x968F00", Offset = "0x968300", VA = "0x180968F00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ZaapRespawnUpdatedEvent()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ZaapRespawnUpdatedEvent(ZaapRespawnUpdatedEvent other)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x968B90", Offset = "0x967F90", VA = "0x180968B90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ZaapRespawnUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x968C10", Offset = "0x968010", VA = "0x180968C10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ZaapRespawnUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x968CA0", Offset = "0x9680A0", VA = "0x180968CA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x968B00", Offset = "0x967F00", VA = "0x180968B00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ZaapRespawnUpdatedEvent other)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
