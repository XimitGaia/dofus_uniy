using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003EA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StatedMapUpdateEvent : IMessage<StatedMapUpdateEvent>, IMessage, IEquatable<StatedMapUpdateEvent>, IDeepCloneable<StatedMapUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StatedMapUpdateEvent> _parser;

	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D84")]
	public const int StatedElementsFieldNumber = 1;

	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<StatedElement> _repeated_statedElements_codec;

	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<StatedElement> statedElements_;

	[Token(Token = "0x170008C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StatedMapUpdateEvent> Parser
	{
		[Token(Token = "0x6002904")]
		[Address(RVA = "0x9AB310", Offset = "0x9AA710", VA = "0x1809AB310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002905")]
		[Address(RVA = "0x9AB260", Offset = "0x9AA660", VA = "0x1809AB260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002906")]
		[Address(RVA = "0x9AB520", Offset = "0x9AA920", VA = "0x1809AB520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<StatedElement> StatedElements
	{
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x9AB1E0", Offset = "0x9AA5E0", VA = "0x1809AB1E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StatedMapUpdateEvent()
	{
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x9AB150", Offset = "0x9AA550", VA = "0x1809AB150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StatedMapUpdateEvent(StatedMapUpdateEvent other)
	{
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x9AACA0", Offset = "0x9AA0A0", VA = "0x1809AACA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StatedMapUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x9AAD60", Offset = "0x9AA160", VA = "0x1809AAD60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600290C")]
	[Address(RVA = "0x9AAE40", Offset = "0x9AA240", VA = "0x1809AAE40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StatedMapUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600290D")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600290E")]
	[Address(RVA = "0x9AAF50", Offset = "0x9AA350", VA = "0x1809AAF50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600290F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x9AB470", Offset = "0x9AA870", VA = "0x1809AB470", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002911")]
	[Address(RVA = "0x9AAC00", Offset = "0x9AA000", VA = "0x1809AAC00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002912")]
	[Address(RVA = "0x9AAED0", Offset = "0x9AA2D0", VA = "0x1809AAED0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StatedMapUpdateEvent other)
	{
	}

	[Token(Token = "0x6002913")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002914")]
	[Address(RVA = "0x9AB360", Offset = "0x9AA760", VA = "0x1809AB360", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
