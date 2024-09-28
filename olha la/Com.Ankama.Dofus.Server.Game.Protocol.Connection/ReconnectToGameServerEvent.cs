using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x200081D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReconnectToGameServerEvent : IMessage<ReconnectToGameServerEvent>, IMessage, IEquatable<ReconnectToGameServerEvent>, IDeepCloneable<ReconnectToGameServerEvent>, IBufferMessage
{
	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ReconnectToGameServerEvent> _parser;

	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C06")]
	public const int ValidTokenFieldNumber = 1;

	[Token(Token = "0x4001C07")]
	[FieldOffset(Offset = "0x18")]
	private bool validToken_;

	[Token(Token = "0x4001C08")]
	public const int TokenFieldNumber = 2;

	[Token(Token = "0x4001C09")]
	[FieldOffset(Offset = "0x20")]
	private string token_;

	[Token(Token = "0x4001C0A")]
	public const int ServerIdFieldNumber = 3;

	[Token(Token = "0x4001C0B")]
	[FieldOffset(Offset = "0x28")]
	private int serverId_;

	[Token(Token = "0x17001258")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReconnectToGameServerEvent> Parser
	{
		[Token(Token = "0x600562B")]
		[Address(RVA = "0xB0F370", Offset = "0xB0E770", VA = "0x180B0F370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001259")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600562C")]
		[Address(RVA = "0xB0F2C0", Offset = "0xB0E6C0", VA = "0x180B0F2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600562D")]
		[Address(RVA = "0xB0F560", Offset = "0xB0E960", VA = "0x180B0F560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700125B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool ValidToken
	{
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005632")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700125C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Token
	{
		[Token(Token = "0x6005633")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005634")]
		[Address(RVA = "0xB0F640", Offset = "0xB0EA40", VA = "0x180B0F640")]
		set
		{
		}
	}

	[Token(Token = "0x1700125D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ServerId
	{
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x600562E")]
	[Address(RVA = "0xB0F270", Offset = "0xB0E670", VA = "0x180B0F270")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ReconnectToGameServerEvent()
	{
	}

	[Token(Token = "0x600562F")]
	[Address(RVA = "0xB0F1C0", Offset = "0xB0E5C0", VA = "0x180B0F1C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReconnectToGameServerEvent(ReconnectToGameServerEvent other)
	{
	}

	[Token(Token = "0x6005630")]
	[Address(RVA = "0xB0ECE0", Offset = "0xB0E0E0", VA = "0x180B0ECE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReconnectToGameServerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005637")]
	[Address(RVA = "0xB0EDC0", Offset = "0xB0E1C0", VA = "0x180B0EDC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005638")]
	[Address(RVA = "0xB0EE80", Offset = "0xB0E280", VA = "0x180B0EE80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReconnectToGameServerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005639")]
	[Address(RVA = "0xB0EF00", Offset = "0xB0E300", VA = "0x180B0EF00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600563A")]
	[Address(RVA = "0xB0F060", Offset = "0xB0E460", VA = "0x180B0F060", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600563B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600563C")]
	[Address(RVA = "0xB0F4B0", Offset = "0xB0E8B0", VA = "0x180B0F4B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600563D")]
	[Address(RVA = "0xB0EC20", Offset = "0xB0E020", VA = "0x180B0EC20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600563E")]
	[Address(RVA = "0xB0EFE0", Offset = "0xB0E3E0", VA = "0x180B0EFE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ReconnectToGameServerEvent other)
	{
	}

	[Token(Token = "0x600563F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005640")]
	[Address(RVA = "0xB0F3C0", Offset = "0xB0E7C0", VA = "0x180B0F3C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
