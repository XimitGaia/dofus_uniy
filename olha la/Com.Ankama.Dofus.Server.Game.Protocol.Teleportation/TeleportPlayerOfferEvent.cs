using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000081")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportPlayerOfferEvent : IMessage<TeleportPlayerOfferEvent>, IMessage, IEquatable<TeleportPlayerOfferEvent>, IDeepCloneable<TeleportPlayerOfferEvent>, IBufferMessage
{
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportPlayerOfferEvent> _parser;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001A2")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x40001A4")]
	public const int MessageFieldNumber = 2;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x20")]
	private string message_;

	[Token(Token = "0x40001A6")]
	public const int TimeLeftFieldNumber = 3;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x28")]
	private int timeLeft_;

	[Token(Token = "0x40001A8")]
	public const int RequesterIdFieldNumber = 4;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x30")]
	private long requesterId_;

	[Token(Token = "0x170000F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportPlayerOfferEvent> Parser
	{
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x961FD0", Offset = "0x9613D0", VA = "0x180961FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x961F20", Offset = "0x961320", VA = "0x180961F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x962210", Offset = "0x961610", VA = "0x180962210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x9622F0", Offset = "0x9616F0", VA = "0x1809622F0")]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TimeLeft
	{
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long RequesterId
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x961ED0", Offset = "0x9612D0", VA = "0x180961ED0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportPlayerOfferEvent()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x961E10", Offset = "0x961210", VA = "0x180961E10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportPlayerOfferEvent(TeleportPlayerOfferEvent other)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x961920", Offset = "0x960D20", VA = "0x180961920", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportPlayerOfferEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x961A80", Offset = "0x960E80", VA = "0x180961A80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x961A00", Offset = "0x960E00", VA = "0x180961A00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportPlayerOfferEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x961B50", Offset = "0x960F50", VA = "0x180961B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x961CB0", Offset = "0x9610B0", VA = "0x180961CB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x962140", Offset = "0x961540", VA = "0x180962140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x961810", Offset = "0x960C10", VA = "0x180961810", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x961C20", Offset = "0x961020", VA = "0x180961C20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportPlayerOfferEvent other)
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x962020", Offset = "0x961420", VA = "0x180962020", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
