using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move;

[Token(Token = "0x20005D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishMoveSetRequest : IMessage<FinishMoveSetRequest>, IMessage, IEquatable<FinishMoveSetRequest>, IDeepCloneable<FinishMoveSetRequest>, IBufferMessage
{
	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FinishMoveSetRequest> _parser;

	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001460")]
	public const int FinishMoveIdFieldNumber = 1;

	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0x18")]
	private int finishMoveId_;

	[Token(Token = "0x4001462")]
	public const int EffectiveFieldNumber = 2;

	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x1C")]
	private bool effective_;

	[Token(Token = "0x17000D5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishMoveSetRequest> Parser
	{
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0xA4F970", Offset = "0xA4ED70", VA = "0x180A4F970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0xA4F8C0", Offset = "0xA4ECC0", VA = "0x180A4F8C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0xA4F9C0", Offset = "0xA4EDC0", VA = "0x180A4F9C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FinishMoveId
	{
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000D5F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Effective
	{
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6003E50")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMoveSetRequest()
	{
	}

	[Token(Token = "0x6003E51")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishMoveSetRequest(FinishMoveSetRequest other)
	{
	}

	[Token(Token = "0x6003E52")]
	[Address(RVA = "0xA4F580", Offset = "0xA4E980", VA = "0x180A4F580", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FinishMoveSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003E57")]
	[Address(RVA = "0xA4F610", Offset = "0xA4EA10", VA = "0x180A4F610", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E58")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishMoveSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E59")]
	[Address(RVA = "0xA4F6A0", Offset = "0xA4EAA0", VA = "0x180A4F6A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003E5A")]
	[Address(RVA = "0xA4F760", Offset = "0xA4EB60", VA = "0x180A4F760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003E5B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003E5C")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003E5D")]
	[Address(RVA = "0xA4F4F0", Offset = "0xA4E8F0", VA = "0x180A4F4F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003E5E")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishMoveSetRequest other)
	{
	}

	[Token(Token = "0x6003E5F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003E60")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
