using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x200082E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientChallengeInitRequest : IMessage<ClientChallengeInitRequest>, IMessage, IEquatable<ClientChallengeInitRequest>, IDeepCloneable<ClientChallengeInitRequest>, IBufferMessage
{
	[Token(Token = "0x4001C30")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ClientChallengeInitRequest> _parser;

	[Token(Token = "0x4001C31")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C32")]
	public const int ChallengeKeyFieldNumber = 1;

	[Token(Token = "0x4001C33")]
	[FieldOffset(Offset = "0x18")]
	private string challengeKey_;

	[Token(Token = "0x1700127A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientChallengeInitRequest> Parser
	{
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0xB07EC0", Offset = "0xB072C0", VA = "0x180B07EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700127B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0xB07E10", Offset = "0xB07210", VA = "0x180B07E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700127C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0xB07FD0", Offset = "0xB073D0", VA = "0x180B07FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700127D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ChallengeKey
	{
		[Token(Token = "0x60056E4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60056E5")]
		[Address(RVA = "0xB080B0", Offset = "0xB074B0", VA = "0x180B080B0")]
		set
		{
		}
	}

	[Token(Token = "0x60056E1")]
	[Address(RVA = "0xB07DC0", Offset = "0xB071C0", VA = "0x180B07DC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientChallengeInitRequest()
	{
	}

	[Token(Token = "0x60056E2")]
	[Address(RVA = "0xB07D20", Offset = "0xB07120", VA = "0x180B07D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientChallengeInitRequest(ClientChallengeInitRequest other)
	{
	}

	[Token(Token = "0x60056E3")]
	[Address(RVA = "0xB079E0", Offset = "0xB06DE0", VA = "0x180B079E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ClientChallengeInitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60056E6")]
	[Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056E7")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientChallengeInitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056E8")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60056E9")]
	[Address(RVA = "0xB07BC0", Offset = "0xB06FC0", VA = "0x180B07BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60056EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60056EB")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60056EC")]
	[Address(RVA = "0xB07950", Offset = "0xB06D50", VA = "0x180B07950", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60056ED")]
	[Address(RVA = "0xB07B60", Offset = "0xB06F60", VA = "0x180B07B60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientChallengeInitRequest other)
	{
	}

	[Token(Token = "0x60056EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60056EF")]
	[Address(RVA = "0xB07F10", Offset = "0xB07310", VA = "0x180B07F10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
