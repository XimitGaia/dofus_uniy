using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007FE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendListEvent : IMessage<FriendListEvent>, IMessage, IEquatable<FriendListEvent>, IDeepCloneable<FriendListEvent>, IBufferMessage
{
	[Token(Token = "0x4001B88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendListEvent> _parser;

	[Token(Token = "0x4001B89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B8A")]
	public const int FriendFieldNumber = 1;

	[Token(Token = "0x4001B8B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FriendInformation> _repeated_friend_codec;

	[Token(Token = "0x4001B8C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<FriendInformation> friend_;

	[Token(Token = "0x17001204")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FriendListEvent> Parser
	{
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0xAF0170", Offset = "0xAEF570", VA = "0x180AF0170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001205")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0xAF00C0", Offset = "0xAEF4C0", VA = "0x180AF00C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001206")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0xAF0380", Offset = "0xAEF780", VA = "0x180AF0380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001207")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FriendInformation> Friend
	{
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0xAEFFB0", Offset = "0xAEF3B0", VA = "0x180AEFFB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendListEvent()
	{
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0xAF0030", Offset = "0xAEF430", VA = "0x180AF0030")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendListEvent(FriendListEvent other)
	{
	}

	[Token(Token = "0x60054C6")]
	[Address(RVA = "0xAEFB00", Offset = "0xAEEF00", VA = "0x180AEFB00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60054C8")]
	[Address(RVA = "0xAEFBC0", Offset = "0xAEEFC0", VA = "0x180AEFBC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054C9")]
	[Address(RVA = "0xAEFCA0", Offset = "0xAEF0A0", VA = "0x180AEFCA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FriendListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60054CA")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60054CB")]
	[Address(RVA = "0xAEFDB0", Offset = "0xAEF1B0", VA = "0x180AEFDB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60054CC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60054CD")]
	[Address(RVA = "0xAF02D0", Offset = "0xAEF6D0", VA = "0x180AF02D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60054CE")]
	[Address(RVA = "0xAEFA60", Offset = "0xAEEE60", VA = "0x180AEFA60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60054CF")]
	[Address(RVA = "0xAEFD30", Offset = "0xAEF130", VA = "0x180AEFD30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendListEvent other)
	{
	}

	[Token(Token = "0x60054D0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60054D1")]
	[Address(RVA = "0xAF01C0", Offset = "0xAEF5C0", VA = "0x180AF01C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
