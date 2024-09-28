using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C87")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRightsUpdateRequest : IMessage<AllianceRightsUpdateRequest>, IMessage, IEquatable<AllianceRightsUpdateRequest>, IDeepCloneable<AllianceRightsUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002E42")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRightsUpdateRequest> _parser;

	[Token(Token = "0x4002E43")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E44")]
	public const int RankIdFieldNumber = 1;

	[Token(Token = "0x4002E45")]
	[FieldOffset(Offset = "0x18")]
	private int rankId_;

	[Token(Token = "0x4002E46")]
	public const int RightsFieldNumber = 2;

	[Token(Token = "0x4002E47")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_rights_codec;

	[Token(Token = "0x4002E48")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> rights_;

	[Token(Token = "0x17001CE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRightsUpdateRequest> Parser
	{
		[Token(Token = "0x60083E6")]
		[Address(RVA = "0xC7EF70", Offset = "0xC7E370", VA = "0x180C7EF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60083E7")]
		[Address(RVA = "0xC7EEC0", Offset = "0xC7E2C0", VA = "0x180C7EEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60083E8")]
		[Address(RVA = "0xC7F1C0", Offset = "0xC7E5C0", VA = "0x180C7F1C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankId
	{
		[Token(Token = "0x60083EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60083ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001CE6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Rights
	{
		[Token(Token = "0x60083EE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60083E9")]
	[Address(RVA = "0xC7EE40", Offset = "0xC7E240", VA = "0x180C7EE40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRightsUpdateRequest()
	{
	}

	[Token(Token = "0x60083EA")]
	[Address(RVA = "0xC7EDB0", Offset = "0xC7E1B0", VA = "0x180C7EDB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRightsUpdateRequest(AllianceRightsUpdateRequest other)
	{
	}

	[Token(Token = "0x60083EB")]
	[Address(RVA = "0xC7E950", Offset = "0xC7DD50", VA = "0x180C7E950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRightsUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60083EF")]
	[Address(RVA = "0xC7EAB0", Offset = "0xC7DEB0", VA = "0x180C7EAB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083F0")]
	[Address(RVA = "0xC7EA10", Offset = "0xC7DE10", VA = "0x180C7EA10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRightsUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60083F1")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60083F2")]
	[Address(RVA = "0xC7EC20", Offset = "0xC7E020", VA = "0x180C7EC20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60083F3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60083F4")]
	[Address(RVA = "0xC7F0F0", Offset = "0xC7E4F0", VA = "0x180C7F0F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60083F5")]
	[Address(RVA = "0xC7E870", Offset = "0xC7DC70", VA = "0x180C7E870", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60083F6")]
	[Address(RVA = "0xC7EB90", Offset = "0xC7DF90", VA = "0x180C7EB90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRightsUpdateRequest other)
	{
	}

	[Token(Token = "0x60083F7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60083F8")]
	[Address(RVA = "0xC7EFC0", Offset = "0xC7E3C0", VA = "0x180C7EFC0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
