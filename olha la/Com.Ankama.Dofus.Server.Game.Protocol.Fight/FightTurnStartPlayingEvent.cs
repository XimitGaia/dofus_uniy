using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnStartPlayingEvent : IMessage<FightTurnStartPlayingEvent>, IMessage, IEquatable<FightTurnStartPlayingEvent>, IDeepCloneable<FightTurnStartPlayingEvent>, IBufferMessage
{
	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnStartPlayingEvent> _parser;

	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000DA6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTurnStartPlayingEvent> Parser
	{
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0xA4EBB0", Offset = "0xA4DFB0", VA = "0x180A4EBB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F84")]
		[Address(RVA = "0xA4EB00", Offset = "0xA4DF00", VA = "0x180A4EB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0xA4EC00", Offset = "0xA4E000", VA = "0x180A4EC00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F86")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnStartPlayingEvent()
	{
	}

	[Token(Token = "0x6003F87")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnStartPlayingEvent(FightTurnStartPlayingEvent other)
	{
	}

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0xA4E8A0", Offset = "0xA4DCA0", VA = "0x180A4E8A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnStartPlayingEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F89")]
	[Address(RVA = "0xA4E920", Offset = "0xA4DD20", VA = "0x180A4E920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTurnStartPlayingEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F8B")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F8C")]
	[Address(RVA = "0xA4E9A0", Offset = "0xA4DDA0", VA = "0x180A4E9A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F8E")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F90")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTurnStartPlayingEvent other)
	{
	}

	[Token(Token = "0x6003F91")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F92")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
