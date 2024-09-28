using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000943")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccountTag : IMessage<AccountTag>, IMessage, IEquatable<AccountTag>, IDeepCloneable<AccountTag>, IBufferMessage
{
	[Token(Token = "0x400203A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccountTag> _parser;

	[Token(Token = "0x400203B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400203C")]
	public const int NicknameFieldNumber = 1;

	[Token(Token = "0x400203D")]
	[FieldOffset(Offset = "0x18")]
	private string nickname_;

	[Token(Token = "0x400203E")]
	public const int TagFieldNumber = 2;

	[Token(Token = "0x400203F")]
	[FieldOffset(Offset = "0x20")]
	private string tag_;

	[Token(Token = "0x17001468")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AccountTag> Parser
	{
		[Token(Token = "0x6006076")]
		[Address(RVA = "0xB49360", Offset = "0xB48760", VA = "0x180B49360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001469")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006077")]
		[Address(RVA = "0xB492B0", Offset = "0xB486B0", VA = "0x180B492B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006078")]
		[Address(RVA = "0xB494A0", Offset = "0xB488A0", VA = "0x180B494A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Nickname
	{
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600607D")]
		[Address(RVA = "0xB49580", Offset = "0xB48980", VA = "0x180B49580")]
		set
		{
		}
	}

	[Token(Token = "0x1700146C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Tag
	{
		[Token(Token = "0x600607E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600607F")]
		[Address(RVA = "0xB495F0", Offset = "0xB489F0", VA = "0x180B495F0")]
		set
		{
		}
	}

	[Token(Token = "0x6006079")]
	[Address(RVA = "0xB49240", Offset = "0xB48640", VA = "0x180B49240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountTag()
	{
	}

	[Token(Token = "0x600607A")]
	[Address(RVA = "0xB49160", Offset = "0xB48560", VA = "0x180B49160")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountTag(AccountTag other)
	{
	}

	[Token(Token = "0x600607B")]
	[Address(RVA = "0xB48DC0", Offset = "0xB481C0", VA = "0x180B48DC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountTag Clone()
	{
		return null;
	}

	[Token(Token = "0x6006080")]
	[Address(RVA = "0xB48EC0", Offset = "0xB482C0", VA = "0x180B48EC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006081")]
	[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AccountTag other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006082")]
	[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006083")]
	[Address(RVA = "0xB49000", Offset = "0xB48400", VA = "0x180B49000", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006084")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006085")]
	[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006086")]
	[Address(RVA = "0xB48D00", Offset = "0xB48100", VA = "0x180B48D00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006087")]
	[Address(RVA = "0xB48F80", Offset = "0xB48380", VA = "0x180B48F80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AccountTag other)
	{
	}

	[Token(Token = "0x6006088")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006089")]
	[Address(RVA = "0xB493B0", Offset = "0xB487B0", VA = "0x180B493B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
