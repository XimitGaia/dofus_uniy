using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008DA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeResultEvent : IMessage<ChallengeResultEvent>, IMessage, IEquatable<ChallengeResultEvent>, IDeepCloneable<ChallengeResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeResultEvent> _parser;

	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E71")]
	public const int ChallengeIdFieldNumber = 1;

	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0x18")]
	private int challengeId_;

	[Token(Token = "0x4001E73")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0x1C")]
	private bool success_;

	[Token(Token = "0x170013DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeResultEvent> Parser
	{
		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0xB5DC60", Offset = "0xB5D060", VA = "0x180B5DC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0xB5DBB0", Offset = "0xB5CFB0", VA = "0x180B5DBB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0xB5DCB0", Offset = "0xB5D0B0", VA = "0x180B5DCB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChallengeId
	{
		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170013E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6005DAA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeResultEvent()
	{
	}

	[Token(Token = "0x6005DAB")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeResultEvent(ChallengeResultEvent other)
	{
	}

	[Token(Token = "0x6005DAC")]
	[Address(RVA = "0xB5D870", Offset = "0xB5CC70", VA = "0x180B5D870", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005DB1")]
	[Address(RVA = "0xB5D900", Offset = "0xB5CD00", VA = "0x180B5D900", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DB2")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DB3")]
	[Address(RVA = "0xB5D990", Offset = "0xB5CD90", VA = "0x180B5D990", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005DB4")]
	[Address(RVA = "0xB5DA50", Offset = "0xB5CE50", VA = "0x180B5DA50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005DB5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005DB6")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005DB7")]
	[Address(RVA = "0xB5D7E0", Offset = "0xB5CBE0", VA = "0x180B5D7E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005DB8")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeResultEvent other)
	{
	}

	[Token(Token = "0x6005DB9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005DBA")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
