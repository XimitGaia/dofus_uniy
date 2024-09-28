using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004A6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildNoteUpdateRequest : IMessage<GuildNoteUpdateRequest>, IMessage, IEquatable<GuildNoteUpdateRequest>, IDeepCloneable<GuildNoteUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildNoteUpdateRequest> _parser;

	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FE3")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x4000FE5")]
	public const int NoteFieldNumber = 2;

	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x20")]
	private string note_;

	[Token(Token = "0x17000A67")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildNoteUpdateRequest> Parser
	{
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x9DBBB0", Offset = "0x9DAFB0", VA = "0x1809DBBB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A68")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x9DBB00", Offset = "0x9DAF00", VA = "0x1809DBB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A69")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x9DBCE0", Offset = "0x9DB0E0", VA = "0x1809DBCE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000A6B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Note
	{
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x9DBDC0", Offset = "0x9DB1C0", VA = "0x1809DBDC0")]
		set
		{
		}
	}

	[Token(Token = "0x60030F1")]
	[Address(RVA = "0x9DBA00", Offset = "0x9DAE00", VA = "0x1809DBA00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildNoteUpdateRequest()
	{
	}

	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x9DBA50", Offset = "0x9DAE50", VA = "0x1809DBA50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildNoteUpdateRequest(GuildNoteUpdateRequest other)
	{
	}

	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x9DB6A0", Offset = "0x9DAAA0", VA = "0x1809DB6A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildNoteUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x9DB770", Offset = "0x9DAB70", VA = "0x1809DB770", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x92C840", Offset = "0x92BC40", VA = "0x18092C840", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildNoteUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x92C8B0", Offset = "0x92BCB0", VA = "0x18092C8B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x9DB8A0", Offset = "0x9DACA0", VA = "0x1809DB8A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60030FD")]
	[Address(RVA = "0x92CDC0", Offset = "0x92C1C0", VA = "0x18092CDC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60030FE")]
	[Address(RVA = "0x9DB5E0", Offset = "0x9DA9E0", VA = "0x1809DB5E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x9DB830", Offset = "0x9DAC30", VA = "0x1809DB830", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildNoteUpdateRequest other)
	{
	}

	[Token(Token = "0x6003100")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003101")]
	[Address(RVA = "0x9DBC00", Offset = "0x9DB000", VA = "0x1809DBC00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
