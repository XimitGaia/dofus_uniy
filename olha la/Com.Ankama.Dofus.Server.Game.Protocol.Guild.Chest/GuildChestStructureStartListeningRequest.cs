using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004E0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestStructureStartListeningRequest : IMessage<GuildChestStructureStartListeningRequest>, IMessage, IEquatable<GuildChestStructureStartListeningRequest>, IDeepCloneable<GuildChestStructureStartListeningRequest>, IBufferMessage
{
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestStructureStartListeningRequest> _parser;

	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000AEC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildChestStructureStartListeningRequest> Parser
	{
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x9EEE90", Offset = "0x9EE290", VA = "0x1809EEE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x9EEDE0", Offset = "0x9EE1E0", VA = "0x1809EEDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AEE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x9EEEE0", Offset = "0x9EE2E0", VA = "0x1809EEEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestStructureStartListeningRequest()
	{
	}

	[Token(Token = "0x600337D")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestStructureStartListeningRequest(GuildChestStructureStartListeningRequest other)
	{
	}

	[Token(Token = "0x600337E")]
	[Address(RVA = "0x9EEB80", Offset = "0x9EDF80", VA = "0x1809EEB80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestStructureStartListeningRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600337F")]
	[Address(RVA = "0x9EEC00", Offset = "0x9EE000", VA = "0x1809EEC00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildChestStructureStartListeningRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003381")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0x9EEC80", Offset = "0x9EE080", VA = "0x1809EEC80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003386")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestStructureStartListeningRequest other)
	{
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
