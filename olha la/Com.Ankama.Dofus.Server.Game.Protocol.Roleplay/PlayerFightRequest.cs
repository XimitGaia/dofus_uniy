using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000162")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerFightRequest : IMessage<PlayerFightRequest>, IMessage, IEquatable<PlayerFightRequest>, IDeepCloneable<PlayerFightRequest>, IBufferMessage
{
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerFightRequest> _parser;

	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004B0")]
	public const int TargetIdFieldNumber = 1;

	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x18")]
	private long targetId_;

	[Token(Token = "0x40004B2")]
	public const int TargetCellIdFieldNumber = 2;

	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x20")]
	private int targetCellId_;

	[Token(Token = "0x40004B4")]
	public const int FriendlyFieldNumber = 3;

	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x24")]
	private bool friendly_;

	[Token(Token = "0x170002ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlayerFightRequest> Parser
	{
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0xC48E30", Offset = "0xC48230", VA = "0x180C48E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0xC48D80", Offset = "0xC48180", VA = "0x180C48D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0xC48FF0", Offset = "0xC483F0", VA = "0x180C48FF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170002F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TargetCellId
	{
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170002F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Friendly
	{
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightRequest()
	{
	}

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0xC48D20", Offset = "0xC48120", VA = "0x180C48D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightRequest(PlayerFightRequest other)
	{
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0xC48900", Offset = "0xC47D00", VA = "0x180C48900", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0xC48990", Offset = "0xC47D90", VA = "0x180C48990", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0xC48A30", Offset = "0xC47E30", VA = "0x180C48A30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PlayerFightRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0xC48A70", Offset = "0xC47E70", VA = "0x180C48A70", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0xC48BC0", Offset = "0xC47FC0", VA = "0x180C48BC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0xC48F50", Offset = "0xC48350", VA = "0x180C48F50", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0xC48830", Offset = "0xC47C30", VA = "0x180C48830", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0xC48B50", Offset = "0xC47F50", VA = "0x180C48B50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerFightRequest other)
	{
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0xC48E80", Offset = "0xC48280", VA = "0x180C48E80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
