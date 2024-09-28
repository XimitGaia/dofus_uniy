using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x2000468")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRightsUpdateRequest : IMessage<GuildRightsUpdateRequest>, IMessage, IEquatable<GuildRightsUpdateRequest>, IDeepCloneable<GuildRightsUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRightsUpdateRequest> _parser;

	[Token(Token = "0x4000F17")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F18")]
	public const int RankIdFieldNumber = 1;

	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x18")]
	private int rankId_;

	[Token(Token = "0x4000F1A")]
	public const int RightsFieldNumber = 2;

	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_rights_codec;

	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> rights_;

	[Token(Token = "0x170009E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRightsUpdateRequest> Parser
	{
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x9B62A0", Offset = "0x9B56A0", VA = "0x1809B62A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x9B61F0", Offset = "0x9B55F0", VA = "0x1809B61F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x9B64F0", Offset = "0x9B58F0", VA = "0x1809B64F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankId
	{
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170009E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Rights
	{
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x9B6070", Offset = "0x9B5470", VA = "0x1809B6070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRightsUpdateRequest()
	{
	}

	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x9B60F0", Offset = "0x9B54F0", VA = "0x1809B60F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRightsUpdateRequest(GuildRightsUpdateRequest other)
	{
	}

	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x9B5BA0", Offset = "0x9B4FA0", VA = "0x1809B5BA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRightsUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x9B5D70", Offset = "0x9B5170", VA = "0x1809B5D70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x9B5CD0", Offset = "0x9B50D0", VA = "0x1809B5CD0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRightsUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x9B5EE0", Offset = "0x9B52E0", VA = "0x1809B5EE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x9B6420", Offset = "0x9B5820", VA = "0x1809B6420", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x9B5AC0", Offset = "0x9B4EC0", VA = "0x1809B5AC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x9B5E50", Offset = "0x9B5250", VA = "0x1809B5E50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRightsUpdateRequest other)
	{
	}

	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x9B62F0", Offset = "0x9B56F0", VA = "0x1809B62F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
