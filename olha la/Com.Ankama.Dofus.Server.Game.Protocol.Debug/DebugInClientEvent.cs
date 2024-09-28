using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug;

[Token(Token = "0x2000771")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DebugInClientEvent : IMessage<DebugInClientEvent>, IMessage, IEquatable<DebugInClientEvent>, IDeepCloneable<DebugInClientEvent>, IBufferMessage
{
	[Token(Token = "0x2000772")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000773")]
		public enum DebugLevel
		{
			[Token(Token = "0x4001A0E")]
			[OriginalName("TRACE")]
			Trace,
			[Token(Token = "0x4001A0F")]
			[OriginalName("DEBUG")]
			Debug,
			[Token(Token = "0x4001A10")]
			[OriginalName("INFO")]
			Info,
			[Token(Token = "0x4001A11")]
			[OriginalName("WARN")]
			Warn,
			[Token(Token = "0x4001A12")]
			[OriginalName("ERROR")]
			Error,
			[Token(Token = "0x4001A13")]
			[OriginalName("FATAL")]
			Fatal
		}
	}

	[Token(Token = "0x4001A07")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DebugInClientEvent> _parser;

	[Token(Token = "0x4001A08")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A09")]
	public const int LevelFieldNumber = 1;

	[Token(Token = "0x4001A0A")]
	[FieldOffset(Offset = "0x18")]
	private Types.DebugLevel level_;

	[Token(Token = "0x4001A0B")]
	public const int MessageFieldNumber = 2;

	[Token(Token = "0x4001A0C")]
	[FieldOffset(Offset = "0x20")]
	private string message_;

	[Token(Token = "0x17001101")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DebugInClientEvent> Parser
	{
		[Token(Token = "0x6004F88")]
		[Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001102")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F89")]
		[Address(RVA = "0xAD9010", Offset = "0xAD8410", VA = "0x180AD9010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001103")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0xAD9270", Offset = "0xAD8670", VA = "0x180AD9270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001104")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.DebugLevel Level
	{
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.DebugLevel);
		}
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001105")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message
	{
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0xAD9350", Offset = "0xAD8750", VA = "0x180AD9350")]
		set
		{
		}
	}

	[Token(Token = "0x6004F8B")]
	[Address(RVA = "0xAD8FC0", Offset = "0xAD83C0", VA = "0x180AD8FC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebugInClientEvent()
	{
	}

	[Token(Token = "0x6004F8C")]
	[Address(RVA = "0xAD8F10", Offset = "0xAD8310", VA = "0x180AD8F10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebugInClientEvent(DebugInClientEvent other)
	{
	}

	[Token(Token = "0x6004F8D")]
	[Address(RVA = "0xAD8AC0", Offset = "0xAD7EC0", VA = "0x180AD8AC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebugInClientEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F92")]
	[Address(RVA = "0xAD8C00", Offset = "0xAD8000", VA = "0x180AD8C00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F93")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DebugInClientEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F94")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F95")]
	[Address(RVA = "0xAD8DB0", Offset = "0xAD81B0", VA = "0x180AD8DB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F96")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F97")]
	[Address(RVA = "0xAD91E0", Offset = "0xAD85E0", VA = "0x180AD91E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F98")]
	[Address(RVA = "0xAD8A00", Offset = "0xAD7E00", VA = "0x180AD8A00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F99")]
	[Address(RVA = "0xAD8D40", Offset = "0xAD8140", VA = "0x180AD8D40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DebugInClientEvent other)
	{
	}

	[Token(Token = "0x6004F9A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F9B")]
	[Address(RVA = "0xAD9110", Offset = "0xAD8510", VA = "0x180AD9110", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
