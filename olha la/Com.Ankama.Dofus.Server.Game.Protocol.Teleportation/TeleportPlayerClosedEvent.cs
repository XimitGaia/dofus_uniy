using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000083")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportPlayerClosedEvent : IMessage<TeleportPlayerClosedEvent>, IMessage, IEquatable<TeleportPlayerClosedEvent>, IDeepCloneable<TeleportPlayerClosedEvent>, IBufferMessage
{
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportPlayerClosedEvent> _parser;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001AD")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x40001AF")]
	public const int RequesterIdFieldNumber = 2;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x20")]
	private long requesterId_;

	[Token(Token = "0x170000FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TeleportPlayerClosedEvent> Parser
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x9616E0", Offset = "0x960AE0", VA = "0x1809616E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x961630", Offset = "0x960A30", VA = "0x180961630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x961730", Offset = "0x960B30", VA = "0x180961730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170000FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long RequesterId
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportPlayerClosedEvent()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportPlayerClosedEvent(TeleportPlayerClosedEvent other)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x9613A0", Offset = "0x9607A0", VA = "0x1809613A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportPlayerClosedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x961430", Offset = "0x960830", VA = "0x180961430", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportPlayerClosedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x9614D0", Offset = "0x9608D0", VA = "0x1809614D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x9612E0", Offset = "0x9606E0", VA = "0x1809612E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportPlayerClosedEvent other)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
