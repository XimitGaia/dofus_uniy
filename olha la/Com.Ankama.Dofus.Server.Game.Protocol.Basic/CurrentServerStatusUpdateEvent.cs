using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B56")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CurrentServerStatusUpdateEvent : IMessage<CurrentServerStatusUpdateEvent>, IMessage, IEquatable<CurrentServerStatusUpdateEvent>, IDeepCloneable<CurrentServerStatusUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x2000B57")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000B58")]
		public enum ServerStatus
		{
			[Token(Token = "0x4002A69")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4002A6A")]
			[OriginalName("OFFLINE")]
			Offline,
			[Token(Token = "0x4002A6B")]
			[OriginalName("STARTING")]
			Starting,
			[Token(Token = "0x4002A6C")]
			[OriginalName("ONLINE")]
			Online,
			[Token(Token = "0x4002A6D")]
			[OriginalName("NO_JOIN")]
			NoJoin,
			[Token(Token = "0x4002A6E")]
			[OriginalName("SAVING")]
			Saving,
			[Token(Token = "0x4002A6F")]
			[OriginalName("STOPPING")]
			Stopping,
			[Token(Token = "0x4002A70")]
			[OriginalName("FULL")]
			Full
		}
	}

	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CurrentServerStatusUpdateEvent> _parser;

	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A66")]
	public const int StatusFieldNumber = 1;

	[Token(Token = "0x4002A67")]
	[FieldOffset(Offset = "0x18")]
	private Types.ServerStatus status_;

	[Token(Token = "0x17001A5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CurrentServerStatusUpdateEvent> Parser
	{
		[Token(Token = "0x6007794")]
		[Address(RVA = "0xC237C0", Offset = "0xC22BC0", VA = "0x180C237C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007795")]
		[Address(RVA = "0xC23710", Offset = "0xC22B10", VA = "0x180C23710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A5C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007796")]
		[Address(RVA = "0xC23810", Offset = "0xC22C10", VA = "0x180C23810", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ServerStatus Status
	{
		[Token(Token = "0x600779A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.ServerStatus);
		}
		[Token(Token = "0x600779B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007797")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrentServerStatusUpdateEvent()
	{
	}

	[Token(Token = "0x6007798")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CurrentServerStatusUpdateEvent(CurrentServerStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6007799")]
	[Address(RVA = "0xC234A0", Offset = "0xC228A0", VA = "0x180C234A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrentServerStatusUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600779C")]
	[Address(RVA = "0xC23520", Offset = "0xC22920", VA = "0x180C23520", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600779D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CurrentServerStatusUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600779E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600779F")]
	[Address(RVA = "0xC235B0", Offset = "0xC229B0", VA = "0x180C235B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60077A0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60077A1")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60077A2")]
	[Address(RVA = "0xC23410", Offset = "0xC22810", VA = "0x180C23410", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60077A3")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CurrentServerStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x60077A4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60077A5")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
