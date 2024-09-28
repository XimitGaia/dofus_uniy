using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200062D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsCancelledEvent : IMessage<FightPlacementSwapPositionsCancelledEvent>, IMessage, IEquatable<FightPlacementSwapPositionsCancelledEvent>, IDeepCloneable<FightPlacementSwapPositionsCancelledEvent>, IBufferMessage
{
	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsCancelledEvent> _parser;

	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015C5")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x40015C6")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x40015C7")]
	public const int CancellerIdFieldNumber = 2;

	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0x20")]
	private long cancellerId_;

	[Token(Token = "0x17000E36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPlacementSwapPositionsCancelledEvent> Parser
	{
		[Token(Token = "0x6004223")]
		[Address(RVA = "0xA801E0", Offset = "0xA7F5E0", VA = "0x180A801E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004224")]
		[Address(RVA = "0xA80130", Offset = "0xA7F530", VA = "0x180A80130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E38")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004225")]
		[Address(RVA = "0xA80230", Offset = "0xA7F630", VA = "0x180A80230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E39")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RequestId
	{
		[Token(Token = "0x6004229")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CancellerId
	{
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004226")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsCancelledEvent()
	{
	}

	[Token(Token = "0x6004227")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPlacementSwapPositionsCancelledEvent(FightPlacementSwapPositionsCancelledEvent other)
	{
	}

	[Token(Token = "0x6004228")]
	[Address(RVA = "0xA7FEA0", Offset = "0xA7F2A0", VA = "0x180A7FEA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsCancelledEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600422D")]
	[Address(RVA = "0xA7FF30", Offset = "0xA7F330", VA = "0x180A7FF30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600422E")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPlacementSwapPositionsCancelledEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600422F")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004230")]
	[Address(RVA = "0xA7FFD0", Offset = "0xA7F3D0", VA = "0x180A7FFD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004231")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004232")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004233")]
	[Address(RVA = "0xA7FDE0", Offset = "0xA7F1E0", VA = "0x180A7FDE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004234")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementSwapPositionsCancelledEvent other)
	{
	}

	[Token(Token = "0x6004235")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004236")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
