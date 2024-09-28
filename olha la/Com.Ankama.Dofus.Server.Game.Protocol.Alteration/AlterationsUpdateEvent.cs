using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration;

[Token(Token = "0x2000C47")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlterationsUpdateEvent : IMessage<AlterationsUpdateEvent>, IMessage, IEquatable<AlterationsUpdateEvent>, IDeepCloneable<AlterationsUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4002D84")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlterationsUpdateEvent> _parser;

	[Token(Token = "0x4002D85")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D86")]
	public const int AlterationsFieldNumber = 1;

	[Token(Token = "0x4002D87")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Alteration> _repeated_alterations_codec;

	[Token(Token = "0x4002D88")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Alteration> alterations_;

	[Token(Token = "0x17001C5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlterationsUpdateEvent> Parser
	{
		[Token(Token = "0x6008139")]
		[Address(RVA = "0xC82C50", Offset = "0xC82050", VA = "0x180C82C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C5C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600813A")]
		[Address(RVA = "0xC82BA0", Offset = "0xC81FA0", VA = "0x180C82BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600813B")]
		[Address(RVA = "0xC82E60", Offset = "0xC82260", VA = "0x180C82E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Alteration> Alterations
	{
		[Token(Token = "0x600813F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600813C")]
	[Address(RVA = "0xC82B20", Offset = "0xC81F20", VA = "0x180C82B20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlterationsUpdateEvent()
	{
	}

	[Token(Token = "0x600813D")]
	[Address(RVA = "0xC82A90", Offset = "0xC81E90", VA = "0x180C82A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationsUpdateEvent(AlterationsUpdateEvent other)
	{
	}

	[Token(Token = "0x600813E")]
	[Address(RVA = "0xC825E0", Offset = "0xC819E0", VA = "0x180C825E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationsUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008140")]
	[Address(RVA = "0xC82730", Offset = "0xC81B30", VA = "0x180C82730", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008141")]
	[Address(RVA = "0xC826A0", Offset = "0xC81AA0", VA = "0x180C826A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlterationsUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008142")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008143")]
	[Address(RVA = "0xC82890", Offset = "0xC81C90", VA = "0x180C82890", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008144")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008145")]
	[Address(RVA = "0xC82DB0", Offset = "0xC821B0", VA = "0x180C82DB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008146")]
	[Address(RVA = "0xC82540", Offset = "0xC81940", VA = "0x180C82540", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008147")]
	[Address(RVA = "0xC82810", Offset = "0xC81C10", VA = "0x180C82810", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlterationsUpdateEvent other)
	{
	}

	[Token(Token = "0x6008148")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008149")]
	[Address(RVA = "0xC82CA0", Offset = "0xC820A0", VA = "0x180C82CA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
