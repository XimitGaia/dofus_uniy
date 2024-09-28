using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000490")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildModificationEmblemValidRequest : IMessage<GuildModificationEmblemValidRequest>, IMessage, IEquatable<GuildModificationEmblemValidRequest>, IDeepCloneable<GuildModificationEmblemValidRequest>, IBufferMessage
{
	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildModificationEmblemValidRequest> _parser;

	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FA8")]
	public const int EmblemFieldNumber = 1;

	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x18")]
	private SocialEmblem emblem_;

	[Token(Token = "0x17000A39")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildModificationEmblemValidRequest> Parser
	{
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x9D8E10", Offset = "0x9D8210", VA = "0x1809D8E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x9D8D60", Offset = "0x9D8160", VA = "0x1809D8D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x9D8F60", Offset = "0x9D8360", VA = "0x1809D8F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialEmblem Emblem
	{
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationEmblemValidRequest()
	{
	}

	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x9D8CF0", Offset = "0x9D80F0", VA = "0x1809D8CF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationEmblemValidRequest(GuildModificationEmblemValidRequest other)
	{
	}

	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x9D8970", Offset = "0x9D7D70", VA = "0x1809D8970", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationEmblemValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x9D8A10", Offset = "0x9D7E10", VA = "0x1809D8A10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003001")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildModificationEmblemValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003002")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003003")]
	[Address(RVA = "0x9D8B90", Offset = "0x9D7F90", VA = "0x1809D8B90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003004")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003005")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003006")]
	[Address(RVA = "0x9D88E0", Offset = "0x9D7CE0", VA = "0x1809D88E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003007")]
	[Address(RVA = "0x9D8AC0", Offset = "0x9D7EC0", VA = "0x1809D8AC0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildModificationEmblemValidRequest other)
	{
	}

	[Token(Token = "0x6003008")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003009")]
	[Address(RVA = "0x9D8E60", Offset = "0x9D8260", VA = "0x1809D8E60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
