using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200052E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapChangeOrientationEvent : IMessage<MapChangeOrientationEvent>, IMessage, IEquatable<MapChangeOrientationEvent>, IDeepCloneable<MapChangeOrientationEvent>, IBufferMessage
{
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapChangeOrientationEvent> _parser;

	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001198")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x400119A")]
	public const int DirectionFieldNumber = 2;

	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0x20")]
	private Direction direction_;

	[Token(Token = "0x17000B9F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapChangeOrientationEvent> Parser
	{
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0xA01BF0", Offset = "0xA00FF0", VA = "0x180A01BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0xA01B40", Offset = "0xA00F40", VA = "0x180A01B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0xA01C40", Offset = "0xA01040", VA = "0x180A01C40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ActorId
	{
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000BA3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Direction Direction
	{
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60036E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapChangeOrientationEvent()
	{
	}

	[Token(Token = "0x60036E4")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeOrientationEvent(MapChangeOrientationEvent other)
	{
	}

	[Token(Token = "0x60036E5")]
	[Address(RVA = "0xA018B0", Offset = "0xA00CB0", VA = "0x180A018B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeOrientationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60036EA")]
	[Address(RVA = "0xA01940", Offset = "0xA00D40", VA = "0x180A01940", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036EB")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapChangeOrientationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036EC")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60036ED")]
	[Address(RVA = "0xA019E0", Offset = "0xA00DE0", VA = "0x180A019E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60036EE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60036EF")]
	[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60036F0")]
	[Address(RVA = "0xA017F0", Offset = "0xA00BF0", VA = "0x180A017F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60036F1")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapChangeOrientationEvent other)
	{
	}

	[Token(Token = "0x60036F2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60036F3")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
