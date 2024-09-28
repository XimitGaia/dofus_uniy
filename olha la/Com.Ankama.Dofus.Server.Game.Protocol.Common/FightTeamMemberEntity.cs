using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A34")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMemberEntity : IMessage<FightTeamMemberEntity>, IMessage, IEquatable<FightTeamMemberEntity>, IDeepCloneable<FightTeamMemberEntity>, IBufferMessage
{
	[Token(Token = "0x40024BC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMemberEntity> _parser;

	[Token(Token = "0x40024BD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024BE")]
	public const int EntityModelIdFieldNumber = 1;

	[Token(Token = "0x40024BF")]
	[FieldOffset(Offset = "0x18")]
	private int entityModelId_;

	[Token(Token = "0x40024C0")]
	public const int LevelFieldNumber = 2;

	[Token(Token = "0x40024C1")]
	[FieldOffset(Offset = "0x1C")]
	private int level_;

	[Token(Token = "0x40024C2")]
	public const int MasterIdFieldNumber = 3;

	[Token(Token = "0x40024C3")]
	[FieldOffset(Offset = "0x20")]
	private long masterId_;

	[Token(Token = "0x17001707")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamMemberEntity> Parser
	{
		[Token(Token = "0x6006AA1")]
		[Address(RVA = "0xBBCEC0", Offset = "0xBBC2C0", VA = "0x180BBCEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001708")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006AA2")]
		[Address(RVA = "0xBBCE10", Offset = "0xBBC210", VA = "0x180BBCE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001709")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0xBBCF10", Offset = "0xBBC310", VA = "0x180BBCF10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EntityModelId
	{
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700170B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		[Token(Token = "0x6006AA9")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006AAA")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700170C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MasterId
	{
		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6006AA4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberEntity()
	{
	}

	[Token(Token = "0x6006AA5")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberEntity(FightTeamMemberEntity other)
	{
	}

	[Token(Token = "0x6006AA6")]
	[Address(RVA = "0xBBCB80", Offset = "0xBBBF80", VA = "0x180BBCB80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberEntity Clone()
	{
		return null;
	}

	[Token(Token = "0x6006AAD")]
	[Address(RVA = "0xBBCC10", Offset = "0xBBC010", VA = "0x180BBCC10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AAE")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTeamMemberEntity other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AAF")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006AB0")]
	[Address(RVA = "0xBBCCB0", Offset = "0xBBC0B0", VA = "0x180BBCCB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006AB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006AB2")]
	[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006AB3")]
	[Address(RVA = "0xBBCAA0", Offset = "0xBBBEA0", VA = "0x180BBCAA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006AB4")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamMemberEntity other)
	{
	}

	[Token(Token = "0x6006AB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006AB6")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
