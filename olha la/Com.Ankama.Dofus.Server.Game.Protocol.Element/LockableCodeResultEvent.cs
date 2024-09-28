using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x2000752")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockableCodeResultEvent : IMessage<LockableCodeResultEvent>, IMessage, IEquatable<LockableCodeResultEvent>, IDeepCloneable<LockableCodeResultEvent>, IBufferMessage
{
	[Token(Token = "0x2000753")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000754")]
		public enum LockableResult
		{
			[Token(Token = "0x40019BF")]
			[OriginalName("UNLOCKED")]
			Unlocked,
			[Token(Token = "0x40019C0")]
			[OriginalName("CODE_ERROR")]
			CodeError,
			[Token(Token = "0x40019C1")]
			[OriginalName("UNLOCK_FORBIDDEN")]
			UnlockForbidden
		}
	}

	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LockableCodeResultEvent> _parser;

	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019BC")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x18")]
	private Types.LockableResult result_;

	[Token(Token = "0x170010CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<LockableCodeResultEvent> Parser
	{
		[Token(Token = "0x6004E78")]
		[Address(RVA = "0xAC20C0", Offset = "0xAC14C0", VA = "0x180AC20C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E79")]
		[Address(RVA = "0xAC2010", Offset = "0xAC1410", VA = "0x180AC2010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0xAC2110", Offset = "0xAC1510", VA = "0x180AC2110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.LockableResult Result
	{
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.LockableResult);
		}
		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004E7B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableCodeResultEvent()
	{
	}

	[Token(Token = "0x6004E7C")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableCodeResultEvent(LockableCodeResultEvent other)
	{
	}

	[Token(Token = "0x6004E7D")]
	[Address(RVA = "0xAC1DA0", Offset = "0xAC11A0", VA = "0x180AC1DA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableCodeResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E80")]
	[Address(RVA = "0xAC1E20", Offset = "0xAC1220", VA = "0x180AC1E20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E81")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockableCodeResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E82")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E83")]
	[Address(RVA = "0xAC1EB0", Offset = "0xAC12B0", VA = "0x180AC1EB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E84")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E85")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E86")]
	[Address(RVA = "0xAC1D10", Offset = "0xAC1110", VA = "0x180AC1D10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E87")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LockableCodeResultEvent other)
	{
	}

	[Token(Token = "0x6004E88")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E89")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
