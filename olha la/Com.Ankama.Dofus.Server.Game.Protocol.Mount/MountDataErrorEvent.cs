using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200031F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountDataErrorEvent : IMessage<MountDataErrorEvent>, IMessage, IEquatable<MountDataErrorEvent>, IDeepCloneable<MountDataErrorEvent>, IBufferMessage
{
	[Token(Token = "0x2000320")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000321")]
		public enum MountDataError
		{
			[Token(Token = "0x4000ADD")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4000ADE")]
			[OriginalName("NOT_FOUND")]
			NotFound,
			[Token(Token = "0x4000ADF")]
			[OriginalName("SOMEONE_ELSE_PRIVATE_FARM")]
			SomeoneElsePrivateFarm,
			[Token(Token = "0x4000AE0")]
			[OriginalName("SOMEONE_ELSE_MOUNT")]
			SomeoneElseMount
		}
	}

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountDataErrorEvent> _parser;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ADA")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x18")]
	private Types.MountDataError reason_;

	[Token(Token = "0x170006F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountDataErrorEvent> Parser
	{
		[Token(Token = "0x6002069")]
		[Address(RVA = "0xD1B860", Offset = "0xD1AC60", VA = "0x180D1B860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600206A")]
		[Address(RVA = "0xD1B7B0", Offset = "0xD1ABB0", VA = "0x180D1B7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600206B")]
		[Address(RVA = "0xD1B8B0", Offset = "0xD1ACB0", VA = "0x180D1B8B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.MountDataError Reason
	{
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.MountDataError);
		}
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountDataErrorEvent()
	{
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountDataErrorEvent(MountDataErrorEvent other)
	{
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0xD1B540", Offset = "0xD1A940", VA = "0x180D1B540", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountDataErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0xD1B5C0", Offset = "0xD1A9C0", VA = "0x180D1B5C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountDataErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0xD1B650", Offset = "0xD1AA50", VA = "0x180D1B650", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0xD1B4B0", Offset = "0xD1A8B0", VA = "0x180D1B4B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountDataErrorEvent other)
	{
	}

	[Token(Token = "0x6002079")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600207A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
