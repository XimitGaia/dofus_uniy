using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005F3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPauseEvent : IMessage<FightPauseEvent>, IMessage, IEquatable<FightPauseEvent>, IDeepCloneable<FightPauseEvent>, IBufferMessage
{
	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPauseEvent> _parser;

	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014DC")]
	public const int IsPausedFieldNumber = 1;

	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x18")]
	private bool isPaused_;

	[Token(Token = "0x17000DA9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPauseEvent> Parser
	{
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0xA41C70", Offset = "0xA41070", VA = "0x180A41C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0xA41BC0", Offset = "0xA40FC0", VA = "0x180A41BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DAB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0xA41CC0", Offset = "0xA410C0", VA = "0x180A41CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DAC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsPaused
	{
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6003F9A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPauseEvent()
	{
	}

	[Token(Token = "0x6003F9B")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPauseEvent(FightPauseEvent other)
	{
	}

	[Token(Token = "0x6003F9C")]
	[Address(RVA = "0xA418B0", Offset = "0xA40CB0", VA = "0x180A418B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPauseEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F9F")]
	[Address(RVA = "0xA41930", Offset = "0xA40D30", VA = "0x180A41930", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FA0")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPauseEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0xA419C0", Offset = "0xA40DC0", VA = "0x180A419C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003FA2")]
	[Address(RVA = "0xA41A60", Offset = "0xA40E60", VA = "0x180A41A60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003FA3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003FA4")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003FA5")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003FA6")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPauseEvent other)
	{
	}

	[Token(Token = "0x6003FA7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003FA8")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
