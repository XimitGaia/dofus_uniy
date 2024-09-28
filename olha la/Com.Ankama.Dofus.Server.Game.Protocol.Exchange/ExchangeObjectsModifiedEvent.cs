using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200069B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectsModifiedEvent : IMessage<ExchangeObjectsModifiedEvent>, IMessage, IEquatable<ExchangeObjectsModifiedEvent>, IDeepCloneable<ExchangeObjectsModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectsModifiedEvent> _parser;

	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400171E")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001720")]
	public const int ObjectsFieldNumber = 2;

	[Token(Token = "0x4001721")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4001722")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x17000F24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectsModifiedEvent> Parser
	{
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0xA93A70", Offset = "0xA92E70", VA = "0x180A93A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F25")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0xA939C0", Offset = "0xA92DC0", VA = "0x180A939C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F26")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0xA93CC0", Offset = "0xA930C0", VA = "0x180A93CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F27")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60046DF")]
	[Address(RVA = "0xA93940", Offset = "0xA92D40", VA = "0x180A93940")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsModifiedEvent()
	{
	}

	[Token(Token = "0x60046E0")]
	[Address(RVA = "0xA938B0", Offset = "0xA92CB0", VA = "0x180A938B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsModifiedEvent(ExchangeObjectsModifiedEvent other)
	{
	}

	[Token(Token = "0x60046E1")]
	[Address(RVA = "0xA93320", Offset = "0xA92720", VA = "0x180A93320", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60046E5")]
	[Address(RVA = "0xA93480", Offset = "0xA92880", VA = "0x180A93480", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046E6")]
	[Address(RVA = "0xA933E0", Offset = "0xA927E0", VA = "0x180A933E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeObjectsModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046E7")]
	[Address(RVA = "0xA93560", Offset = "0xA92960", VA = "0x180A93560", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60046E8")]
	[Address(RVA = "0xA936B0", Offset = "0xA92AB0", VA = "0x180A936B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60046E9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60046EA")]
	[Address(RVA = "0xA93BF0", Offset = "0xA92FF0", VA = "0x180A93BF0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60046EB")]
	[Address(RVA = "0xA93260", Offset = "0xA92660", VA = "0x180A93260", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60046EC")]
	[Address(RVA = "0xA93620", Offset = "0xA92A20", VA = "0x180A93620", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectsModifiedEvent other)
	{
	}

	[Token(Token = "0x60046ED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60046EE")]
	[Address(RVA = "0xA93AC0", Offset = "0xA92EC0", VA = "0x180A93AC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
