using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000538")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightsEvent : IMessage<MapRunningFightsEvent>, IMessage, IEquatable<MapRunningFightsEvent>, IDeepCloneable<MapRunningFightsEvent>, IBufferMessage
{
	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightsEvent> _parser;

	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011B7")]
	public const int FightsFieldNumber = 1;

	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightExternalInformation> _repeated_fights_codec;

	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<FightExternalInformation> fights_;

	[Token(Token = "0x17000BB6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapRunningFightsEvent> Parser
	{
		[Token(Token = "0x6003754")]
		[Address(RVA = "0xA0EAE0", Offset = "0xA0DEE0", VA = "0x180A0EAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003755")]
		[Address(RVA = "0xA0EA30", Offset = "0xA0DE30", VA = "0x180A0EA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003756")]
		[Address(RVA = "0xA0ECF0", Offset = "0xA0E0F0", VA = "0x180A0ECF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightExternalInformation> Fights
	{
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003757")]
	[Address(RVA = "0xA0E9B0", Offset = "0xA0DDB0", VA = "0x180A0E9B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsEvent()
	{
	}

	[Token(Token = "0x6003758")]
	[Address(RVA = "0xA0E920", Offset = "0xA0DD20", VA = "0x180A0E920")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsEvent(MapRunningFightsEvent other)
	{
	}

	[Token(Token = "0x6003759")]
	[Address(RVA = "0xA0E470", Offset = "0xA0D870", VA = "0x180A0E470", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600375B")]
	[Address(RVA = "0xA0E530", Offset = "0xA0D930", VA = "0x180A0E530", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600375C")]
	[Address(RVA = "0xA0E610", Offset = "0xA0DA10", VA = "0x180A0E610", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600375D")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600375E")]
	[Address(RVA = "0xA0E720", Offset = "0xA0DB20", VA = "0x180A0E720", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600375F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003760")]
	[Address(RVA = "0xA0EC40", Offset = "0xA0E040", VA = "0x180A0EC40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003761")]
	[Address(RVA = "0xA0E3D0", Offset = "0xA0D7D0", VA = "0x180A0E3D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003762")]
	[Address(RVA = "0xA0E6A0", Offset = "0xA0DAA0", VA = "0x180A0E6A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapRunningFightsEvent other)
	{
	}

	[Token(Token = "0x6003763")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003764")]
	[Address(RVA = "0xA0EB30", Offset = "0xA0DF30", VA = "0x180A0EB30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
