using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000861")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerStatusUpdateRequest : IMessage<PlayerStatusUpdateRequest>, IMessage, IEquatable<PlayerStatusUpdateRequest>, IDeepCloneable<PlayerStatusUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4001D0E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerStatusUpdateRequest> _parser;

	[Token(Token = "0x4001D0F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D10")]
	public const int StatusFieldNumber = 1;

	[Token(Token = "0x4001D11")]
	[FieldOffset(Offset = "0x18")]
	private CharacterStatus status_;

	[Token(Token = "0x170012F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerStatusUpdateRequest> Parser
	{
		[Token(Token = "0x6005907")]
		[Address(RVA = "0xB27F00", Offset = "0xB27300", VA = "0x180B27F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005908")]
		[Address(RVA = "0xB27E50", Offset = "0xB27250", VA = "0x180B27E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005909")]
		[Address(RVA = "0xB28050", Offset = "0xB27450", VA = "0x180B28050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterStatus Status
	{
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600590E")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600590A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdateRequest()
	{
	}

	[Token(Token = "0x600590B")]
	[Address(RVA = "0xB27DE0", Offset = "0xB271E0", VA = "0x180B27DE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerStatusUpdateRequest(PlayerStatusUpdateRequest other)
	{
	}

	[Token(Token = "0x600590C")]
	[Address(RVA = "0xB27A60", Offset = "0xB26E60", VA = "0x180B27A60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerStatusUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600590F")]
	[Address(RVA = "0xB27B00", Offset = "0xB26F00", VA = "0x180B27B00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005910")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerStatusUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005911")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005912")]
	[Address(RVA = "0xB27C80", Offset = "0xB27080", VA = "0x180B27C80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005913")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005914")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005915")]
	[Address(RVA = "0xB279D0", Offset = "0xB26DD0", VA = "0x180B279D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005916")]
	[Address(RVA = "0xB27BB0", Offset = "0xB26FB0", VA = "0x180B27BB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerStatusUpdateRequest other)
	{
	}

	[Token(Token = "0x6005917")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005918")]
	[Address(RVA = "0xB27F50", Offset = "0xB27350", VA = "0x180B27F50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
