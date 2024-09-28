using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BA6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaPlayerBehavioursEvent : IMessage<ArenaPlayerBehavioursEvent>, IMessage, IEquatable<ArenaPlayerBehavioursEvent>, IDeepCloneable<ArenaPlayerBehavioursEvent>, IBufferMessage
{
	[Token(Token = "0x4002B7D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaPlayerBehavioursEvent> _parser;

	[Token(Token = "0x4002B7E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B7F")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002B80")]
	public const int FlagsFieldNumber = 1;

	[Token(Token = "0x4002B81")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_flags_codec;

	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> flags_;

	[Token(Token = "0x4002B83")]
	public const int SanctionsFieldNumber = 2;

	[Token(Token = "0x4002B84")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<string> _repeated_sanctions_codec;

	[Token(Token = "0x4002B85")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<string> sanctions_;

	[Token(Token = "0x4002B86")]
	public const int BanDurationFieldNumber = 3;

	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int BanDurationDefaultValue;

	[Token(Token = "0x4002B88")]
	[FieldOffset(Offset = "0x30")]
	private int banDuration_;

	[Token(Token = "0x17001AFC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaPlayerBehavioursEvent> Parser
	{
		[Token(Token = "0x6007A86")]
		[Address(RVA = "0xC30ED0", Offset = "0xC302D0", VA = "0x180C30ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007A87")]
		[Address(RVA = "0xC30E20", Offset = "0xC30220", VA = "0x180C30E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AFE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007A88")]
		[Address(RVA = "0xC311F0", Offset = "0xC305F0", VA = "0x180C311F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AFF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> Flags
	{
		[Token(Token = "0x6007A8C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> Sanctions
	{
		[Token(Token = "0x6007A8D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B01")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BanDuration
	{
		[Token(Token = "0x6007A8E")]
		[Address(RVA = "0xC30DB0", Offset = "0xC301B0", VA = "0x180C30DB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A8F")]
		[Address(RVA = "0xA4D370", Offset = "0xA4C770", VA = "0x180A4D370")]
		set
		{
		}
	}

	[Token(Token = "0x17001B02")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasBanDuration
	{
		[Token(Token = "0x6007A90")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007A89")]
	[Address(RVA = "0xC30D00", Offset = "0xC30100", VA = "0x180C30D00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaPlayerBehavioursEvent()
	{
	}

	[Token(Token = "0x6007A8A")]
	[Address(RVA = "0xC30C40", Offset = "0xC30040", VA = "0x180C30C40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaPlayerBehavioursEvent(ArenaPlayerBehavioursEvent other)
	{
	}

	[Token(Token = "0x6007A8B")]
	[Address(RVA = "0xC305B0", Offset = "0xC2F9B0", VA = "0x180C305B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaPlayerBehavioursEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007A91")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBanDuration()
	{
	}

	[Token(Token = "0x6007A92")]
	[Address(RVA = "0xC306A0", Offset = "0xC2FAA0", VA = "0x180C306A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A93")]
	[Address(RVA = "0xC307C0", Offset = "0xC2FBC0", VA = "0x180C307C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ArenaPlayerBehavioursEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A94")]
	[Address(RVA = "0xC308A0", Offset = "0xC2FCA0", VA = "0x180C308A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007A95")]
	[Address(RVA = "0xC30A60", Offset = "0xC2FE60", VA = "0x180C30A60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007A96")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007A97")]
	[Address(RVA = "0xC310A0", Offset = "0xC304A0", VA = "0x180C310A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007A98")]
	[Address(RVA = "0xC30450", Offset = "0xC2F850", VA = "0x180C30450", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007A99")]
	[Address(RVA = "0xC309B0", Offset = "0xC2FDB0", VA = "0x180C309B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaPlayerBehavioursEvent other)
	{
	}

	[Token(Token = "0x6007A9A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007A9B")]
	[Address(RVA = "0xC30F20", Offset = "0xC30320", VA = "0x180C30F20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
