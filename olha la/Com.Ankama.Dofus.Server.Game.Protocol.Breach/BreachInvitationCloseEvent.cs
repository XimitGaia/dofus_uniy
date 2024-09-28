using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000915")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachInvitationCloseEvent : IMessage<BreachInvitationCloseEvent>, IMessage, IEquatable<BreachInvitationCloseEvent>, IDeepCloneable<BreachInvitationCloseEvent>, IBufferMessage
{
	[Token(Token = "0x4001F0F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachInvitationCloseEvent> _parser;

	[Token(Token = "0x4001F10")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001F11")]
	public const int HostFieldNumber = 1;

	[Token(Token = "0x4001F12")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character host_;

	[Token(Token = "0x17001453")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachInvitationCloseEvent> Parser
	{
		[Token(Token = "0x6006015")]
		[Address(RVA = "0xB50D20", Offset = "0xB50120", VA = "0x180B50D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001454")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006016")]
		[Address(RVA = "0xB50C70", Offset = "0xB50070", VA = "0x180B50C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001455")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006017")]
		[Address(RVA = "0xB50E70", Offset = "0xB50270", VA = "0x180B50E70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001456")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Host
	{
		[Token(Token = "0x600601B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600601C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6006018")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationCloseEvent()
	{
	}

	[Token(Token = "0x6006019")]
	[Address(RVA = "0x9BD2D0", Offset = "0x9BC6D0", VA = "0x1809BD2D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachInvitationCloseEvent(BreachInvitationCloseEvent other)
	{
	}

	[Token(Token = "0x600601A")]
	[Address(RVA = "0xB508F0", Offset = "0xB4FCF0", VA = "0x180B508F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachInvitationCloseEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600601D")]
	[Address(RVA = "0xB50990", Offset = "0xB4FD90", VA = "0x180B50990", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600601E")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachInvitationCloseEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600601F")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006020")]
	[Address(RVA = "0xB50B10", Offset = "0xB4FF10", VA = "0x180B50B10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006021")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006022")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006023")]
	[Address(RVA = "0xB50860", Offset = "0xB4FC60", VA = "0x180B50860", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006024")]
	[Address(RVA = "0xB50A40", Offset = "0xB4FE40", VA = "0x180B50A40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachInvitationCloseEvent other)
	{
	}

	[Token(Token = "0x6006025")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006026")]
	[Address(RVA = "0xB50D70", Offset = "0xB50170", VA = "0x180B50D70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
