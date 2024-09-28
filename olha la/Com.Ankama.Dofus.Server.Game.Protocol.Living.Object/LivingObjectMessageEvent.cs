using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Living.Object;

[Token(Token = "0x2000344")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LivingObjectMessageEvent : IMessage<LivingObjectMessageEvent>, IMessage, IEquatable<LivingObjectMessageEvent>, IDeepCloneable<LivingObjectMessageEvent>, IBufferMessage
{
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LivingObjectMessageEvent> _parser;

	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B43")]
	public const int MessageIdFieldNumber = 1;

	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x18")]
	private int messageId_;

	[Token(Token = "0x4000B45")]
	public const int TimestampFieldNumber = 2;

	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x20")]
	private long timestamp_;

	[Token(Token = "0x4000B47")]
	public const int OwnerNameFieldNumber = 3;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x28")]
	private string ownerName_;

	[Token(Token = "0x4000B49")]
	public const int ObjectGidFieldNumber = 4;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x30")]
	private int objectGid_;

	[Token(Token = "0x1700073C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LivingObjectMessageEvent> Parser
	{
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x978F80", Offset = "0x978380", VA = "0x180978F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x978ED0", Offset = "0x9782D0", VA = "0x180978ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x9791C0", Offset = "0x9785C0", VA = "0x1809791C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700073F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MessageId
	{
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000740")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Timestamp
	{
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000741")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OwnerName
	{
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x9792A0", Offset = "0x9786A0", VA = "0x1809792A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000742")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x978E80", Offset = "0x978280", VA = "0x180978E80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LivingObjectMessageEvent()
	{
	}

	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x978DD0", Offset = "0x9781D0", VA = "0x180978DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectMessageEvent(LivingObjectMessageEvent other)
	{
	}

	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x9788F0", Offset = "0x977CF0", VA = "0x1809788F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LivingObjectMessageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x9789D0", Offset = "0x977DD0", VA = "0x1809789D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x978AA0", Offset = "0x977EA0", VA = "0x180978AA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LivingObjectMessageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x978B20", Offset = "0x977F20", VA = "0x180978B20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x978C70", Offset = "0x978070", VA = "0x180978C70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x9790F0", Offset = "0x9784F0", VA = "0x1809790F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x9787E0", Offset = "0x977BE0", VA = "0x1809787E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x978BF0", Offset = "0x977FF0", VA = "0x180978BF0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LivingObjectMessageEvent other)
	{
	}

	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x978FD0", Offset = "0x9783D0", VA = "0x180978FD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
