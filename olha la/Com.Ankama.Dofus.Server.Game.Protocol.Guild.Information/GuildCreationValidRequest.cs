using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000494")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCreationValidRequest : IMessage<GuildCreationValidRequest>, IMessage, IEquatable<GuildCreationValidRequest>, IDeepCloneable<GuildCreationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCreationValidRequest> _parser;

	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FB4")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000FB5")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4000FB6")]
	public const int EmblemFieldNumber = 2;

	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x20")]
	private SocialEmblem emblem_;

	[Token(Token = "0x17000A42")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildCreationValidRequest> Parser
	{
		[Token(Token = "0x6003026")]
		[Address(RVA = "0x9CB080", Offset = "0x9CA480", VA = "0x1809CB080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A43")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003027")]
		[Address(RVA = "0x9CAFD0", Offset = "0x9CA3D0", VA = "0x1809CAFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A44")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003028")]
		[Address(RVA = "0x9CB210", Offset = "0x9CA610", VA = "0x1809CB210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A45")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x600302C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x9CB2F0", Offset = "0x9CA6F0", VA = "0x1809CB2F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A46")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialEmblem Emblem
	{
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600302F")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6003029")]
	[Address(RVA = "0x9CAEC0", Offset = "0x9CA2C0", VA = "0x1809CAEC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationValidRequest()
	{
	}

	[Token(Token = "0x600302A")]
	[Address(RVA = "0x9CAF10", Offset = "0x9CA310", VA = "0x1809CAF10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCreationValidRequest(GuildCreationValidRequest other)
	{
	}

	[Token(Token = "0x600302B")]
	[Address(RVA = "0x9CAAC0", Offset = "0x9C9EC0", VA = "0x1809CAAC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003030")]
	[Address(RVA = "0x9CABB0", Offset = "0x9C9FB0", VA = "0x1809CABB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003031")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildCreationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003032")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003033")]
	[Address(RVA = "0x9CAD60", Offset = "0x9CA160", VA = "0x1809CAD60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003034")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003035")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003036")]
	[Address(RVA = "0x9CAA00", Offset = "0x9C9E00", VA = "0x1809CAA00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003037")]
	[Address(RVA = "0x9CAC70", Offset = "0x9CA070", VA = "0x1809CAC70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCreationValidRequest other)
	{
	}

	[Token(Token = "0x6003038")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003039")]
	[Address(RVA = "0x9CB0D0", Offset = "0x9CA4D0", VA = "0x1809CB0D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
