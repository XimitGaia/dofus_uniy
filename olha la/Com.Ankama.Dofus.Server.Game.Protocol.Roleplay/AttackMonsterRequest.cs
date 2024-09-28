using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000166")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AttackMonsterRequest : IMessage<AttackMonsterRequest>, IMessage, IEquatable<AttackMonsterRequest>, IDeepCloneable<AttackMonsterRequest>, IBufferMessage
{
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AttackMonsterRequest> _parser;

	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004C0")]
	public const int MonsterGroupIdFieldNumber = 1;

	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x18")]
	private long monsterGroupId_;

	[Token(Token = "0x170002F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AttackMonsterRequest> Parser
	{
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0xC42780", Offset = "0xC41B80", VA = "0x180C42780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0xC426D0", Offset = "0xC41AD0", VA = "0x180C426D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0xC427D0", Offset = "0xC41BD0", VA = "0x180C427D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MonsterGroupId
	{
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttackMonsterRequest()
	{
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttackMonsterRequest(AttackMonsterRequest other)
	{
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0xC42460", Offset = "0xC41860", VA = "0x180C42460", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttackMonsterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0xC424E0", Offset = "0xC418E0", VA = "0x180C424E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AttackMonsterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0xC42570", Offset = "0xC41970", VA = "0x180C42570", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0xC423D0", Offset = "0xC417D0", VA = "0x180C423D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AttackMonsterRequest other)
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
