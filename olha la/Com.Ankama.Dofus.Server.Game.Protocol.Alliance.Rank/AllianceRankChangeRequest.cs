using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C83")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRankChangeRequest : IMessage<AllianceRankChangeRequest>, IMessage, IEquatable<AllianceRankChangeRequest>, IDeepCloneable<AllianceRankChangeRequest>, IBufferMessage
{
	[Token(Token = "0x4002E35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRankChangeRequest> _parser;

	[Token(Token = "0x4002E36")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E37")]
	public const int MemberIdFieldNumber = 1;

	[Token(Token = "0x4002E38")]
	[FieldOffset(Offset = "0x18")]
	private long memberId_;

	[Token(Token = "0x4002E39")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4002E3A")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x17001CD9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRankChangeRequest> Parser
	{
		[Token(Token = "0x60083B9")]
		[Address(RVA = "0xC76BB0", Offset = "0xC75FB0", VA = "0x180C76BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60083BA")]
		[Address(RVA = "0xC76B00", Offset = "0xC75F00", VA = "0x180C76B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60083BB")]
		[Address(RVA = "0xC76C00", Offset = "0xC76000", VA = "0x180C76C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MemberId
	{
		[Token(Token = "0x60083BF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60083C0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001CDD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x60083C1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60083C2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60083BC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankChangeRequest()
	{
	}

	[Token(Token = "0x60083BD")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankChangeRequest(AllianceRankChangeRequest other)
	{
	}

	[Token(Token = "0x60083BE")]
	[Address(RVA = "0xC76870", Offset = "0xC75C70", VA = "0x180C76870", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankChangeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60083C3")]
	[Address(RVA = "0xC76900", Offset = "0xC75D00", VA = "0x180C76900", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083C4")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceRankChangeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083C5")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60083C6")]
	[Address(RVA = "0xC769A0", Offset = "0xC75DA0", VA = "0x180C769A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60083C7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60083C8")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60083C9")]
	[Address(RVA = "0xC767B0", Offset = "0xC75BB0", VA = "0x180C767B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60083CA")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRankChangeRequest other)
	{
	}

	[Token(Token = "0x60083CB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60083CC")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
