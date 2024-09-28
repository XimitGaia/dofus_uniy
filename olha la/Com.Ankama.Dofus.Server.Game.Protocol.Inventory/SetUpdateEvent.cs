using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetUpdateEvent : IMessage<SetUpdateEvent>, IMessage, IEquatable<SetUpdateEvent>, IDeepCloneable<SetUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SetUpdateEvent> _parser;

	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D4C")]
	public const int SetIdFieldNumber = 1;

	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x18")]
	private int setId_;

	[Token(Token = "0x4000D4E")]
	public const int ObjectsUidFieldNumber = 2;

	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectsUid_codec;

	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> objectsUid_;

	[Token(Token = "0x4000D51")]
	public const int EffectsFieldNumber = 3;

	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x170008A1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SetUpdateEvent> Parser
	{
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x9A9460", Offset = "0x9A8860", VA = "0x1809A9460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x9A93B0", Offset = "0x9A87B0", VA = "0x1809A93B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x9A9760", Offset = "0x9A8B60", VA = "0x1809A9760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SetId
	{
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ObjectsUid
	{
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600286E")]
	[Address(RVA = "0x9A92F0", Offset = "0x9A86F0", VA = "0x1809A92F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetUpdateEvent()
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0x9A9230", Offset = "0x9A8630", VA = "0x1809A9230")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetUpdateEvent(SetUpdateEvent other)
	{
	}

	[Token(Token = "0x6002870")]
	[Address(RVA = "0x9A8BC0", Offset = "0x9A7FC0", VA = "0x1809A8BC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SetUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002875")]
	[Address(RVA = "0x9A8CB0", Offset = "0x9A80B0", VA = "0x1809A8CB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002876")]
	[Address(RVA = "0x9A8DC0", Offset = "0x9A81C0", VA = "0x1809A8DC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002877")]
	[Address(RVA = "0x9A8E80", Offset = "0x9A8280", VA = "0x1809A8E80", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002878")]
	[Address(RVA = "0x9A8FF0", Offset = "0x9A83F0", VA = "0x1809A8FF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002879")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600287A")]
	[Address(RVA = "0x9A9650", Offset = "0x9A8A50", VA = "0x1809A9650", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600287B")]
	[Address(RVA = "0x9A8AA0", Offset = "0x9A7EA0", VA = "0x1809A8AA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600287C")]
	[Address(RVA = "0x9A8F40", Offset = "0x9A8340", VA = "0x1809A8F40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SetUpdateEvent other)
	{
	}

	[Token(Token = "0x600287D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600287E")]
	[Address(RVA = "0x9A94B0", Offset = "0x9A88B0", VA = "0x1809A94B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
