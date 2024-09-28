using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009DF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterStatus : IMessage<CharacterStatus>, IMessage, IEquatable<CharacterStatus>, IDeepCloneable<CharacterStatus>, IBufferMessage
{
	[Token(Token = "0x20009E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009E1")]
		public enum Status
		{
			[Token(Token = "0x4002321")]
			[OriginalName("STATUS_OFFLINE")]
			Offline,
			[Token(Token = "0x4002322")]
			[OriginalName("STATUS_AVAILABLE")]
			Available,
			[Token(Token = "0x4002323")]
			[OriginalName("STATUS_IDLE")]
			Idle,
			[Token(Token = "0x4002324")]
			[OriginalName("STATUS_AFK")]
			Afk,
			[Token(Token = "0x4002325")]
			[OriginalName("STATUS_PRIVATE")]
			Private,
			[Token(Token = "0x4002326")]
			[OriginalName("STATUS_SOLO")]
			Solo,
			[Token(Token = "0x4002327")]
			[OriginalName("STATUS_UNKNOWN")]
			Unknown
		}
	}

	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterStatus> _parser;

	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400231B")]
	public const int StatusFieldNumber = 1;

	[Token(Token = "0x400231C")]
	[FieldOffset(Offset = "0x18")]
	private Types.Status status_;

	[Token(Token = "0x400231D")]
	public const int MessageFieldNumber = 2;

	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string MessageDefaultValue;

	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0x20")]
	private string message_;

	[Token(Token = "0x17001618")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterStatus> Parser
	{
		[Token(Token = "0x60066F6")]
		[Address(RVA = "0xBA7DA0", Offset = "0xBA71A0", VA = "0x180BA7DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001619")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60066F7")]
		[Address(RVA = "0xBA7C90", Offset = "0xBA7090", VA = "0x180BA7C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700161A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0xBA7F80", Offset = "0xBA7380", VA = "0x180BA7F80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700161B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Status Status
	{
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Status);
		}
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700161C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message
	{
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0xBA7D40", Offset = "0xBA7140", VA = "0x180BA7D40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0xBA8060", Offset = "0xBA7460", VA = "0x180BA8060")]
		set
		{
		}
	}

	[Token(Token = "0x1700161D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasMessage
	{
		[Token(Token = "0x6006700")]
		[Address(RVA = "0x916800", Offset = "0x915C00", VA = "0x180916800")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60066F9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterStatus()
	{
	}

	[Token(Token = "0x60066FA")]
	[Address(RVA = "0xBA7C30", Offset = "0xBA7030", VA = "0x180BA7C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterStatus(CharacterStatus other)
	{
	}

	[Token(Token = "0x60066FB")]
	[Address(RVA = "0xBA7750", Offset = "0xBA6B50", VA = "0x180BA7750", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterStatus Clone()
	{
		return null;
	}

	[Token(Token = "0x6006701")]
	[Address(RVA = "0x915FF0", Offset = "0x9153F0", VA = "0x180915FF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearMessage()
	{
	}

	[Token(Token = "0x6006702")]
	[Address(RVA = "0xBA77E0", Offset = "0xBA6BE0", VA = "0x180BA77E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006703")]
	[Address(RVA = "0xBA78B0", Offset = "0xBA6CB0", VA = "0x180BA78B0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterStatus other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006704")]
	[Address(RVA = "0xBA7940", Offset = "0xBA6D40", VA = "0x180BA7940", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006705")]
	[Address(RVA = "0xBA7A90", Offset = "0xBA6E90", VA = "0x180BA7A90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006706")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006707")]
	[Address(RVA = "0xBA7EC0", Offset = "0xBA72C0", VA = "0x180BA7EC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006708")]
	[Address(RVA = "0xBA7640", Offset = "0xBA6A40", VA = "0x180BA7640", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006709")]
	[Address(RVA = "0xBA7A20", Offset = "0xBA6E20", VA = "0x180BA7A20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterStatus other)
	{
	}

	[Token(Token = "0x600670A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600670B")]
	[Address(RVA = "0xBA7DF0", Offset = "0xBA71F0", VA = "0x180BA7DF0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
