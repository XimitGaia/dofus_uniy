using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004E2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestStructureStopListeningRequest : IMessage<GuildChestStructureStopListeningRequest>, IMessage, IEquatable<GuildChestStructureStopListeningRequest>, IDeepCloneable<GuildChestStructureStopListeningRequest>, IBufferMessage
{
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestStructureStopListeningRequest> _parser;

	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000AEF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestStructureStopListeningRequest> Parser
	{
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x9EF2D0", Offset = "0x9EE6D0", VA = "0x1809EF2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x9EF220", Offset = "0x9EE620", VA = "0x1809EF220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x9EF320", Offset = "0x9EE720", VA = "0x1809EF320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestStructureStopListeningRequest()
	{
	}

	[Token(Token = "0x6003391")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestStructureStopListeningRequest(GuildChestStructureStopListeningRequest other)
	{
	}

	[Token(Token = "0x6003392")]
	[Address(RVA = "0x9EEFC0", Offset = "0x9EE3C0", VA = "0x1809EEFC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestStructureStopListeningRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0x9EF040", Offset = "0x9EE440", VA = "0x1809EF040", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003394")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildChestStructureStopListeningRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003395")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003396")]
	[Address(RVA = "0x9EF0C0", Offset = "0x9EE4C0", VA = "0x1809EF0C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003397")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003399")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600339A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestStructureStopListeningRequest other)
	{
	}

	[Token(Token = "0x600339B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600339C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
