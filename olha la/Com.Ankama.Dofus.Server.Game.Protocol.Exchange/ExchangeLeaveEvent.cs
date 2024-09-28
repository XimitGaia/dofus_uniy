using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006CF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeLeaveEvent : IMessage<ExchangeLeaveEvent>, IMessage, IEquatable<ExchangeLeaveEvent>, IDeepCloneable<ExchangeLeaveEvent>, IBufferMessage
{
	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeLeaveEvent> _parser;

	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017EE")]
	public const int DialogTypeFieldNumber = 1;

	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x18")]
	private DialogType dialogType_;

	[Token(Token = "0x40017F0")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x40017F1")]
	[FieldOffset(Offset = "0x1C")]
	private bool success_;

	[Token(Token = "0x17000FA8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeLeaveEvent> Parser
	{
		[Token(Token = "0x600493B")]
		[Address(RVA = "0xAA78F0", Offset = "0xAA6CF0", VA = "0x180AA78F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600493C")]
		[Address(RVA = "0xAA7840", Offset = "0xAA6C40", VA = "0x180AA7840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600493D")]
		[Address(RVA = "0xAA79C0", Offset = "0xAA6DC0", VA = "0x180AA79C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DialogType DialogType
	{
		[Token(Token = "0x6004941")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(DialogType);
		}
		[Token(Token = "0x6004942")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000FAC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6004943")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x600493E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeLeaveEvent()
	{
	}

	[Token(Token = "0x600493F")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeLeaveEvent(ExchangeLeaveEvent other)
	{
	}

	[Token(Token = "0x6004940")]
	[Address(RVA = "0xAA7500", Offset = "0xAA6900", VA = "0x180AA7500", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeLeaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004945")]
	[Address(RVA = "0xAA7590", Offset = "0xAA6990", VA = "0x180AA7590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004946")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeLeaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004947")]
	[Address(RVA = "0xAA7620", Offset = "0xAA6A20", VA = "0x180AA7620", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004948")]
	[Address(RVA = "0xAA76E0", Offset = "0xAA6AE0", VA = "0x180AA76E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004949")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600494A")]
	[Address(RVA = "0xAA7940", Offset = "0xAA6D40", VA = "0x180AA7940", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600494B")]
	[Address(RVA = "0xAA7470", Offset = "0xAA6870", VA = "0x180AA7470", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600494C")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeLeaveEvent other)
	{
	}

	[Token(Token = "0x600494D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600494E")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
