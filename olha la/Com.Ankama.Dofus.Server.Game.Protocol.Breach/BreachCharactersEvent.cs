using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000905")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachCharactersEvent : IMessage<BreachCharactersEvent>, IMessage, IEquatable<BreachCharactersEvent>, IDeepCloneable<BreachCharactersEvent>, IBufferMessage
{
	[Token(Token = "0x4001EE0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachCharactersEvent> _parser;

	[Token(Token = "0x4001EE1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EE2")]
	public const int PlayersFieldNumber = 1;

	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_players_codec;

	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<long> players_;

	[Token(Token = "0x17001431")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachCharactersEvent> Parser
	{
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0xB4F260", Offset = "0xB4E660", VA = "0x180B4F260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001432")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0xB4F1B0", Offset = "0xB4E5B0", VA = "0x180B4F1B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001433")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0xB4F480", Offset = "0xB4E880", VA = "0x180B4F480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001434")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> Players
	{
		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005F67")]
	[Address(RVA = "0xB4F130", Offset = "0xB4E530", VA = "0x180B4F130")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachCharactersEvent()
	{
	}

	[Token(Token = "0x6005F68")]
	[Address(RVA = "0xB4F0A0", Offset = "0xB4E4A0", VA = "0x180B4F0A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachCharactersEvent(BreachCharactersEvent other)
	{
	}

	[Token(Token = "0x6005F69")]
	[Address(RVA = "0xB4EC60", Offset = "0xB4E060", VA = "0x180B4EC60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachCharactersEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F6B")]
	[Address(RVA = "0xB4EDB0", Offset = "0xB4E1B0", VA = "0x180B4EDB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F6C")]
	[Address(RVA = "0xB4ED20", Offset = "0xB4E120", VA = "0x180B4ED20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachCharactersEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F6D")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F6E")]
	[Address(RVA = "0xB4EF10", Offset = "0xB4E310", VA = "0x180B4EF10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F6F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F70")]
	[Address(RVA = "0xB4F3D0", Offset = "0xB4E7D0", VA = "0x180B4F3D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F71")]
	[Address(RVA = "0xB4EBC0", Offset = "0xB4DFC0", VA = "0x180B4EBC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F72")]
	[Address(RVA = "0xB4EE90", Offset = "0xB4E290", VA = "0x180B4EE90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachCharactersEvent other)
	{
	}

	[Token(Token = "0x6005F73")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F74")]
	[Address(RVA = "0xB4F2B0", Offset = "0xB4E6B0", VA = "0x180B4F2B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
