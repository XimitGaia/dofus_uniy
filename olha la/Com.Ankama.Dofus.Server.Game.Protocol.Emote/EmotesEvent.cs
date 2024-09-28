using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x2000739")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmotesEvent : IMessage<EmotesEvent>, IMessage, IEquatable<EmotesEvent>, IDeepCloneable<EmotesEvent>, IBufferMessage
{
	[Token(Token = "0x400196B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmotesEvent> _parser;

	[Token(Token = "0x400196C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400196D")]
	public const int EmotesIdFieldNumber = 1;

	[Token(Token = "0x400196E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_emotesId_codec;

	[Token(Token = "0x400196F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> emotesId_;

	[Token(Token = "0x17001099")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EmotesEvent> Parser
	{
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0xAB8360", Offset = "0xAB7760", VA = "0x180AB8360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004D89")]
		[Address(RVA = "0xAB82B0", Offset = "0xAB76B0", VA = "0x180AB82B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0xAB8580", Offset = "0xAB7980", VA = "0x180AB8580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700109C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> EmotesId
	{
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D8B")]
	[Address(RVA = "0xAB81A0", Offset = "0xAB75A0", VA = "0x180AB81A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotesEvent()
	{
	}

	[Token(Token = "0x6004D8C")]
	[Address(RVA = "0xAB8220", Offset = "0xAB7620", VA = "0x180AB8220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotesEvent(EmotesEvent other)
	{
	}

	[Token(Token = "0x6004D8D")]
	[Address(RVA = "0xAB7D60", Offset = "0xAB7160", VA = "0x180AB7D60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004D8F")]
	[Address(RVA = "0xAB7EB0", Offset = "0xAB72B0", VA = "0x180AB7EB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D90")]
	[Address(RVA = "0xAB7E20", Offset = "0xAB7220", VA = "0x180AB7E20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EmotesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D91")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004D92")]
	[Address(RVA = "0xAB8010", Offset = "0xAB7410", VA = "0x180AB8010", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004D93")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004D94")]
	[Address(RVA = "0xAB84D0", Offset = "0xAB78D0", VA = "0x180AB84D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004D95")]
	[Address(RVA = "0xAB7CC0", Offset = "0xAB70C0", VA = "0x180AB7CC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004D96")]
	[Address(RVA = "0xAB7F90", Offset = "0xAB7390", VA = "0x180AB7F90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EmotesEvent other)
	{
	}

	[Token(Token = "0x6004D97")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004D98")]
	[Address(RVA = "0xAB83B0", Offset = "0xAB77B0", VA = "0x180AB83B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
