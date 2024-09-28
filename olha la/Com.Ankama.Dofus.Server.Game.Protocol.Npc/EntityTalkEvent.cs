using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002E9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityTalkEvent : IMessage<EntityTalkEvent>, IMessage, IEquatable<EntityTalkEvent>, IDeepCloneable<EntityTalkEvent>, IBufferMessage
{
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntityTalkEvent> _parser;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A42")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x18")]
	private long entityId_;

	[Token(Token = "0x4000A44")]
	public const int TextIdFieldNumber = 2;

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x20")]
	private int textId_;

	[Token(Token = "0x4000A46")]
	public const int ParametersFieldNumber = 3;

	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_parameters_codec;

	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<string> parameters_;

	[Token(Token = "0x17000687")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntityTalkEvent> Parser
	{
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0xD1A750", Offset = "0xD19B50", VA = "0x180D1A750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000688")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0xD1A6A0", Offset = "0xD19AA0", VA = "0x180D1A6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000689")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0xD1A9F0", Offset = "0xD19DF0", VA = "0x180D1A9F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EntityId
	{
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700068B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TextId
	{
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700068C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> Parameters
	{
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E36")]
	[Address(RVA = "0xD1A620", Offset = "0xD19A20", VA = "0x180D1A620")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityTalkEvent()
	{
	}

	[Token(Token = "0x6001E37")]
	[Address(RVA = "0xD1A580", Offset = "0xD19980", VA = "0x180D1A580")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityTalkEvent(EntityTalkEvent other)
	{
	}

	[Token(Token = "0x6001E38")]
	[Address(RVA = "0xD1A0F0", Offset = "0xD194F0", VA = "0x180D1A0F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityTalkEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0xD1A260", Offset = "0xD19660", VA = "0x180D1A260", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E3F")]
	[Address(RVA = "0xD1A1C0", Offset = "0xD195C0", VA = "0x180D1A1C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EntityTalkEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E40")]
	[Address(RVA = "0xAA90A0", Offset = "0xAA84A0", VA = "0x180AA90A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E41")]
	[Address(RVA = "0xD1A3F0", Offset = "0xD197F0", VA = "0x180D1A3F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E43")]
	[Address(RVA = "0xD1A8F0", Offset = "0xD19CF0", VA = "0x180D1A8F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E44")]
	[Address(RVA = "0xD19FE0", Offset = "0xD193E0", VA = "0x180D19FE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E45")]
	[Address(RVA = "0xD1A350", Offset = "0xD19750", VA = "0x180D1A350", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntityTalkEvent other)
	{
	}

	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E47")]
	[Address(RVA = "0xD1A7A0", Offset = "0xD19BA0", VA = "0x180D1A7A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
