using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000492")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildModificationValidRequest : IMessage<GuildModificationValidRequest>, IMessage, IEquatable<GuildModificationValidRequest>, IDeepCloneable<GuildModificationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildModificationValidRequest> _parser;

	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FAD")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x4000FAF")]
	public const int EmblemFieldNumber = 2;

	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x20")]
	private SocialEmblem emblem_;

	[Token(Token = "0x17000A3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildModificationValidRequest> Parser
	{
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x9DAB30", Offset = "0x9D9F30", VA = "0x1809DAB30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x9DAA80", Offset = "0x9D9E80", VA = "0x1809DAA80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003010")]
		[Address(RVA = "0x9DACC0", Offset = "0x9DA0C0", VA = "0x1809DACC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6003014")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x9DADA0", Offset = "0x9DA1A0", VA = "0x1809DADA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A41")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialEmblem Emblem
	{
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6003011")]
	[Address(RVA = "0x9DAA30", Offset = "0x9D9E30", VA = "0x1809DAA30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationValidRequest()
	{
	}

	[Token(Token = "0x6003012")]
	[Address(RVA = "0x9DA970", Offset = "0x9D9D70", VA = "0x1809DA970")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationValidRequest(GuildModificationValidRequest other)
	{
	}

	[Token(Token = "0x6003013")]
	[Address(RVA = "0x9DA570", Offset = "0x9D9970", VA = "0x1809DA570", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003018")]
	[Address(RVA = "0x9DA660", Offset = "0x9D9A60", VA = "0x1809DA660", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003019")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildModificationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600301A")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600301B")]
	[Address(RVA = "0x9DA810", Offset = "0x9D9C10", VA = "0x1809DA810", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600301C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600301D")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600301E")]
	[Address(RVA = "0x9DA4B0", Offset = "0x9D98B0", VA = "0x1809DA4B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600301F")]
	[Address(RVA = "0x9DA720", Offset = "0x9D9B20", VA = "0x1809DA720", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildModificationValidRequest other)
	{
	}

	[Token(Token = "0x6003020")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003021")]
	[Address(RVA = "0x9DAB80", Offset = "0x9D9F80", VA = "0x1809DAB80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
