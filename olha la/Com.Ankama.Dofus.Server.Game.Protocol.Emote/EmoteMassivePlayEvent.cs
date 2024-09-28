using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x2000741")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmoteMassivePlayEvent : IMessage<EmoteMassivePlayEvent>, IMessage, IEquatable<EmoteMassivePlayEvent>, IDeepCloneable<EmoteMassivePlayEvent>, IBufferMessage
{
	[Token(Token = "0x4001986")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmoteMassivePlayEvent> _parser;

	[Token(Token = "0x4001987")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001988")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4001989")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x400198A")]
	public const int EmoteStartTimeFieldNumber = 2;

	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x20")]
	private long emoteStartTime_;

	[Token(Token = "0x400198C")]
	public const int ActorsIdFieldNumber = 3;

	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_actorsId_codec;

	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<long> actorsId_;

	[Token(Token = "0x170010AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EmoteMassivePlayEvent> Parser
	{
		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0xAB5410", Offset = "0xAB4810", VA = "0x180AB5410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0xAB5360", Offset = "0xAB4760", VA = "0x180AB5360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0xAB56B0", Offset = "0xAB4AB0", VA = "0x180AB56B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170010B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EmoteStartTime
	{
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170010B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> ActorsId
	{
		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004DE8")]
	[Address(RVA = "0xAB5240", Offset = "0xAB4640", VA = "0x180AB5240")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteMassivePlayEvent()
	{
	}

	[Token(Token = "0x6004DE9")]
	[Address(RVA = "0xAB52C0", Offset = "0xAB46C0", VA = "0x180AB52C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteMassivePlayEvent(EmoteMassivePlayEvent other)
	{
	}

	[Token(Token = "0x6004DEA")]
	[Address(RVA = "0xAB4DB0", Offset = "0xAB41B0", VA = "0x180AB4DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmoteMassivePlayEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004DF0")]
	[Address(RVA = "0xAB4F20", Offset = "0xAB4320", VA = "0x180AB4F20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DF1")]
	[Address(RVA = "0xAB4E80", Offset = "0xAB4280", VA = "0x180AB4E80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EmoteMassivePlayEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004DF2")]
	[Address(RVA = "0x95E760", Offset = "0x95DB60", VA = "0x18095E760", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004DF3")]
	[Address(RVA = "0xAB50B0", Offset = "0xAB44B0", VA = "0x180AB50B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004DF4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004DF5")]
	[Address(RVA = "0xAB55B0", Offset = "0xAB49B0", VA = "0x180AB55B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004DF6")]
	[Address(RVA = "0xAB4CA0", Offset = "0xAB40A0", VA = "0x180AB4CA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004DF7")]
	[Address(RVA = "0xAB5010", Offset = "0xAB4410", VA = "0x180AB5010", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EmoteMassivePlayEvent other)
	{
	}

	[Token(Token = "0x6004DF8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004DF9")]
	[Address(RVA = "0xAB5460", Offset = "0xAB4860", VA = "0x180AB5460", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
