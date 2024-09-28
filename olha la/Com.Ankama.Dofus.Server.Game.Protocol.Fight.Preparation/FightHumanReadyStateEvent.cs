using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000637")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightHumanReadyStateEvent : IMessage<FightHumanReadyStateEvent>, IMessage, IEquatable<FightHumanReadyStateEvent>, IDeepCloneable<FightHumanReadyStateEvent>, IBufferMessage
{
	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightHumanReadyStateEvent> _parser;

	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015ED")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x40015EF")]
	public const int IsReadyFieldNumber = 2;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x20")]
	private bool isReady_;

	[Token(Token = "0x17000E51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightHumanReadyStateEvent> Parser
	{
		[Token(Token = "0x600429E")]
		[Address(RVA = "0xA7BEC0", Offset = "0xA7B2C0", VA = "0x180A7BEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600429F")]
		[Address(RVA = "0xA7BE10", Offset = "0xA7B210", VA = "0x180A7BE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E53")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60042A0")]
		[Address(RVA = "0xA7BF10", Offset = "0xA7B310", VA = "0x180A7BF10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E54")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000E55")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsReady
	{
		[Token(Token = "0x60042A6")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042A7")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x60042A1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightHumanReadyStateEvent()
	{
	}

	[Token(Token = "0x60042A2")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightHumanReadyStateEvent(FightHumanReadyStateEvent other)
	{
	}

	[Token(Token = "0x60042A3")]
	[Address(RVA = "0xA7BAB0", Offset = "0xA7AEB0", VA = "0x180A7BAB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightHumanReadyStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60042A8")]
	[Address(RVA = "0xA7BB40", Offset = "0xA7AF40", VA = "0x180A7BB40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042A9")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightHumanReadyStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042AA")]
	[Address(RVA = "0xA7BBE0", Offset = "0xA7AFE0", VA = "0x180A7BBE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60042AB")]
	[Address(RVA = "0xA7BCB0", Offset = "0xA7B0B0", VA = "0x180A7BCB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60042AC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60042AD")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60042AE")]
	[Address(RVA = "0xA7BA20", Offset = "0xA7AE20", VA = "0x180A7BA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60042AF")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightHumanReadyStateEvent other)
	{
	}

	[Token(Token = "0x60042B0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60042B1")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
