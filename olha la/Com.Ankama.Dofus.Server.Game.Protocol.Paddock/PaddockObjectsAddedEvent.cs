using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002B9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockObjectsAddedEvent : IMessage<PaddockObjectsAddedEvent>, IMessage, IEquatable<PaddockObjectsAddedEvent>, IDeepCloneable<PaddockObjectsAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockObjectsAddedEvent> _parser;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000995")]
	public const int PaddockItemFieldNumber = 1;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectInRolePlay> _repeated_paddockItem_codec;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectInRolePlay> paddockItem_;

	[Token(Token = "0x1700061D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockObjectsAddedEvent> Parser
	{
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0xD099A0", Offset = "0xD08DA0", VA = "0x180D099A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0xD098F0", Offset = "0xD08CF0", VA = "0x180D098F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0xD09BB0", Offset = "0xD08FB0", VA = "0x180D09BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000620")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectInRolePlay> PaddockItem
	{
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0xD097E0", Offset = "0xD08BE0", VA = "0x180D097E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockObjectsAddedEvent()
	{
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0xD09860", Offset = "0xD08C60", VA = "0x180D09860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectsAddedEvent(PaddockObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0xD09330", Offset = "0xD08730", VA = "0x180D09330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectsAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C66")]
	[Address(RVA = "0xD09480", Offset = "0xD08880", VA = "0x180D09480", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C67")]
	[Address(RVA = "0xD093F0", Offset = "0xD087F0", VA = "0x180D093F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockObjectsAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C69")]
	[Address(RVA = "0xD095E0", Offset = "0xD089E0", VA = "0x180D095E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0xD09B00", Offset = "0xD08F00", VA = "0x180D09B00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0xD09290", Offset = "0xD08690", VA = "0x180D09290", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0xD09560", Offset = "0xD08960", VA = "0x180D09560", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0xD099F0", Offset = "0xD08DF0", VA = "0x180D099F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
