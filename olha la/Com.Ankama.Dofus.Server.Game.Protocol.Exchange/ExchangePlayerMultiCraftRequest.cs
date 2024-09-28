using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000666")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangePlayerMultiCraftRequest : IMessage<ExchangePlayerMultiCraftRequest>, IMessage, IEquatable<ExchangePlayerMultiCraftRequest>, IDeepCloneable<ExchangePlayerMultiCraftRequest>, IBufferMessage
{
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangePlayerMultiCraftRequest> _parser;

	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001668")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x400166A")]
	public const int TargetIdFieldNumber = 2;

	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0x20")]
	private long targetId_;

	[Token(Token = "0x400166C")]
	public const int SkillIdFieldNumber = 3;

	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x28")]
	private int skillId_;

	[Token(Token = "0x17000EB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangePlayerMultiCraftRequest> Parser
	{
		[Token(Token = "0x600449B")]
		[Address(RVA = "0xA955F0", Offset = "0xA949F0", VA = "0x180A955F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600449C")]
		[Address(RVA = "0xA95540", Offset = "0xA94940", VA = "0x180A95540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600449D")]
		[Address(RVA = "0xA956E0", Offset = "0xA94AE0", VA = "0x180A956E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60044A2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60044A4")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000EB5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillId
	{
		[Token(Token = "0x60044A5")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangePlayerMultiCraftRequest()
	{
	}

	[Token(Token = "0x600449F")]
	[Address(RVA = "0x963AD0", Offset = "0x962ED0", VA = "0x180963AD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangePlayerMultiCraftRequest(ExchangePlayerMultiCraftRequest other)
	{
	}

	[Token(Token = "0x60044A0")]
	[Address(RVA = "0xA952B0", Offset = "0xA946B0", VA = "0x180A952B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangePlayerMultiCraftRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60044A7")]
	[Address(RVA = "0xA95340", Offset = "0xA94740", VA = "0x180A95340", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044A8")]
	[Address(RVA = "0x963810", Offset = "0x962C10", VA = "0x180963810", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangePlayerMultiCraftRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044A9")]
	[Address(RVA = "0xA30000", Offset = "0xA2F400", VA = "0x180A30000", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60044AA")]
	[Address(RVA = "0xA953E0", Offset = "0xA947E0", VA = "0x180A953E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0xA95640", Offset = "0xA94A40", VA = "0x180A95640", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0xA951D0", Offset = "0xA945D0", VA = "0x180A951D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0x963900", Offset = "0x962D00", VA = "0x180963900", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangePlayerMultiCraftRequest other)
	{
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0x963C30", Offset = "0x963030", VA = "0x180963C30", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
