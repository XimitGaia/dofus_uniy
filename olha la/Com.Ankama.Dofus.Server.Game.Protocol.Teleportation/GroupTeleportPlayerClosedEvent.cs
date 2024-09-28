using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000087")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupTeleportPlayerClosedEvent : IMessage<GroupTeleportPlayerClosedEvent>, IMessage, IEquatable<GroupTeleportPlayerClosedEvent>, IDeepCloneable<GroupTeleportPlayerClosedEvent>, IBufferMessage
{
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GroupTeleportPlayerClosedEvent> _parser;

	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001C3")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x40001C5")]
	public const int RequesterIdFieldNumber = 2;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x20")]
	private long requesterId_;

	[Token(Token = "0x17000109")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GroupTeleportPlayerClosedEvent> Parser
	{
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x951D40", Offset = "0x951140", VA = "0x180951D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x951C90", Offset = "0x951090", VA = "0x180951C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x951EC0", Offset = "0x9512C0", VA = "0x180951EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700010D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RequesterId
	{
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerClosedEvent()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerClosedEvent(GroupTeleportPlayerClosedEvent other)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x951870", Offset = "0x950C70", VA = "0x180951870", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GroupTeleportPlayerClosedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x951940", Offset = "0x950D40", VA = "0x180951940", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupTeleportPlayerClosedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x951AD0", Offset = "0x950ED0", VA = "0x180951AD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x9517B0", Offset = "0x950BB0", VA = "0x1809517B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GroupTeleportPlayerClosedEvent other)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
