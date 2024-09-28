using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003E8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveMapUpdateEvent : IMessage<InteractiveMapUpdateEvent>, IMessage, IEquatable<InteractiveMapUpdateEvent>, IDeepCloneable<InteractiveMapUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveMapUpdateEvent> _parser;

	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D7E")]
	public const int InteractiveElementsFieldNumber = 1;

	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<InteractiveElement> _repeated_interactiveElements_codec;

	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<InteractiveElement> interactiveElements_;

	[Token(Token = "0x170008C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractiveMapUpdateEvent> Parser
	{
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x9A6050", Offset = "0x9A5450", VA = "0x1809A6050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x9A5FA0", Offset = "0x9A53A0", VA = "0x1809A5FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x9A6260", Offset = "0x9A5660", VA = "0x1809A6260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<InteractiveElement> InteractiveElements
	{
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x9A5F20", Offset = "0x9A5320", VA = "0x1809A5F20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveMapUpdateEvent()
	{
	}

	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x9A5E90", Offset = "0x9A5290", VA = "0x1809A5E90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveMapUpdateEvent(InteractiveMapUpdateEvent other)
	{
	}

	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x9A59E0", Offset = "0x9A4DE0", VA = "0x1809A59E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveMapUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x9A5B30", Offset = "0x9A4F30", VA = "0x1809A5B30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x9A5AA0", Offset = "0x9A4EA0", VA = "0x1809A5AA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(InteractiveMapUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x9A5C90", Offset = "0x9A5090", VA = "0x1809A5C90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x9A61B0", Offset = "0x9A55B0", VA = "0x1809A61B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x9A5940", Offset = "0x9A4D40", VA = "0x1809A5940", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x9A5C10", Offset = "0x9A5010", VA = "0x1809A5C10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InteractiveMapUpdateEvent other)
	{
	}

	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x9A60A0", Offset = "0x9A54A0", VA = "0x1809A60A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
