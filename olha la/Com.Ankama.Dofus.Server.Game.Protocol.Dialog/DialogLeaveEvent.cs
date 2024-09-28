using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog;

[Token(Token = "0x2000760")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DialogLeaveEvent : IMessage<DialogLeaveEvent>, IMessage, IEquatable<DialogLeaveEvent>, IDeepCloneable<DialogLeaveEvent>, IBufferMessage
{
	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DialogLeaveEvent> _parser;

	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019DF")]
	public const int DialogTypeFieldNumber = 1;

	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x18")]
	private DialogType dialogType_;

	[Token(Token = "0x170010E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DialogLeaveEvent> Parser
	{
		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0xADA150", Offset = "0xAD9550", VA = "0x180ADA150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0xADA0A0", Offset = "0xAD94A0", VA = "0x180ADA0A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0xADA1A0", Offset = "0xAD95A0", VA = "0x180ADA1A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DialogType DialogType
	{
		[Token(Token = "0x6004EF4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(DialogType);
		}
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004EF1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogLeaveEvent()
	{
	}

	[Token(Token = "0x6004EF2")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogLeaveEvent(DialogLeaveEvent other)
	{
	}

	[Token(Token = "0x6004EF3")]
	[Address(RVA = "0xAD9E30", Offset = "0xAD9230", VA = "0x180AD9E30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogLeaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004EF6")]
	[Address(RVA = "0xAD9EB0", Offset = "0xAD92B0", VA = "0x180AD9EB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EF7")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DialogLeaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EF8")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004EF9")]
	[Address(RVA = "0xAD9F40", Offset = "0xAD9340", VA = "0x180AD9F40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004EFA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004EFB")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004EFC")]
	[Address(RVA = "0xAD9DA0", Offset = "0xAD91A0", VA = "0x180AD9DA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004EFD")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DialogLeaveEvent other)
	{
	}

	[Token(Token = "0x6004EFE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004EFF")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
